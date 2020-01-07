module IO

open System
open System.IO

open Domain

let readFile (path:string) : World =
    use input = new StreamReader(path)
    let all_text = input.ReadToEnd()
    let lines = all_text.Split([|Environment.NewLine|], StringSplitOptions.None)

    let generatorFunction r c =
        match lines.[r].[c] with
        | '_' -> Dead
        | '*' -> Live
        | _ -> failwith "Invalid char"

    Array2D.init lines.Length lines.[0].Length generatorFunction

let writeToConsole (world: World) =
    for r = 0 to Array2D.length1 world - 1 do
        world.[r, *] 
        |> Array.map(function Live -> '*' | Dead -> ' ')
        |> fun s -> printfn "%s" (String s)