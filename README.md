# Feliz Binding for [ReactJoyride](https://github.com/gilbarbara/react-joyride)

[![Feliz.ReactJoyride on Nuget](https://buildstats.info/nuget/Feliz.ReactJoyride)](https://www.nuget.org/packages/Feliz.ReactJoyride/)
[![Docs](https://github.com/tforkmann/Feliz.ReactJoyride/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.ReactJoyride/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.ReactJoyride
```

and install the npm package

```
npm install --save react-joyride
```

or use Femto:
```
femto install Feliz.ReactJoyride
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Example ReactJoyride
Here is an example ReactJoyride
```fs
[<ReactComponent>]
let Joyride (model:Model) dispatch =
    Joyride.joyride [
        joyride.run model.IsRunning
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
```
