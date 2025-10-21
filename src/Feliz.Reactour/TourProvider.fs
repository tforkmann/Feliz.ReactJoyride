namespace Feliz.Reactour

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an ITourProviderProp.
[<Erase>]
type TourProvider =
    /// Creates a new TourProvider component.

    static member inline tourProvider(props: IReactourProp seq) =
        Interop.reactApi.createElement (Interop.TourProvider, createObj !!props)

    static member inline useTour() = Interop.TourProvider

    static member inline children(children: ReactElement list) =
        unbox<ITourProviderProp> (prop.children children)

type TourControls = {
    isOpen: bool
    setIsOpen: bool -> unit
    currentStep: int
    setCurrentStep: int -> unit
    nextStep: unit -> unit
    prevStep: unit -> unit
}
with
    // Optional helpers for Feliz-like syntax
    member this.onClickOpen() = prop.onClick (fun _ -> this.setIsOpen true)
    member this.onClickClose() = prop.onClick (fun _ -> this.setIsOpen false)

    static member inline useTour() : TourControls =
        let raw = Interop.useTour()
        {
            isOpen = raw?isOpen
            setIsOpen = raw?setIsOpen
            currentStep = raw?currentStep
            setCurrentStep = raw?setCurrentStep
            nextStep = raw?nextStep
            prevStep = raw?prevStep
        }
