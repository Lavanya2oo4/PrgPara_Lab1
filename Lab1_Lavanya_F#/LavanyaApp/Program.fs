// For more information see https://aka.ms/fsharp-console-apps
// F# code from Lavanya

// TAIL RECURSION 1

let list = [10; 20; 30; 40; 50; 60; 70; 80; 90; 100]

let rec multiplyList lst =
    match lst with
    | [] -> 1
    | head::tail -> head * multiplyList tail

let result1 = multiplyList list
printfn "%d" result1


// TAIL RECURSION 2

let rec getOddProduct num =
      if num<=1 then
       num
      else if num % 2=0 then
       getOddProduct (num - 2)
            
      else
         num* getOddProduct (num-2) 

let result2= getOddProduct 3
printfn "%d" result2


// TAIL RECURSION 3

let list3=[" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let funCTrim=List.map (fun (name:string) ->name.Trim()) list3

printfn "%A" funCTrim


// TAIL RECURSION 4

let sequence= seq {1 .. 700}


let seqToList=Seq.toList sequence
printfn "This is Sequence to List %A" seqToList

let filterMultiples= seqToList |> List.filter (fun f -> f % 7=0 || f % 5=0)
printfn "This is filtered list %A " filterMultiples

let filteredSum=List.reduce (+) filterMultiples
printfn "This is filtered sum %d" filteredSum 



// TAIL RECURSION 5
let namesList=["James";"Robert";"John";"William";"Michael";"David";"Richard"]
let filterName= namesList |>List.filter (fun name->name.Contains("i") || name.Contains("I"))
printfn "%A" filterName

let joinedNames=filterName |> List.reduce(fun result name-> result+name)
printfn "%s" joinedNames

