module Index

open Elmish
open Feliz
open Feliz.Reactour

type Model = { IsRunning: bool }

type Msg =
| StartTour

let init () = {  IsRunning = false }, Cmd.none

let update msg (model: Model) =
    match msg with
    | StartTour -> { model with IsRunning = not model.IsRunning }, Cmd.none

[<ReactComponent>]
let MyComponent () =
    let tour = TourControls.useTour()
    Html.div [
        prop.children [
            Html.section [
                prop.className "section"
                prop.children [
                    Html.h1 [ prop.className "title"; prop.text "Feliz + Bulma + Reactour" ]
                    Html.p [ prop.className "subtitle"; prop.text "A guided tour example using Reactour." ]

                    Html.button [
                        prop.className "button is-primary my-button"
                        prop.text "Start Tour"
                        prop.onClick (fun _ -> tour.setIsOpen true)
                    ]

                    Html.div [
                        prop.className "box highlighted-section"
                        prop.text "This is a highlighted Bulma box."
                    ]
                ]
        ]
    ]
    ]

[<ReactComponent>]
let Reactour () =
    TourProvider.tourProvider [
        reactour.showBadge false
        reactour.showDots false
        reactour.showPrevNextButtons false
        reactour.steps [
            steps.step [
                step.selector ".my-button"
                step.content "Click this button to start your tour!"
            ]
            steps.step [
                step.selector ".highlighted-section"
                step.content "This is a highlighted section."
            ]
        ]
        reactour.styles [
            reactourStyle.badge (fun ``base`` ->
                reactourStyle.merge ``base`` [
                    style.backgroundColor "pink"
                ]
            )

        ]
        reactour.children [
            MyComponent()
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [

        Reactour ()

    ]

