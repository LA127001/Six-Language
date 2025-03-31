"""
?Create a print 
arr = [10,20,30,40,50]
print(arr)
"""

"""
?Input of Arrays

# other way
#  n = int(input("Enter size of array: ")) # Read size
# arr = list(map(int, input("Enter elements: ").split())) # Read multiple inputs

# print("Array elements:", arr)
"""

n = int(input("Enter size of array: "))
arr = []

for _ in range(n):
     arr.append(int(input("Enter the numbers: ")))

print(arr)
print(len(arr))

