namespace Feliz.Reactour

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IReactourProp.
[<Erase>]
type Reactour =
    /// Creates a new Reactour component.

    static member inline reactour(props: IJoyrideProp seq) =
        Interop.reactApi.createElement (Interop.reactour, createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IReactourProp> (prop.children children)
