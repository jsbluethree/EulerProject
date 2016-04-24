// Euler Project #6 in JavaScript
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

sumofsquares = 0
squareofsums = 0
for (i = 1; i <= 100; i++){
	sumofsquares += Math.pow(i, 2)
	squareofsums += i
}
squareofsums = Math.pow(squareofsums, 2)
console.log(squareofsums - sumofsquares)