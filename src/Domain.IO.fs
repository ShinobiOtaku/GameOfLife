namespace Domain.IO

open Domain

type ReadWorld = unit -> World
type WriteWorld = World -> unit
