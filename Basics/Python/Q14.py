def sum(num1, num2): return num1 + num2;
def sub(num1, num2): return num1 - num2;
def mul(num1, num2): return num1 * num2;
def div(num1, num2): return num1 / num2;

num1 = int(input("Enter the number: "))
num2 = int(input("Enter the another number: "))

print("Addition: ", sum(num1,num2))
print("Subtraction: ", sub(num1,num2))
print("Multiply: ", mul(num1,num2))
print("Divide: ", div(num1,num2))