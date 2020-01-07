module World

open Domain

let getNeighbours world (r,c) : Neighbours =
    let wrap min max n =
        if n > max then min
        elif n < min then max
        else n
    
    let wrapR = (Array2D.length1 world) - 1 |> wrap 0
    let wrapC = (Array2D.length2 world) - 1 |> wrap 0

    //The indexes in the grid of (r,c)'s neighbours
    let neighboursIndecies = seq {
        for newRow in r-1..r+1 do
            for newCol in c-1..c+1 ->
                newRow, newCol
        }

    neighboursIndecies 
    // Since we're on a torus, neighbours should wrap around to the other side in both directions
    |> Seq.map (fun (r,c) -> wrapR(r), wrapC(c))
    // Exclude self
    |> Seq.except [(r,c)]
    // Neighbours just aren't the same when they're dead
    |> Seq.filter (fun (r,c) -> world.[r,c] = Live)
    |> Seq.length