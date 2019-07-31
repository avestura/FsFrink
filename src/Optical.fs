namespace Frink.Data.Optical.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Length.UnitNames

    /// The SI unit of luminous intensity (alias of F# unit name)
    [<Measure>] type candela = FSharp.Data.UnitSystems.SI.UnitNames.candela

    [<Measure>] type lumen = candela

    /// measures stress-optical coef
    [<Measure>] type brewster = micron^2/N

    /// measures reciprocal of lens focal length
    [<Measure>] type diopter = m^-1

    /// occasionally used in spectroscopy
    [<Measure>] type fresnel

    [<Measure>] type finsenunit

namespace Frink.Data.Optical.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Optical.UnitNames

    /// The SI unit of luminous intensity (alias of F# unit name)
    [<Measure>] type cd = FSharp.Data.UnitSystems.SI.UnitSymbols.cd

    [<Measure>] type lumen = Frink.Data.Optical.UnitNames.lumen

    /// measures stress-optical coef
    [<Measure>] type brewster = Frink.Data.Optical.UnitNames.brewster

    /// measures reciprocal of lens focal length
    [<Measure>] type diopter = Frink.Data.Optical.UnitNames.diopter

    /// occasionally used in spectroscopy
    [<Measure>] type fresnel = Frink.Data.Optical.UnitNames.fresnel

    [<Measure>] type finsenunit = Frink.Data.Optical.UnitNames.finsenunit


namespace Frink.Data.Optical
    open Frink.Data.Optical.UnitSymbols
    open Frink.Data.Optical.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let hzsPerFresnel = 1e12<Hz/fresnel>
        let fresnelsPerHz = hzsPerFresnel |> reverse

        let ``(W/m^2)PerFinsenunit`` =  1e5<(W/m^2)/finsenunit>
        let ``finsenunitPer(W/m^2)`` = ``(W/m^2)PerFinsenunit`` |> reverse

    //module Converters =