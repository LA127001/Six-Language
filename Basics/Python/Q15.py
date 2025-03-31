def isPrime(nums):
     for i in range(2, int(nums ** 0.5) + 1):
          if nums % i == 0: return False
     return True

num = int(input("Enter the number: "))
if isPrime(num): print("Prime")
else :print("Not Prime")