open FSharpKoans
open FSharpKoans.Core
open System

let runner = KoanRunner()
let result = runner.ExecuteKoans()

match result with
| Success message -> printf "%s" message
| Failure (message, ex) ->
    printf "%s" message
    printfn ""
    printfn ""
    printfn ""
    printfn ""
    Console.ForegroundColor <- ConsoleColor.Cyan
    printfn "You have not yet reached enlightenment ..."
    Console.ForegroundColor <- ConsoleColor.Red
    printfn "%s" ex.Message
    printfn ""
    Console.ForegroundColor <- ConsoleColor.Cyan
    printfn "Please meditate on the following code:"
    Console.ForegroundColor <- ConsoleColor.Red
    printfn "%s" ex.StackTrace

printfn ""
printfn ""
printfn ""
printfn ""
Console.ForegroundColor <- ConsoleColor.Yellow
printf "Press any key to continue..."
Console.ResetColor |> ignore
System.Console.ReadKey() |> ignore
