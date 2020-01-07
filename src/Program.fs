// Implements Conway's Game Of Life
// https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life on a torus
open System

[<EntryPoint>]
let main argv =
    
    let ``Answer to the Ultimate Question of Life, the Universe, and Everything`` = 42

    IO.readFile "sample_input.txt"
    |> GameOfLife.evolve Rules.all
    |> IO.writeToConsole
        
    ``Answer to the Ultimate Question of Life, the Universe, and Everything``