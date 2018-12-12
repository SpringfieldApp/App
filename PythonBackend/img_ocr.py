def get_text(pdf_location, res=300, page=None):
    # import os
    import io
    from PIL import Image
    import pytesseract
    from wand.image import Image as wi
    # from clean import _clean
    pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files (x86)\Tesseract-OCR\tesseract'

    # DIR = pdf_location[0:pdf_location.rindex("\\")]
    try:
        FILE = pdf_location[pdf_location.rindex("\\") + 1:]
    except ValueError:
        FILE = pdf_location
    # os.chdir(DIR)

    if page is None:
        pdf = wi(filename=FILE, resolution=res)
    else:
        pdf = wi(filename=FILE + "[" + str(page) + "]", resolution=res)
    pdfImg = pdf.convert('jpeg')
    extracted_text = []
    for img in pdfImg.sequence:
        page = wi(image=img)
        imgBlob = page.make_blob('jpeg')
        im = Image.open(io.BytesIO(imgBlob))
        text = pytesseract.image_to_string(im, lang='eng')
        # extracted_text.append(_clean(text))
        extracted_text.append(text)
    return extracted_text


def generate_text(pdf_location, res=300):
    # import os
    import io
    from PIL import Image
    import pytesseract
    from wand.image import Image as wi
    # from clean import _clean
    pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files (x86)\Tesseract-OCR\tesseract'

    # DIR = pdf_location[0:pdf_location.rindex("\\")]
    try:
        FILE = pdf_location[pdf_location.rindex("\\") + 1:]
    except ValueError:
        FILE = pdf_location
    # os.chdir(DIR)

    pdf = wi(filename=FILE, resolution=res)
    pdfImg = pdf.convert('jpeg')
    for img in pdfImg.sequence:
        page = wi(image=img)
        imgBlob = page.make_blob('jpeg')
        im = Image.open(io.BytesIO(imgBlob))
        text = pytesseract.image_to_string(im, lang='eng')
        # yield _clean(text)
        yield text


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
    text = pytesseract.image_to_string(im, lang='eng')
    return text


if __name__ == '__main__':
    # import time
    # a = time.time()
    # for i in range(100, 400, 10):
    #     for page in generate_text(r"E:\projects_workspaces\competitions\springfield\App\PythonBackend\Sample.pdf[1]"):
    #     page = get_text(r"E:\projects_workspaces\competitions\springfield\App\PythonBackend\Sample.pdf[1]", res=120)
    #     print("-----------------------------------NEW PAGE-----------------------------------")
    #     print("Resolution = " + str(i))
    #     print(page[0])
    #     print(i, time.time() - a)
    #     print("\n\n\n\n")
    #     a = time.time()
    page = get_text(r"Sample.pdf", res=110, page=1)
    print(page[0])
    # print(extract_from_img("C:\\Users\\aliab\\Pictures\\Capture.png"))
