namespace Feliz.ReactJoyride

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkJoyrideProp (key: string) (value: obj) : IJoyrideProp = unbox (key, value)
    let inline mkStepsProp (key: string) (value: obj) : IStepsProp = unbox (key, value)
    let inline mkStepProp (key: string) (value: obj) : IStepProp = unbox (key, value)
    let joyride: obj = importDefault "react-joyride"
