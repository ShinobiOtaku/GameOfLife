/// Test the sample input provided
module SampleInput

open Expecto
open Domain

let runTest input expectedOutput =
    let result = GameOfLife.evolve Rules.all (array2D input) 
    Expect.equal result (array2D expectedOutput) "The evolved states should equal"

let tests =
    test "Sample input matches expected output" {
        runTest
            [|
                [| Dead; Dead; Dead; Dead; Dead |];
                [| Dead; Dead; Live; Dead; Dead |];
                [| Dead; Live; Live; Live; Dead |];
                [| Dead; Dead; Live; Dead; Dead |];
                [| Dead; Dead; Dead; Dead; Dead |]
            |]
            [|
                [| Dead; Dead; Dead; Dead; Dead |];
                [| Dead; Live; Live; Live; Dead |];
                [| Dead; Live; Dead; Live; Dead |];
                [| Dead; Live; Live; Live; Dead |];
                [| Dead; Dead; Dead; Dead; Dead |]
            |]
    }
