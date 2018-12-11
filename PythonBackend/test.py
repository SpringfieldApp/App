from get_text import *

format_to_text = {
    'csv': csv_parser,
    'tsv': tsv_parser,
    'psv': psv_parser,
    'docx': docx_parser,
    'doc': doc_parser,  # warning
    'json': json_parser,
    'txt': txt_parser,
    '': txt_parser,
    'log': txt_parser,
    'xls': xlsx_parser,
    'xlsx': xlsx_parser,
    'pdf': pdf_parser
}


def get_text(filename: str, extension=None):
    if extension is None:
        extension = filename[filename.rindex('.') + 1:]
    if extension in format_to_text:
        parser = format_to_text[extension]
        return parser(filename)
    else:
        return "ERROR"


def no_of_faces(img_path):
    import cv2
    # https://docs.opencv.org/3.1.0/d7/d8b/tutorial_py_face_detection.html
    opencv_path = 'C:\\Users\\aliab\\AppData\\Local\\Programs\\Python\\Python37-32\\Lib\\site-packages\\cv2\\'
    face_cascade = cv2.CascadeClassifier(opencv_path + 'data\\haarcascade_frontalface_default.xml')
    img = cv2.imread(img_path)
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray)  # (gray, 1.3, 5)
    return len(faces)


if __name__ == '__main__':
    pic = 'samples/pic.jpg'
    print("The file", pic, "has ", no_of_faces(pic), "faces")
    files = ['samples/samplePDF.pdf', 'samples/SampleDocx.docx', 'samples/SampleJSON.json', 'samples/CSVSample.csv',
             'samples/sampleText.txt', 'samples/XLSXSample.xlsx']
    for file in files:
        with open('SampleOutputs/'+file[file.index('/')+1:file.rindex('.')]+'.txt', 'w+') as f:
            f.write(get_text(file).strip())
