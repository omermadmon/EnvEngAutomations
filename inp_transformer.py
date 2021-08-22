import re
from collections import OrderedDict

INPUT_PATH = 'original.inp'
FORMAT_PATH = 'format.inp'
OUTPUT_PATH = 'output.inp'


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
    return res


def main():
    lines = extract_lines(INPUT_PATH)
    blocks = split_inp_to_blocks(INPUT_PATH)

    for title, (beg, end) in blocks.items():
        for i in range(beg, end):
            print(lines[i], end='')
        print()


if __name__ == '__main__':
    main()
