# support
def get_text_from_json(deserialized_json):
    if isinstance(deserialized_json, dict):
        result = ''
        for key in sorted(deserialized_json):
            result += get_text_from_json(deserialized_json[key]) + ' '
        return result
    if isinstance(deserialized_json, list):
        result = ''
        for item in deserialized_json:
            result += get_text_from_json(item) + ' '
        return result
    if isinstance(deserialized_json, str):
        return deserialized_json
    else:
        return ''


def run(args):
    import subprocess
    import errno
    """Run ``command`` and return the subsequent ``stdout`` and ``stderr``
    as a tuple. If the command is not successful, this raises a
    :exc:`textract.exceptions.ShellError`.
    """
    # run a subprocess and put the stdout and stderr on the pipe object
    try:
        pipe = subprocess.Popen(
            args,
            stdout=subprocess.PIPE, stderr=subprocess.PIPE,
        )
    except OSError as e:
        if e.errno == errno.ENOENT:
            # File not found.
            # This is equivalent to getting exitcode 127 from sh
            raise Exception(
                ' '.join(args), 127, '', '',
            )
    # pipe.wait() ends up hanging on large files. using
    # pipe.communicate appears to avoid this issue
    stdout, stderr = pipe.communicate()
    # if pipe is busted, raise an error (unlike Fabric)
    if pipe.returncode != 0:
        raise Exception(
            ' '.join(args), pipe.returncode, stdout, stderr,
        )
    return stdout, stderr


# csv, psv, tsv
def csv_parser(filename):
    import csv
    with open(filename) as stream:
        reader = csv.reader(stream, delimiter=',')
        return '\n'.join(['\t'.join(row) for row in reader])


def psv_parser(filename):
    import csv
    with open(filename) as stream:
        reader = csv.reader(stream, delimiter='|')
        return '\n'.join(['\t'.join(row) for row in reader])


def tsv_parser(filename):
    import csv
    with open(filename) as stream:
        reader = csv.reader(stream, delimiter='\t')
        return '\n'.join(['\t'.join(row) for row in reader])


# docx
def docx_parser(filename):
    import docx2txt
    return docx2txt.process(filename)


# json
def json_parser(filename):
    import json
    with open(filename, 'r') as raw:
        deserialized_json = json.load(raw)
    return get_text_from_json(deserialized_json)


# txt
def txt_parser(filename):
    with open(filename) as stream:
        return stream.read()


# xls, xlsx
def xlsx_parser(filename):
    import xlrd
    workbook = xlrd.open_workbook(filename)
    sheets_name = workbook.sheet_names()
    output = "\n"
    for names in sheets_name:
        worksheet = workbook.sheet_by_name(names)
        num_rows = worksheet.nrows
        num_cells = worksheet.ncols
        for curr_row in range(num_rows):
            row = worksheet.row(curr_row)
            new_output = []
            for index_col in range(num_cells):
                value = worksheet.cell_value(curr_row, index_col)
                if value:
                    if isinstance(value, (int, float)):
                        value = str(value)
                    new_output.append(value)
            if new_output:
                output += u' '.join(new_output) + u'\n'
    return output


# pdf
def pdf_parser(filename, method='pypdf2'):
    if method == 'pypdf2':
        import PyPDF2
        pdfFileObj = open(filename, 'rb')
        pdfReader = PyPDF2.PdfFileReader(pdfFileObj)
        # print("The PDF file has", pdfReader.numPages, "pages")
        text = ''
        for i in range(pdfReader.numPages):
            pageObj = pdfReader.getPage(i)
            text += '\n' + pageObj.extractText()
        pdfFileObj.close()
        return text
    elif method == 'tesseract':
        import os
        from tempfile import mkdtemp
        import shutil
        temp_dir = mkdtemp()
        base = os.path.join(temp_dir, 'conv')
        contents = []
        try:
            stdout, _ = run(['pdftoppm', filename, base])
            for page in sorted(os.listdir(temp_dir)):
                page_path = os.path.join(temp_dir, page)
                stdout, _ = run(['tesseract', page_path, 'stdout'])
                page_content = stdout
                contents.append(page_content)
            return b''.join(contents)
        finally:
            shutil.rmtree(temp_dir)


# doc
def doc_parser(filename):
    stdout, stderr = run(['antiword', filename])
    return stdout
