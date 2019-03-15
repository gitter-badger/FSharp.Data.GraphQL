namespace FSharp.Data.GraphQL

open System

[<AutoOpen>]
module internal Extensions =
    type String with
        member this.FirstCharUpper() = 
            this.Substring(0, 1).ToUpperInvariant() + this.Substring(1)

        member this.FirstCharLower() =
            this.Substring(0, 1).ToLowerInvariant() + this.Substring(1)