num = int(input("Enter the number: "))
zeros = 0
ones = 1
next = 0

for i in range(2,num + 1):
     next = zeros + ones
     print(next)
     ones = zeros
     zeros = next