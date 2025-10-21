namespace Feliz.Reactour

open Fable.Core

/// This interface allows us to stop adding random props to the reactour.
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

type IJoyrideStylesProp =
    interface
    end

type IJoyrideStyleProp =
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
