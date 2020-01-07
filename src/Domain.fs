namespace Domain

type Neighbours = int

type State = Dead | Live

//TODO: world should be 3 * 3 minimum
type World = State[,]

type Rule = State -> Neighbours -> State