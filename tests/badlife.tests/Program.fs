open Expecto

[<Tests>]
let tests =
  testList "allTests" [
    World.tests
    Underpopulation.tests
    Overpopulation.tests
    SampleInput.tests
    StillLifes.tests
    Oscillators.tests
  ]

[<EntryPoint>]
let main args =
  runTestsInAssemblyWithCLIArgs [] args