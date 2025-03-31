let sum = (num1, num2) => num1 + num2;
let sub = (num1, num2) => num1 - num2;
let mul = (num1, num2) => num1 * num2;
let div = (num1, num2) => num1 / num2;


let input = prompt("Enter the number: ")
let input2 = prompt("Enter the another number: ")

let num1 = parseInt(input)
let num2 = parseInt(input2)

console.log(`Addition: ${sum(num1,num2)}`)
console.log(`Subtraction: ${sub(num1,num2)}`)
console.log(`Multiply: ${mul(num1,num2)}`)
console.log(`Divide: ${div(num1,num2)}`)