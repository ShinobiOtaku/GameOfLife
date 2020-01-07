module Underpopulation

open Expecto
open Domain

let runTest input expectedOutput =
    let result = GameOfLife.evolve Rules.all (array2D input) 
    Expect.equal result (array2D expectedOutput) "The evolved states should equal"

let tests = 
    testList "Any live cell with fewer than two live neighbours dies, as if by underpopulation" [
            
        test "No neighbours" {
            runTest
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
        }

        test "Single neighbour on same row" {
            runTest
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Live; |];
                    [| Dead; Dead; Dead; |];
                |]
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
        }

        test "Single neighbour on same column" {
            runTest
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Live; |];
                    [| Dead; Dead; Dead; |];
                |]
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
        }
    ]