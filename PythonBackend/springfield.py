import os
RULES_LOCATION = os.getcwd() + os.sep + "Rules"
# OUTPUT_LOCATION = os.getcwd() + os.sep + ".." + os.sep + "Outputs"
OUTPUT_LOCATION = os.getcwd() + os.sep + "Outputs"


def process(f_location, f_type) -> str:
    raise NotImplementedError()
    return 'nothing'


def save_to_file(file: str, data) -> str:
    try:
        f_name = file[file.rindex(os.sep) + 1:file.rindex(".")]
    except ValueError:
        f_name = file
    if data == "ERROR":
        output_loc = OUTPUT_LOCATION + os.sep + f_name + ".txt"
        with(open(output_loc), 'w+') as f:
            f.write("ERROR\n")
    else:
        output_loc = OUTPUT_LOCATION + os.sep + f_name + ".csv"
        # TODO
    return output_loc


if __name__ == '__main__':
    import sys

    l = sys.argv[1:]  # f1 t1 f2 t2 f3 t3
    # print(l)
    files = {}
    for i in range(len(l) // 2):
        files[l[2*i]] = l[2*i + 1]
    # print(files)
    for x in files:
        file_location = x
        file_type = files[x]
        try:
            result = process(file_location, file_type)
            output_loc = save_to_file(file_location, result)
        except Exception:
            output_loc = save_to_file(file_location, "ERROR")
        print(output_loc)
