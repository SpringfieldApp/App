import sys


def test_print(*args, **kwargs):
    print(*args, file=sys.stderr, **kwargs)


def pdf_parser(pdf_location, res=120, page=None):
    import io
    from PIL import Image
    import pytesseract
    from wand.image import Image as wi
    pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files (x86)\Tesseract-OCR\tesseract'
    try:
        FILE = pdf_location[pdf_location.rindex("\\") + 1:]
    except ValueError:
        FILE = pdf_location
    if page is None:
        pdf = wi(filename=FILE, resolution=res)
    else:
        pdf = wi(filename=FILE + "[" + str(page) + "]", resolution=res)
    pdfImg = pdf.convert('jpeg')
    extracted_text = []
    for i in range(len(pdfImg.sequence)):
        test_print("Currently Processing Page " + str(i))
        page = wi(image=pdfImg.sequence[i])
        imgBlob = page.make_blob('jpeg')
        im = Image.open(io.BytesIO(imgBlob))
        text = pytesseract.image_to_string(im, lang='eng', config='--psm 6')
        extracted_text.append(text)
    return extracted_text


def extract_from_img(img_location):
    # import os
    from PIL import Image
    import pytesseract
    # from clean import _clean
    pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files (x86)\Tesseract-OCR\tesseract'

    # DIR = img_location[0:img_location.rindex("\\")]
    try:
        FILE = img_location[img_location.rindex("\\") + 1:]
    except ValueError:
        FILE = img_location
    # os.chdir(DIR)
    im = Image.open(FILE)
    text = pytesseract.image_to_string(im, lang='eng', config='--psm 6')
    return text


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
