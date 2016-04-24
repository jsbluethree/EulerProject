// Euler Project #5 in F#
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let rec gcd (a:int64) (b:int64) =
    if (b = 0L) then
        a
    else
        gcd b (a % b)

let rec lcm args =
    match args with
    | a::b::rest -> (lcm (((a * b) / (gcd a b))::rest))
    | a::[] -> a
    | [] -> 0L

printfn "%A" (lcm [1L..20L])