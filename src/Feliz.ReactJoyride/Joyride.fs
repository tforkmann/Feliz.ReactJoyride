namespace Feliz.ReactJoyride

open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type joyride =
    static member inline steps (props: IStepsProp seq) = !!("steps" ==> props)
    static member inline run (run: bool) = Interop.mkJoyrideProp "run" run
    static member inline scrollDuration (scrollDuration: int) = Interop.mkJoyrideProp "scrollDuration" scrollDuration
    static member inline disableScrolling (disableScrolling: bool) = Interop.mkJoyrideProp "disableScrolling" disableScrolling
    static member inline scrollOffset (scrollOffset: int) = Interop.mkJoyrideProp "scrollOffset" scrollOffset
    static member inline continuous (continuous: bool) = Interop.mkJoyrideProp "continuous" continuous
    static member inline showSkipButton (showSkipButton: bool) = Interop.mkJoyrideProp "showSkipButton" showSkipButton
    static member inline showProgress (showProgress: bool) = Interop.mkJoyrideProp "showProgress" showProgress
    static member inline scrollToFirstStep (scrollToFirstStep: bool) = Interop.mkJoyrideProp "scrollToFirstStep" scrollToFirstStep
    static member inline hideBackButton (hideBackButton: bool) = Interop.mkJoyrideProp "hideBackButton" hideBackButton
    static member inline hideCloseButton (hideCloseButton : bool) = Interop.mkJoyrideProp "hideCloseButton" hideCloseButton
    static member inline locale (props: ILocaleProp seq) = Interop.mkJoyrideProp "locale" (createObj !!props)
    static member inline styles (props: IJoyrideStylesProp seq) = Interop.mkJoyrideProp "styles" (createObj !!props)
    static member inline callback (callback: ICallbackProp -> unit) : IJoyrideProp =
        !!("callback" ==> callback)

[<Erase>]
type joyrideStyles =
    static member inline options (options: IJoyrideStyleProp seq) = Interop.mkStylesProp "options" (createObj !!options)

[<Erase>]
type joyrideStyle =
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
    static member inline target (target: string) : IStepProp = Interop.mkStepProp "target" target
    static member inline content (content: string) : IStepProp = Interop.mkStepProp "content" content
    static member inline disableBeacon (disableBeacon: bool) : IStepProp = Interop.mkStepProp "disableBeacon" disableBeacon
    static member inline hideFooter (hideFooter: bool) : IStepProp = Interop.mkStepProp "hideFooter" hideFooter
    static member inline isFixed (isFixed: bool) : IStepProp = Interop.mkStepProp "isFixed" isFixed
    static member inline placement (placement: string) : IStepProp = Interop.mkStepProp "placement" placement
    static member inline placementBeacon (placementBeacon: string) : IStepProp = Interop.mkStepProp "placementBeacon" placementBeacon
    static member inline title obj = Interop.mkStepProp "title" obj
    static member inline content obj = Interop.mkStepProp "content" obj
    static member inline offset (offset: int) : IStepProp = Interop.mkStepProp "offset" offset
