module Index

open Elmish
open Feliz
open Feliz.ReactJoyride

type Model = { IsRunning: bool }

type Msg =
| StartTour

let init () = {  IsRunning = false }, Cmd.none

let update msg (model: Model) =
    match msg with
    | StartTour -> { model with IsRunning = true }, Cmd.none

[<ReactComponent>]
let Joyride (model:Model) dispatch =
    Joyride.joyride [
        joyride.run model.IsRunning
        joyride.continuous true
        joyride.locale [
            locale.back "Back"
            locale.close "Close"
            locale.last "Last"
            locale.next "Next"
            locale.skip "Skip"
        ]
        joyride.styles [
            joyrideStyles.options [
                joyrideStyle.textColor "#3D3D3D"
                joyrideStyle.primaryColor "green"
            ]
        ]
        joyride.steps [
            steps.step [
                step.target ".my-button"
                step.content "Click this button to start your tour!"
            ]
            steps.step [
                step.target ".highlighted-section"
                step.content "This is a highlighted section."
            ]
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.children [
            Html.section [
                prop.className "section"
                prop.children [
                    Html.h1 [ prop.className "title"; prop.text "Feliz + Bulma + Joyride" ]
                    Html.p [ prop.className "subtitle"; prop.text "A guided tour example using Joyride." ]

                    Html.button [
                        prop.className "button is-primary my-button"
                        prop.text "Start Tour"
                        prop.onClick (fun _ -> dispatch StartTour)
                    ]

                    Html.div [
                        prop.className "box highlighted-section"
                        prop.text "This is a highlighted Bulma box."
                    ]
                ]
            ]

            Joyride model dispatch
        ]
        ]

