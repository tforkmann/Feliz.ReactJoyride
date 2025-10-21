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
    static member inline padding (padding: int) = Interop.mkReactourProp "padding" padding
    static member inline className (className: string) = Interop.mkReactourProp "className" className
    static member inline nextButton (nextButton: ReactElement) = Interop.mkReactourProp "nextButton" nextButton
    static member inline prevButton (prevButton: ReactElement) = Interop.mkReactourProp "prevButton" prevButton
    static member inline badgeContent (props: IBadgeContentProp seq) : IReactourProp = !!(createObj !!props)
    static member inline styles (props: IReactourStyleProp seq) = Interop.mkReactourProp "styles" (createObj !!props)
    static member inline showNavigation (showNavigation: bool) = Interop.mkReactourProp "showNavigation" showNavigation
    static member inline showBadge (showBadge: bool) = Interop.mkReactourProp "showBadge" showBadge
    static member inline showPrevNextButtons (showPrevNextButtons: bool) = Interop.mkReactourProp "showPrevNextButtons" showPrevNextButtons
    static member inline showCloseButton (showCloseButton: bool) = Interop.mkReactourProp "showCloseButton" showCloseButton
    static member inline showDots (showDots: bool) = Interop.mkReactourProp "showDots" showDots

    static member inline callback (callback: ICallbackProp -> unit) : IReactourProp =
        !!("callback" ==> callback)

[<Erase>]
type reactourStyle =
    static member inline popover (handler: obj -> obj) = !!("popover" ==> handler)
    static member inline maskArea (handler: obj -> obj) = !!("maskArea" ==> handler)

    static member inline maskWrapper(handler: IStyleProperties -> unit) = !!("maskWrapper" ==> handler)
    static member inline badge (handler: obj -> obj) = !!("badge" ==> handler)
    static member inline controls (handler: obj -> obj) = !!("controls" ==> handler)
    static member inline close (handler: obj -> obj) = !!("close" ==> handler)
    /// merges a Reactour base style with Feliz-style overrides
    static member inline merge (baseObj: obj) (props: IStyleProp seq) =
        // Cast Object.entries(...) to a seq of obj arrays, so pair.[0] and pair.[1] are valid
        let baseEntries =
            JS.Constructors.Object.entries baseObj
            |> unbox<obj[][]>
            |> Seq.map (fun pair ->
                let key = pair.[0] :?> string
                let value = pair.[1]
                key, value)

        createObj [
            yield! baseEntries
            yield! props |> Seq.map unbox<string * obj>
        ]

[<Erase>]
type style =
    static member inline borderRadius (radius: int) : IStyleProp = Interop.mkStyleProp "borderRadius" radius
    static member inline color (color: string) : IStyleProp = Interop.mkStyleProp "color" color
    static member inline backgroundColor (backgroundColor: string) : IStyleProp = Interop.mkStyleProp "backgroundColor" backgroundColor

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
