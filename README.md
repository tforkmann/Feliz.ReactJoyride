# Feliz Binding for [Reactour](https://github.com/elrumordelaluz/reactour)

[![Feliz.Reactour on Nuget](https://buildstats.info/nuget/Feliz.Reactour)](https://www.nuget.org/packages/Feliz.Reactour/)
[![Docs](https://github.com/tforkmann/Feliz.Reactour/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.Reactour/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.Reactour
```

and install the npm package

```
npm install --save reactour
```

or use Femto:
```
femto install Feliz.Reactour
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Example Reactour
Here is an example Reactour
```fs
[<ReactComponent>]
let Reactour (model:Model) dispatch =
    Reactour.reactour [
        reactour.run model.IsRunning
        reactour.steps [
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
                    Html.h1 [ prop.className "title"; prop.text "Feliz + Bulma + Reactour" ]
                    Html.p [ prop.className "subtitle"; prop.text "A guided tour example using Reactour." ]

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

            Reactour model dispatch
        ]
        ]
```
