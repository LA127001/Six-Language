let isPrime = (nums) => {
     for (let i = 2; i * i <= nums; i++) {
          if (nums % i == 0) return false;
     }
     return true;
};


let input = prompt("Enter the number: ")
let num = parseInt(input)

if (isPrime(num)) {
     console.log("Prime")
} else {
     console.log("Not Prime")
}
