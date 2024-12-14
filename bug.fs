let mutable x = 0
let mutable y = 0

let rec loop x y =
    if x < 10 then
        (
            x <- x + 1; 
            y <- y + x; 
            loop x y
        ) 
    else
        y

printf "%i" (loop 0 0)