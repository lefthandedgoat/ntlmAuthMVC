open canopy
open runner
open MikeRogers.NtlmProxy
open System

let proxy = new NtlmProxy(Uri("http://localhost:7990"), 3999, "chris\\testuser", "1234")
   

"go to main page" &&& fun _ ->    
    url "http://localhost:3999"
    click "About"
    click "Contact"
    click "Home"

"do more" &&& fun _ ->
    click "About"
    click "Contact"
    click "Home"

"do more" &&& fun _ ->
    click "About"
    click "Contact"
    click "Home"

"do more" &&& fun _ ->
    click "About"
    click "Contact"
    click "Home"

"do more" &&& fun _ ->
    click "About"
    click "Contact"
    click "Home"
    
start chrome

run ()


System.Console.ReadKey()

proxy.Dispose()
quit()

System.Console.ReadKey()