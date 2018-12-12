import csv
with open('a.csv', 'w+') as f:
    fieldnames = ['Field Names', 'Source(s)']
    writer = csv.writer(f)
    writer.writerow(fieldnames)
    content = {'a':'aa', 'b':'bb'}
    writer.writerow(['a', 2])
    writer.writerow(['b', 3])
