module World

open Expecto
open Domain

let runTest world input expectedOutput =
    let result = World.getNeighbours (array2D world) input
    Expect.equal result expectedOutput "Neighbours counted incorrectly"

let tests = 
    testList "World functions" [
            
        test "getNeighbours no neighbours" {
            let world = 
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Dead; |];
                    [| Dead; Dead; Dead; |];
                |]
            runTest world (1,1) 0
        }

        test "getNeighbours 1 neighbour" {
            let world = 
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Live; |];
                    [| Dead; Dead; Dead; |];
                |]
            runTest world (1,1) 1
        }

        test "getNeighbours 2 neighbours" {
            let world = 
                [|
                    [| Dead; Dead; Dead; |];
                    [| Dead; Live; Live; |];
                    [| Dead; Live; Dead; |];
                |]
            runTest world (1,1) 2
        }

        test "getNeighbours 8 neighbours" {
            let world = 
                [|
                    [| Live; Live; Live; |];
                    [| Live; Dead; Live; |];
                    [| Live; Live; Live; |];
                |]
            runTest world (1,1) 8
        }

        test "getNeighbours wraps around bottom and right" {
            let world = 
                [|
                    [| Dead; Live; Live; |];
                    [| Live; Live; Live; |];
                    [| Live; Live; Live; |];
                |]
            runTest world (0,0) 8
        }

        test "getNeighbours wraps around top and left" {
            let world = 
                [|
                    [| Live; Live; Live; |];
                    [| Live; Live; Live; |];
                    [| Live; Live; Dead; |];
                |]
            runTest world (2,2) 8
        }
    ]