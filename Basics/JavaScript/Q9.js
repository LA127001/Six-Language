let input = prompt("Enter the number: ")
let input2 = prompt("Enter the another number: ")
let input3 = prompt("Enter the operator: ")

let num1 = parseInt(input), num2 = parseInt(input2), operator = input3;


switch (operator) {
     case "+":
          console.log(`Addition: ${num1 + num2}`);          
          break;
     case "-":
          console.log(`Subtract: ${num1 - num2}`);          
          break;
     case "*":
          console.log(`Multiply: ${num1 * num2}`);          
          break;
     case "/":
          console.log(`Divide: ${num1 / num2}`);          
          break;

     default:
          console.log("Invalid operator");
          break;
}