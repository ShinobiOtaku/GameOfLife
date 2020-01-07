module Overpopulation

open Expecto
open Domain

let runTest input expectedOutput =
    let result = GameOfLife.evolve Rules.all (array2D input) 
    Expect.equal result (array2D expectedOutput) "The evolved states should equal"

let tests = 
    testList "Any live cell with more than three live neighbours dies, as if by overpopulation" [
            
        test "More than 3 neighbours" {
            runTest
                [|
                    [| Live; Live; Live; |];
                    [| Live; Live; Live; |];
                    [| Live; Live; Live; |];
                |]
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
        }
    ]

