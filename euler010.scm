; Euler Project #10 in Scheme
; Find the sum of all the primes below two million.

#lang scheme

(require srfi/1)

(define sieve
  (lambda (divisor in out final)
    (if (null? in)
        (let ((next (reverse out)))
          (if (null? next)
              (cons divisor final)
              (sieve (car next) next '() (cons divisor final))))
        (if (zero? (modulo (car in) divisor))
            (sieve divisor (cdr in) out final)
            (sieve divisor (cdr in) (cons (car in) out) final)))))

(foldl + 0 (sieve 2 (iota 1999999 2) '() '()))
