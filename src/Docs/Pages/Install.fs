﻿module Docs.Pages.Install

open Feliz
open Elmish
open Feliz.DaisyUI
open Docs.SharedView

[<ReactComponent>]
let InstallView () =
    React.fragment [
        Html.divClassed "description" [ Html.text "Using NuGet package command" ]
        Html.divClassed
            "max-w-xl"
            [ Daisy.mockupCode [
                  Html.pre [
                      mockupCode.prefix "$"
                      prop.children [
                          Html.code "Install-Package Feliz.ReactJoyride"
                      ]
                  ]
              ] ]
        Html.divClassed "description" [ Html.text "or Paket" ]
        Html.divClassed
            "max-w-xl"
            [ Daisy.mockupCode [
                  Html.pre [
                      mockupCode.prefix "$"
                      prop.children [
                          Html.code "paket add Feliz.ReactJoyride"
                      ]
                  ]
              ] ]

        ]
