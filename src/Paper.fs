module Feliz.ReactNative.Paper

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.ReactNative

type IThemeFonts = interface end
type Theme =
    {| dark: bool
       version: int
       mode: string option
       roundness: int
       animation: {| scale: float |}
       fonts: IThemeFonts
       colors:
         {| primary: string
            primaryContainer: string
            secondary: string
            secondaryContainer: string
            tertiary: string
            tertiaryContainer: string
            surface: string
            surfaceVariant: string
            surfaceDisabled: string
            background: string
            error: string
            errorContainer: string
            onPrimary: string
            onPrimaryContainer: string
            onSecondary: string
            onSecondaryContainer: string
            onTertiary: string
            onTertiaryContainer: string
            onSurface: string
            onSurfaceVariant: string
            onSurfaceDisabled: string
            onError: string
            onErrorContainer: string
            onBackground: string
            outline: string
            shadow: string
            inverseOnSurface: string
            inverseSurface: string
            inversePrimary: string
            backdrop: string
            elevation:
             {| level0: string
                level1: string
                level2: string
                level3: string
                level4: string
                level5: string |} |} |}

module Theme =
    let inline defaultLight () : Theme = import "MD3LightTheme" "react-native-paper" |> unbox<Theme>
    let inline defaultDark () : Theme = import "MD3DarkTheme" "react-native-paper" |> unbox<Theme>
    let inline withFonts fonts (theme: Theme) : Theme =
        {| theme with fonts = (import "configureFonts" "react-native-paper") {| config = fonts |} |}

