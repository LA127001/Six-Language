num1 = int(input("Enter the number: "))
num2 = int(input("Enter the another number: "))
operators = input("Enter the operator: ")

match operators:
     case "+": print("Addition: ",num1 + num2)
     case "-": print("Subtraction: ",num1 - num2)
     case "*": print("Multiply: ",num1 * num2)
     case "/": print("Divide: ",num1 / num2)
     case _: print("Invalid")