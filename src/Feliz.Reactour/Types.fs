namespace Feliz.Reactour

open Fable.Core

/// This interface allows us to stop adding random props to the TourProvider.
type ITourProviderProp =
    interface
    end
type IReactourProp =
    interface
    end

type IStepsProp =
    interface
    end

type IStepProp =
    interface
    end

type ILocaleProp =
    interface
    end

type IReactourStylesProp =
    interface
    end

type IReactourStyleProp =
    interface
    end

type IStyleProp =
    interface
    end

type IBadgeContentProp =
    interface
    end

[<Erase>]
type ICallbackProp =
    abstract action: string
    abstract controlled: bool
    abstract index: int
    abstract lifecycle: string
    abstract origin: obj option
    abstract size: int
    abstract status: string
    abstract step: obj
    abstract ``type``: string

[<Erase>]
type IStyleProperties =
    abstract padding: int with get, set
    abstract color: string with get, set
    abstract backgroundColor: string with get, set
    abstract ``--reactour-accent``: string with get, set
