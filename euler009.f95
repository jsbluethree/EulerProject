! Euler Project #9 in Fortran 95
! There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.

program euler009
implicit none
integer :: a, b, c
aloop: do a = 1, 1000
	bloop: do b = a+1, 1000-a
		c = 1000 - (a + b)
		if (b >= c) then
			exit bloop
		end if
		if (a ** 2 + b ** 2 == c ** 2) then
			print *, a * b * c
			exit aloop
		end if
	end do bloop
end do aloop
end program euler009