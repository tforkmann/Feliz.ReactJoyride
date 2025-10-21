namespace Feliz.Reactour

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkTourProviderProp (key: string) (value: obj) : ITourProviderProp = unbox (key, value)
    let inline mkReactourProp (key: string) (value: obj) : IReactourProp = unbox (key, value)
    let inline mkLocaleProp (key: string) (value: obj) : ILocaleProp = unbox (key, value)
    let inline mkStylesProp (key: string) (value: obj) : IReactourStylesProp = unbox (key, value)
    let inline mkStyleProp (key: string) (value: obj) : IReactourStyleProp = unbox (key, value)
    let inline mkStepsProp (key: string) (value: obj) : IStepsProp = unbox (key, value)
    let inline mkStepProp (key: string) (value: obj) : IStepProp = unbox (key, value)
    let TourProvider: obj = import "TourProvider" "@reactour/tour"
    let useTour: unit -> obj = import "useTour" "@reactour/tour"
