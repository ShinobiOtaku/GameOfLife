/// some of the examples from wikipedia: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life#Examples_of_patterns
module Oscillators

open Expecto
open Domain

let runTest evolutions input =
    let rec run n input =
        let newWorld = GameOfLife.evolve Rules.all input
        if n = 1 then
            newWorld
        else
            run (n-1) newWorld

    let inAndOut = (array2D input)
    let result = run evolutions inAndOut
    Expect.equal result inAndOut "Oscillators should return to their original state after n evolutions"

let tests = 
    testList "Oscillating worlds" [

        test "Blinker" {
            runTest 2
                [|
                    [| Dead; Dead; Dead; Dead; Dead; |];
                    [| Dead; Dead; Live; Dead; Dead; |];
                    [| Dead; Dead; Live; Dead; Dead; |];
                    [| Dead; Dead; Live; Dead; Dead; |];
                    [| Dead; Dead; Dead; Dead; Dead; |];
                |]
        }
    ]

