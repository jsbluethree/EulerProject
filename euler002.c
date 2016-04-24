// Euler Project #2 in C
// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

#include <stdio.h>

int main(){
	int sum = 0;
	int prev1 = 1;
	int prev2 = 1;
	int current;
	while(1){
		current = prev1 + prev2;
		if (current >= 4000000)
			break;
		if (current % 2 == 0)
			sum += current;
		prev1 = prev2;
		prev2 = current;
	}
	printf("%d", sum);
}