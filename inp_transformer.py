import re
from collections import OrderedDict

INPUT_PATH = 'inp/original.inp'
FORMAT_PATH = 'inp/format.inp'
REPLACE_OUTPUT_PATH = 'inp/replace_output.inp'
MERGE_OUTPUT_PATH = 'inp/merge_output.inp'

block_to_take_from_format = [
    '[OPTIONS]',
    '[POLLUTANTS]',
    # '[PROFILES]'  # TODO(omermadmon): figure out if this is needed.
]

block_to_take_from_original = [
    '[JUNCTIONS]',
    '[OUTFALLS]',
    '[CONDUITS]',
    '[XSECTIONS]',
    # '[CURVES]'  # TODO(omermadmon): figure out if this is needed.
    # '[REPORT]'  # TODO(omermadmon): figure out if this is needed.
    '[TAGS]',
    '[MAP]',
    '[COORDINATES]',
    '[VERTICES]'
]

# TODO(omermadmon): add a function for adding rows for [POLLUTANTS]


def extract_lines(path):
    # TODO(omermadmon): verify encoding.
    with open(path, "r", encoding="utf8") as f:
        return f.readlines()


def split_inp_to_blocks(path):
    res = OrderedDict()
    lines = extract_lines(path)
    current_title, current_block = '', [-1]
    for i, line in enumerate(lines):
        if re.match('\[[A-Z]*\]', line):
            current_block.append(i - 1)
            res[current_title] = tuple(current_block)
            current_title = line[:-1]
            current_block = [i]
    # Append last block:
    current_block.append(len(lines) - 1)
    res[current_title] = tuple(current_block)
    del res['']
    return res


def replace_blocks(output_path, original_file_path, alternative_file_path,
                   block_to_remove, block_to_add):
    # Load original and alternative files:
    original_lines = extract_lines(original_file_path)
    alternative_lines = extract_lines(alternative_file_path)

    # Split original and alternative files to blocks and validate blocks to swap:
    original_blocks = split_inp_to_blocks(original_file_path)
    alternative_blocks = split_inp_to_blocks(alternative_file_path)
    assert block_to_remove in original_blocks.keys()
    assert block_to_add in alternative_blocks.keys()

    # Write output file:
    with open(output_path, "w") as f:
        for block in original_blocks.keys():
            if block == block_to_remove:
                beg, end = alternative_blocks[block_to_add]
                for i in range(beg, end):
                    f.write(alternative_lines[i])
            else:
                beg, end = original_blocks[block]
                for i in range(beg, end):
                    f.write(original_lines[i])
            f.write('\n')


def merge_files(path_1, path_2, blocks_order, blocks_from_1, blocks_from_2, output_path):
    # Load files:
    lines_1 = extract_lines(path_1)
    lines_2 = extract_lines(path_2)

    # Split to blocks:
    blocks_of_1 = split_inp_to_blocks(path_1)
    blocks_of_2 = split_inp_to_blocks(path_2)

    # Write output file:
    with open(output_path, "w") as f:
        for block in blocks_order:
            if block in blocks_from_1:
                beg, end = blocks_of_1[block]
                for i in range(beg, end):
                    f.write(lines_1[i])
                f.write('\n')
            elif block in blocks_from_2:
                beg, end = blocks_of_2[block]
                for i in range(beg, end):
                    f.write(lines_2[i])
                f.write('\n')
            else:
                continue


def main():
    block_titles_union = set(split_inp_to_blocks(INPUT_PATH))\
        .union(set(split_inp_to_blocks(FORMAT_PATH)))

    replace_blocks(output_path=REPLACE_OUTPUT_PATH,
                   original_file_path=INPUT_PATH,
                   alternative_file_path=FORMAT_PATH,
                   block_to_remove='[INFLOWS]',
                   block_to_add='[POLLUTANTS]')

    merge_files(path_1=INPUT_PATH,
                path_2=FORMAT_PATH,
                blocks_order=block_titles_union,
                blocks_from_1=block_to_take_from_original,
                blocks_from_2=block_to_take_from_format,
                output_path=MERGE_OUTPUT_PATH)


if __name__ == '__main__':
    main()
