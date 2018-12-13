import sys
with (open(r'D:\Yash\SpringfieldApp\RefactoredApp\SpringField\output\op.txt', 'w+')) as f:
    for i in range(len(sys.argv)):
        f.write(sys.argv[i] + '\n')
