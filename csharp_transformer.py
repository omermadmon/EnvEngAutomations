EDGES_NUM = 5
INPUT_PATH = 'original.cs'
MID_PATH = 'mid.cs'
OUTPUT_PATH = 'output.cs'
PARAMS = ['Flow', 'Velocity', 'Depth']
PARAM_TO_CHAR = {'Flow': 'Q', 'Velocity': 'V', 'Depth': 'D'}


def extract_lines(path):
    # TODO(omermadmon): verify encoding.
    with open(path, "r", encoding="utf8") as f:
        return f.readlines()


def first_token_in_line_is(line, token):
    return line.split(' ')[0] == token


def create_matrix_item(param, edge_num):
    return f'L_{edge_num}last_{param}'


def create_matrix_items(param, edges_num):
    return [create_matrix_item(param, i) for i in range(1, edges_num)]


def create_matrix_code_line_building_blocks(param, edge_num):
    c = PARAM_TO_CHAR[param]
    return [
        'matrix',
        ' ',
        f'y{edge_num}{c}',
        '='
        f'api.getResultMatrix("SWMM Model/SWMM","{create_matrix_item(param, edge_num)}");',
        '\n'
    ]


def create_matrix_code_line(param, edge_num):
    return ''.join(create_matrix_code_line_building_blocks(param, edge_num))


def create_critical_code_line_for_writing_param(param, edges_num):
    elements = [f'y{edge_num}{PARAM_TO_CHAR[param]}' for edge_num in range(1, edges_num)]
    res = '         file.WriteLine('
    res += f'aConv.double2string(y1{PARAM_TO_CHAR[param]}[i,0])  + ", " +'
    for elem in elements:
        res += f'aConv.double2string({elem}[i,1])  + ", " + '
    res = res[:-11]
    res += ');'
    return res


def create_code_lines_for_writing_param(param, edges_num):
    l1 = 'using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMM' + \
         param + 'RS.txt")) {'
    l2 = '  for (int i=0; i<y1Q.mrow; i++) {'
    l3 = '         //the file has 2 columns first the coresponding time, second results from the first column in y'
    l4 = create_critical_code_line_for_writing_param(param, edges_num)
    l5 = '  }'
    l6 = '}'
    return [l1, l2, l3, l4, l5, l6]


def main():
    # First pass - iterate over original file lines.
    # Replace each block that has to be modified with a suitable note.
    # TODO(omermadmon): complete saving result text files in the corresponding scenario folder.
    line_idx_to_exclude = []
    lines = extract_lines(INPUT_PATH)
    with open(MID_PATH, "w") as f:
        for l, line in enumerate(lines):
            if line in [f'// {param.upper()} RESULTS:\n' for param in PARAMS] + ['// WATER DEPTH RESULTS:\n']:
                param = line.split(' ')[1]
                param = param if param != 'WATER' else 'DEPTH'
                f.write(line)
                f.write(f'COMPLETE MATRIX FOR PARAM: {param}\n')
            elif first_token_in_line_is(line, 'matrix') or first_token_in_line_is(line, '//matrix'):
                continue
            elif line in [f'//save {p} in a text file\n' for p in ['flow', 'velocity', 'water depth']]:
                param = line.split(' ')[1]
                param = param.capitalize() if param != 'water' else 'Depth'
                f.write(line)
                f.write(f'COMPLETE WRITING FOR PARAM: {param}\n')
                line_idx_to_exclude += list(range(l + 1, l + 14)) if param != 'Flow' \
                    else list(range(l + 1, l + 16))
            elif l in line_idx_to_exclude:
                continue
            else:
                f.write(line)

    # Second pass - iterate over mid file lines.
    # Replace all 9 notes (3 params * 3 note types) with the correct code lines.
    # TODO(omermadmon): complete saving result text files in the corresponding scenario folder.
    lines = extract_lines(MID_PATH)
    with open(OUTPUT_PATH, "w") as f:
        for line in lines:
            if line in [f'COMPLETE MATRIX FOR PARAM: {param.upper()}\n' for param in PARAMS]:
                param = line.split(' ')[-1][:-1]
                for edge_num in range(1, EDGES_NUM):
                    f.write(create_matrix_code_line(param.capitalize(), edge_num))
            elif line in [f'COMPLETE WRITING FOR PARAM: {param}\n' for param in PARAMS]:
                param = line.split(' ')[-1][:-1]
                for code_line in create_code_lines_for_writing_param(param, EDGES_NUM):
                    f.write(code_line)
                    f.write('\n')
            else:
                f.write(line)


if __name__ == '__main__':
    main()
