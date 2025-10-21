module Docs.Pages.ReactourView

open Feliz
open Feliz.Bulma
open Feliz.Reactour
open Docs.SharedView

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
        reactour.children [
            MyComponent()
        ]
    ]
let ReactourContainer =
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            Reactour ()
        ]
    ]


let code =
    """
    TourProvider.tourProvider [
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
        reactour.children [
            MyComponent()
        ]
    ]
    """

let title = Html.text "QR Code"

[<ReactComponent>]
let QRCodeView () =
    Html.div [
        Bulma.content [
            codedView title code ReactourContainer
        ]
        fixDocsView "Reactour" false
    ]