type [<Erase>] prop =
    static member inline animating (value: bool) = Interop.mkAttr "animating" value
    static member inline size (value: float) = Interop.mkAttr "size" value
    static member inline hidesWhenStopped (value: bool) = Interop.mkAttr "hidesWhenStopped" value
    static member inline theme (value: Theme) = Interop.mkAttr "theme" value
    static member inline icon (value: string) = Interop.mkAttr "icon" value
    static member inline icon (value: IImageSource) = Interop.mkAttr "icon" value
    static member inline icon (source: string, direction: string) = Interop.mkAttr "icon" (createObj [ "source", source; "direction", direction ])
    static member inline icon (source: IImageSource, direction: string) = Interop.mkAttr "icon" (createObj [ "source", source; "direction", direction ])
    static member inline label (value: string) = Interop.mkAttr "label" value
    static member inline uppercase (value: bool) = Interop.mkAttr "uppercase" value
    static member inline color (value: string) = Interop.mkAttr "color" value
    static member inline visible (value: bool) = Interop.mkAttr "visible" value
    static member inline extended (value: bool) = Interop.mkAttr "extended" value
    static member inline dark (value: bool) = Interop.mkAttr "dark" value
    static member inline elevated (value: bool) = Interop.mkAttr "elevated" value
    static member inline safeAreaInsets (value: {| top: float; bottom: float; left: float; right: float |}) = Interop.mkAttr "safeAreaInsets" value
    static member inline isLeading (value: bool) = Interop.mkAttr "isLeading" value
    static member inline ref (value: _) = Interop.mkAttr "ref" value
    static member inline titleStyle (value: #seq<IStyleAttribute>) = Interop.mkAttr "titleStyle" value
    static member inline titleRef (value: _) = Interop.mkAttr "titleRef" value
    static member inline subtitle (value: string) = Interop.mkAttr "subtitle" value
    static member inline statusBarHeight (value: float) = Interop.mkAttr "statusBarHeight" value
    static member inline labelStyle (value: #seq<IStyleAttribute>) = Interop.mkAttr "labelStyle" value
    static member inline actions (value: #seq<{| label: string; onPress: unit -> unit |}>) = Interop.mkAttr "labelStyle" value
    static member inline onShowAnimationFinished (value: unit -> unit) = Interop.mkAttr "onShowAnimationFinished" value
    static member inline onHideAnimationFinished (value: unit -> unit) = Interop.mkAttr "onHideAnimationFinished" value
    static member inline compact (value: bool) = Interop.mkAttr "compact" value
    static member inline buttonColor (value: string) = Interop.mkAttr "buttonColor" value
    static member inline textColor (value: string) = Interop.mkAttr "textColor" value
    static member inline loading (value: bool) = Interop.mkAttr "loading" value
    static member inline accessibilityHint (value: string) = Interop.mkAttr "accessibilityHint" value
    static member inline contentStyle (value: #seq<IStyleAttribute>) = Interop.mkAttr "contentStyle" value

[<Erase>]
module prop =
    type [<Erase>] variant =
        static member inline displayLarge = Interop.mkAttr "variant" "displayLarge"
        static member inline displayMedium = Interop.mkAttr "variant" "displayMedium"
        static member inline displaySmall = Interop.mkAttr "variant" "displaySmall"
        static member inline headlineLarge = Interop.mkAttr "variant" "headlineLarge"
        static member inline headlineMedium = Interop.mkAttr "variant" "headlineMedium"
        static member inline headlineSmall = Interop.mkAttr "variant" "headlineSmall"
        static member inline titleLarge = Interop.mkAttr "variant" "titleLarge"
        static member inline titleMedium = Interop.mkAttr "variant" "titleMedium"
        static member inline titleSmall = Interop.mkAttr "variant" "titleSmall"
        static member inline bodyLarge = Interop.mkAttr "variant" "bodyLarge"
        static member inline bodyMedium = Interop.mkAttr "variant" "bodyMedium"
        static member inline bodySmall = Interop.mkAttr "variant" "bodySmall"
        static member inline labelLarge = Interop.mkAttr "variant" "labelLarge"
        static member inline labelMedium = Interop.mkAttr "variant" "labelMedium"
        static member inline labelSmall = Interop.mkAttr "variant" "labelSmall"

        static member inline primary = Interop.mkAttr "variant" "primary"
        static member inline secondary = Interop.mkAttr "variant" "secondary"
        static member inline tertiary = Interop.mkAttr "variant" "tertiary"
        static member inline surface = Interop.mkAttr "variant" "surface"
    type [<Erase>] size =
        static member inline small = Interop.mkAttr "size" "small"
        static member inline large = Interop.mkAttr "size" "large"
    type [<Erase>] iconMode =
        static member inline static' = Interop.mkAttr "iconMode" "static"
        static member inline dynamic = Interop.mkAttr "iconMode" "dynamic"
    type [<Erase>] animateFrom =
        static member inline left = Interop.mkAttr "animateFrom" "left"
        static member inline right = Interop.mkAttr "animateFrom" "right"
    type [<Erase>] mode =
        static member inline small = Interop.mkAttr "mode" "small"
        static member inline medium = Interop.mkAttr "mode" "medium"
        static member inline large = Interop.mkAttr "mode" "large"
        static member inline centerAligned = Interop.mkAttr "mode" "center-aligned"
        static member inline text = Interop.mkAttr "mode" "text"
        static member inline outlined = Interop.mkAttr "mode" "outlined"
        static member inline contained = Interop.mkAttr "mode" "contained"
        static member inline elevated = Interop.mkAttr "mode" "elevated"
        static member inline containedTonal = Interop.mkAttr "mode" "contained-tonal"

let inline private createPaperElement elementName (props: #seq<IReactProperty>) =
    Interop.createElement (import elementName "react-native-paper") (createObj !!props)

[<Erase>]
type Paper =
    static member inline useTheme () : Theme = (import "useTheme" "react-native-paper")()
    static member inline Provider (theme: Theme option) (children: #seq<ReactElement>) =
        Interop.createElement
            (import "Provider" "react-native-paper")
            (createObj [ "children", Array.ofSeq children
                         "theme", theme ])

    static member inline Button props = createPaperElement "Button" props
    static member inline Text props = createPaperElement "Text" props
    static member inline Text (str: string) = createPaperElement "Text" [ prop.variant.labelMedium; !!("children", str) ]
    static member inline ActivityIndicator props = createPaperElement "ActivityIndicator" props
    static member inline AnimatedFAB props = createPaperElement "AnimatedFAB" props
    static member inline Badge props = createPaperElement "Badge" props
    static member inline Appbar props = createPaperElement "Appbar" props

[<Erase>]
module Paper =
    let inline private PaperSubElement parent (element: string) (props: #seq<IReactProperty>) : ReactElement =
        Interop.createElement (import parent "react-native-paper")?(element) (createObj !!props)

    type [<Erase>] Appbar =
        static member inline Action props = PaperSubElement "Appbar" "Action" props
        static member inline BackAction props = PaperSubElement "Appbar" "BackAction" props
        static member inline Content props = PaperSubElement "Appbar" "Content" props
        static member inline Header props = PaperSubElement "Appbar" "Header" props

    type [<Erase>] Avatar =
        static member inline Icon props = PaperSubElement "Avatar" "Icon" props
        static member inline Image props = PaperSubElement "Avatar" "Image" props
        static member inline Text props = PaperSubElement "Avatar" "Text" props