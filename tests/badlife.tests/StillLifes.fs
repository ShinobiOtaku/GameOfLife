/// some of the examples from wikipedia: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life#Examples_of_patterns
module StillLifes

open Expecto
open Domain

let runTest input =
    let inAndOut = (array2D input)
    let result = GameOfLife.evolve Rules.all inAndOut
    Expect.equal result inAndOut "Still Lifes should not change"

let tests = 
    testList "Worlds that should stay the same" [

        test "Block" {
            runTest
                [|
                    [| Dead; Dead; Dead; Dead |];
                    [| Dead; Live; Live; Dead |];
                    [| Dead; Live; Live; Dead |];
                    [| Dead; Dead; Dead; Dead |];
                |]
        }

        test "Beehive" {
            runTest
                [|
                    [| Dead; Dead; Dead; Dead; Dead; Dead |];
                    [| Dead; Dead; Live; Live; Dead; Dead |];
                    [| Dead; Live; Dead; Dead; Live; Dead |];
                    [| Dead; Dead; Live; Live; Dead; Dead |];
                    [| Dead; Dead; Dead; Dead; Dead; Dead |];
                |]
        }

        test "Tub" {
            runTest
                [|
                    [| Dead; Dead; Dead; Dead; Dead; |];
                    [| Dead; Dead; Live; Dead; Dead; |];
                    [| Dead; Live; Dead; Live; Dead; |];
                    [| Dead; Dead; Live; Dead; Dead; |];
                    [| Dead; Dead; Dead; Dead; Dead; |];
                |]
        }
    ]

