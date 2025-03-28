let input = prompt("Enter the number: ")
let num = parseInt(input)
let zero = 0, one = 1, next;

for(let i = 2; i <= num; i++){
     next = zero + one;
     console.log(`${next} `)
     one = zero
     zero = next;
}