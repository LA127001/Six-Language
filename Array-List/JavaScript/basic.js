/*
?Create a print 
let arr = [10,20,30,40,50];
console.log(arr);
*/

/*
?Input in arrays
*/
let n = parseInt(prompt("Enter the size of arrays: "));
let arr = [];


for(let i = 0; i < n; i++){
    arr.push(parseInt(prompt(`Enter the numbers: ${i+1}`)));
}

console.log(arr);
console.log(arr.length)