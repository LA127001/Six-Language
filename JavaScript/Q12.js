let input = prompt("Enter the number: ")
let num = parseInt(input)
let factorial = 1;

for(let i = 1; i <= num; i++){
     factorial *= i;
}
console.log(factorial);