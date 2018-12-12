import os
import sys

RULES_LOCATION = os.getcwd() + os.sep + "Rules"
# OUTPUT_LOCATION = os.getcwd() + os.sep + ".." + os.sep + "Outputs"
OUTPUT_LOCATION = os.getcwd() + os.sep + "Outputs"


def test_print(*args, **kwargs):
    print(*args, file=sys.stderr, **kwargs)


def get_fields(fields_file):
    with(open(fields_file)) as f:
        return [z.strip() for z in f.readlines() if z.strip() != ""]


def process(f_location, f_type):
    f_types = [x[:x.rindex(".")] for x in os.listdir(RULES_LOCATION)]
    # test_print(f_types)
    if f_type in f_types:
        from extractor import extract_text
        from nlp import get_content
        text = extract_text(f_location)
        # test_print(text)
        fields = get_fields(RULES_LOCATION + os.sep + f_type + ".txt")
        # test_print(fields)

        content = get_content(text, fields)
        return content
    else:
        raise AttributeError("No rule defined for the particular document type: " + f_type)


def write_to_csv(csv_file, content):
    test_print(csv_file, content)
    with open(csv_file, 'w+') as f:
        if isinstance(content, str):
            f.write(content)
        elif isinstance(content, dict):
            f.write('Field Names,Source(s)\n')
            for x in content:
                test_print(x, content[x])
                f.write(str(x) + ',' + str(content[x]) + '\n')


def save_to_file(file: str, content, error: bool = False):
    try:
        f_name = file[file.rindex(os.sep) + 1:file.rindex(".")]
    except ValueError:
        f_name = file[:file.rindex(".")]
    if error:
        output_loc = OUTPUT_LOCATION + os.sep + f_name + ".txt"
        test_print(output_loc)
        with(open(output_loc, 'w+')) as f:
            f.write(content + "\n")
    else:
        output_loc = OUTPUT_LOCATION + os.sep + f_name + ".csv"
        test_print(output_loc)
        write_to_csv(output_loc, content)
    return output_loc


if __name__ == '__main__':

    l = sys.argv[1:]  # f1 t1 f2 t2 f3 t3
    # test_print(l)
    files = {}
    for i in range(len(l) // 2):
        files[l[2 * i]] = l[2 * i + 1]
    # test_print(files)
    for x in files:
        file_location = x
        file_type = files[x]
        try:
            result = process(file_location, file_type)
            test_print(result)
            output_loc = save_to_file(file_location, result)
        except Exception as e:
            test_print("Exception")
            if len(e.args) > 0:
                output_loc = save_to_file(file_location, e.args[0], error=True)
            else:
                output_loc = save_to_file(file_location, "ERROR", error=True)
        print(output_loc)
