namespace Feliz.Reactour

open Fable.Core.JsInterop
open Fable.Core
open Feliz

[<Erase>]
type reactour =
    static member inline steps (props: IStepsProp seq) = !!("steps" ==> props)
    static member inline children(children: ReactElement list) =
        unbox<IReactourProp> (prop.children children)
    static member inline useTour (useTour: obj) = Interop.mkReactourProp "useTour" useTour
    static member inline scrollDuration (scrollDuration: int) = Interop.mkReactourProp "scrollDuration" scrollDuration
    static member inline disableScrolling (disableScrolling: bool) = Interop.mkReactourProp "disableScrolling" disableScrolling
    static member inline scrollOffset (scrollOffset: int) = Interop.mkReactourProp "scrollOffset" scrollOffset
    static member inline continuous (continuous: bool) = Interop.mkReactourProp "continuous" continuous
    static member inline showSkipButton (showSkipButton: bool) = Interop.mkReactourProp "showSkipButton" showSkipButton
    static member inline showProgress (showProgress: bool) = Interop.mkReactourProp "showProgress" showProgress
    static member inline scrollToFirstStep (scrollToFirstStep: bool) = Interop.mkReactourProp "scrollToFirstStep" scrollToFirstStep
    static member inline hideBackButton (hideBackButton: bool) = Interop.mkReactourProp "hideBackButton" hideBackButton
    static member inline hideCloseButton (hideCloseButton : bool) = Interop.mkReactourProp "hideCloseButton" hideCloseButton
    static member inline locale (props: ILocaleProp seq) = Interop.mkReactourProp "locale" (createObj !!props)
    static member inline styles (props: IReactourStylesProp seq) = Interop.mkReactourProp "styles" (createObj !!props)
    static member inline callback (callback: ICallbackProp -> unit) : IReactourProp =
        !!("callback" ==> callback)

[<Erase>]
type reactourStyles =
    static member inline options (options: IReactourStyleProp seq) = Interop.mkStylesProp "options" (createObj !!options)

[<Erase>]
type reactourStyle =
    static member inline arrowColor (color: string) = Interop.mkStyleProp "arrowColor" color
    static member inline backgroundColor (color: string) = Interop.mkStyleProp "backgroundColor" color
    static member inline overlayColor (color: string) = Interop.mkStyleProp "overlayColor" color
    static member inline primaryColor (color: string) = Interop.mkStyleProp "primaryColor" color
    static member inline textColor (color: string) = Interop.mkStyleProp "textColor" color
    static member inline width (width: int) = Interop.mkStyleProp "width" width
    static member inline zIndex (zIndex: int) = Interop.mkStyleProp "zIndex" zIndex

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
    static member inline selector (target: string) : IStepProp = Interop.mkStepProp "selector" target
    static member inline content (content: string) : IStepProp = Interop.mkStepProp "content" content
    static member inline disableBeacon (disableBeacon: bool) : IStepProp = Interop.mkStepProp "disableBeacon" disableBeacon
    static member inline hideFooter (hideFooter: bool) : IStepProp = Interop.mkStepProp "hideFooter" hideFooter
    static member inline isFixed (isFixed: bool) : IStepProp = Interop.mkStepProp "isFixed" isFixed
    static member inline placement (placement: string) : IStepProp = Interop.mkStepProp "placement" placement
    static member inline placementBeacon (placementBeacon: string) : IStepProp = Interop.mkStepProp "placementBeacon" placementBeacon
    static member inline title obj = Interop.mkStepProp "title" obj
    static member inline content obj = Interop.mkStepProp "content" obj
    static member inline offset (offset: int) : IStepProp = Interop.mkStepProp "offset" offset
