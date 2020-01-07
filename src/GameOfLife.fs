module GameOfLife

open Domain

let evolve (gameRules : Rule) (world : World): World =
    let aWholeNewWorllddd = 
        world |> Array2D.mapi(fun r c cell ->
            // for each cell, find its neighbours and apply the game rules function
            let neighbours = World.getNeighbours world (r,c)
            gameRules cell neighbours)

    aWholeNewWorllddd