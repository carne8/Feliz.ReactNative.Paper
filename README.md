# Feliz.ReactNative.Paper [![Nuget](https://img.shields.io/nuget/v/Feliz.ReactNative.Paper.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.ReactNative.Paper) [![Publish on NuGet](https://github.com/carne8/Feliz.ReactNative.Paper/actions/workflows/publish.yml/badge.svg)](https://github.com/carne8/Feliz.ReactNative.Paper/actions/workflows/publish.yml)

[React Native Paper](https://github.com/callstack/react-native-paper) bindings for [Feliz](https://github.com/Zaid-Ajaj/Feliz)

Usage:

```fsharp
module App

open Feliz
open Feliz.ReactNative

[<ReactComponent>]
let Counter() =
    let (count, setCount) = React.useState(0)
    Comp.view [
        Comp.text [
            prop.style [
                style.width 50.
                style.height 50.
                style.backgroundColor "red"
            ]
            prop.onPress (fun _ -> setCount(count + 1))
            prop.text "Increment"
        ]

        Comp.text [
            prop.style [
                style.width 50.
                style.height 50.
                style.backgroundColor "blue"
            ]
            prop.onPress (fun _ -> setCount(count - 1))
            prop.text "Decrement"
        ]

        Comp.text (count |> string)
    ]
```
