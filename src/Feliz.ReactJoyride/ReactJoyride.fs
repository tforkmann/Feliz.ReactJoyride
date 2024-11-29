namespace Feliz.ReactJoyride

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IReactJoyrideProp.
[<Erase>]
type Joyride =
    /// Creates a new ReactJoyride component.

    static member inline joyride(props: IJoyrideProp seq) =
        Interop.reactApi.createElement (Interop.joyride, createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IJoyrideProp> (prop.children children)
