namespace Feliz.ReactJoyride

open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type joyride =
    static member inline steps (props: IStepsProp seq) = (!!("steps" ==> props))
    static member inline run (run: bool) = Interop.mkJoyrideProp "run" run
    static member inline continuous (continuous: bool) = Interop.mkJoyrideProp "continuous" continuous
    static member inline locale (props: ILocaleProp seq) = (!!("locale" ==> props))

[<Erase>]
type locale =
    static member inline back (back: string) = Interop.mkLocaleProp "back" back
    static member inline close (close: string) = Interop.mkLocaleProp "close" close
    static member inline last (last: string) = Interop.mkLocaleProp "last" last
    static member inline next (next: string) = Interop.mkLocaleProp "next" next
    static member inline skip (skip: string) = Interop.mkLocaleProp "skip" skip

[<Erase>]
type steps =
    static member inline step (props: IStepProp seq) = !!(createObj !!props)

[<Erase>]
type step =
    static member inline target (target: string) : IStepProp = Interop.mkStepProp "target" target
    static member inline content (content: string) : IStepProp = Interop.mkStepProp "content" content
