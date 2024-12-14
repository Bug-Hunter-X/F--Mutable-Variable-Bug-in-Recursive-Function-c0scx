let rec loop x y =
    if x < 10 then
        loop (x + 1) (y + x + 1)
    else
        y

printf "%i" (loop 0 0)