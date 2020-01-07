///https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life#Rules
module Rules

open Domain

let all state neighbours =
    match (state, neighbours) with
    // Any live cell with two or three neighbors survives.
    | Live, 2 
    | Live, 3 -> state
    // Any dead cell with three live neighbors becomes a live cell.
    | Dead, 3 -> Live
    // All other live cells die in the next generation. Similarly, all other dead cells stay dead.
    | _ -> Dead