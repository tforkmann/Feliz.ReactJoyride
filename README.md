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
npm install --save react-color
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
// let QRCodeCanvas () =
//     QRCode.qrcodecanvas [
//         qrCodeCanvas.value "https://www.google.com"
//         qrCodeCanvas.size 600
//         qrCodeCanvas.bgColor "#ffffff"
//         qrCodeCanvas.fgColor "#000000"
//         qrCodeCanvas.level "L"
//         qrCodeCanvas.includeMargin false
//         qrCodeCanvas.imageSettings [
//             imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
//             imageSettings.height 24
//             imageSettings.width 24
//             imageSettings.excavate true
//         ]
//     ]
```

You can find more examples [here](https://tforkmann.github.io/Feliz.ReactJoyride/)
