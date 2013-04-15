// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>] 
[1..100] 
|> Seq.map (function
    | x when x % 5 = 0 && x % 3 = 0 -> "Fizz Buzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | x -> string x)
|> Seq.iter (printfn "%s")

open System
Console.ReadKey(true)