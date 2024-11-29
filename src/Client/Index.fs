module Index

open Elmish
open Feliz
open Feliz.ReactJoyride

type Model = { Hex: string }

type Msg =
| UpdateColor of string

let init () = { Hex = "#FF0000" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateColor hex -> { model with Hex = hex }, Cmd.none

[<ReactComponent>]
let Joyride color dispatch =
    Joyride.joyride [
        joyride.steps [
            steps.step [
                step.target ".color-picker"
                step.content "Change the color"
            ]
        ]
        // chromePicker.onChangeComplete (fun color ->  UpdateColor color.hex |> dispatch)
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.children [
            Joyride model.Hex dispatch
        ]
    ]
