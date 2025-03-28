let input = prompt("Enter the temperature: ");
let temp = parseInt(input)

if (temp > 30) console.log("It's very hot!");
else if (temp < 10 && temp < 30) console.log("The weather is pleasant");
else console.log("It's very cold!")