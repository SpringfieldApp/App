# Test script
# Outputs the multiplication tables of all the elements

import sys

file = open(sys.argv[1], 'r')
s = file.read()
file.close()

numbers = s.split(',')
tables = ''
for i in range(1, 11):
	for number in numbers:
		tables = tables + (str(int(number) * i) + ',')
	tables += '\n'
print(tables)