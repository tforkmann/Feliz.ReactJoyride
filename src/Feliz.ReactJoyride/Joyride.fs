namespace Feliz.ReactJoyride

open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type joyride =
    static member inline steps (props: IStepsProp seq) = Interop.mkJoyrideProp "steps" (createObj !!props)

[<Erase>]
type steps =
    static member inline step (props: IStepProp seq) = Interop.mkStepsProp "step" (createObj !!props)

[<Erase>]
type step =
    static member inline target (target: string) : IStepProp = Interop.mkStepProp "target" target
    static member inline content (content: string) : IStepProp = Interop.mkStepProp "content" content
