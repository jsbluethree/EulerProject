# Euler Project #7 in Julia
# What is the 10,001st prime number?

primes = [2, 3]

while (length(primes) < 10001)
	test = primes[end] + 2
	while (any(i->(test%i==0), primes))
		test = test + 2
	end
	push!(primes, test)
end

print(primes[end])