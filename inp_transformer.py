import re
from collections import OrderedDict

INPUT_PATH = 'inp/original.inp'
FORMAT_PATH = 'inp/format.inp'
OUTPUT_PATH = 'inp/output.inp'

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


def replace_blocks(output_path, original_file_path, alternative_file_path, block_to_remove, block_to_add):
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


def main():
    replace_blocks(output_path=OUTPUT_PATH,
                   original_file_path=INPUT_PATH,
                   alternative_file_path=FORMAT_PATH,
                   block_to_remove='[INFLOWS]',
                   block_to_add='[POLLUTANTS]')


if __name__ == '__main__':
    main()
