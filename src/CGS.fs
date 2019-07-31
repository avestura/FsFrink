namespace Frink.Data.CGS.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Mass.UnitSymbols
    open Frink.Data.Length.UnitSymbols

    [<Measure>] type dyne = cm g / s^2
    [<Measure>] type dyn = dyne

    [<Measure>] type erg = cm dyne
    [<Measure>] type poise = g / (cm s)
    [<Measure>] type centipoise
    [<Measure>] type rhe = poise ^-1
    [<Measure>] type stoke = cm^2/s
    [<Measure>] type lentor = stoke
    /// Acceleration, used in geophysics
    /// for earth's gravitational field
    /// (note that "gal" is for gallon
    /// but "Gal" is the standard symbol
    /// for the gal which is evidently a
    /// shortened form of "galileo".)
    [<Measure>] type Gal = cm / s^2

    [<Measure>] type galileo = Gal
    [<Measure>] type barye = dyne / cm^2
    [<Measure>] type barad = barye
    [<Measure>] type kayser = 1/cm
    [<Measure>] type balmer = kayser
    [<Measure>] type kine = cm/s
    [<Measure>] type bole = g cm /s
    [<Measure>] type mobileohm = cm / (dyn s)
    [<Measure>] type mechanicalohm = dyn s / cm
    [<Measure>] type acousticalohm = dyn s / cm^5
    [<Measure>] type rayl = dyn s / cm^3




namespace Frink.Data.CGS.UnitSymbols
    open Microsoft.FSharp.Core
    open Frink.Data.CGS.UnitNames

    [<Measure>] type p = poise
    [<Measure>] type St = stoke
    [<Measure>] type mohm = mobileohm
    [<Measure>] type ray = acousticalohm
    [<Measure>] type rayl = Frink.Data.CGS.UnitNames.rayl

    [<Measure>] type dyne = Frink.Data.CGS.UnitNames.dyn
    [<Measure>] type dyn = Frink.Data.CGS.UnitNames.dyn

    [<Measure>] type erg = Frink.Data.CGS.UnitNames.erg
    [<Measure>] type centipoise = Frink.Data.CGS.UnitNames.centipoise
    [<Measure>] type rhe = Frink.Data.CGS.UnitNames.rhe
    [<Measure>] type lentor = Frink.Data.CGS.UnitNames.lentor
    /// Acceleration, used in geophysics
    /// for earth's gravitational field
    /// (note that "gal" is for gallon
    /// but "Gal" is the standard symbol
    /// for the gal which is evidently a
    /// shortened form of "galileo".)
    [<Measure>] type Gal = Frink.Data.CGS.UnitNames.Gal

    [<Measure>] type galileo = Frink.Data.CGS.UnitNames.galileo
    [<Measure>] type barye = Frink.Data.CGS.UnitNames.barye
    [<Measure>] type barad = Frink.Data.CGS.UnitNames.barad
    [<Measure>] type kayser = Frink.Data.CGS.UnitNames.kayser
    [<Measure>] type balmer = Frink.Data.CGS.UnitNames.balmer
    [<Measure>] type kine = Frink.Data.CGS.UnitNames.kine
    [<Measure>] type bole = Frink.Data.CGS.UnitNames.bole
    [<Measure>] type mechanicalohm = Frink.Data.CGS.UnitNames.mechanicalohm


namespace Frink.Data.CGS
    open Frink.Data.CGS.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Constants
    open Frink.Data.Mass.UnitSymbols
    open Frink.Data.Length.UnitSymbols


    module Helpers =
        open Frink.Data.Helper
        let centipoisesPerPoise = 100.<centipoise/poise>
        let poisesPerCentipoise = centipoisesPerPoise |> reverse

    module Constants =
        let pond = force * 1.<g>
        let glug = force * 1.<g s^2/cm>
        let darcy = atm * 1.<centipoise cm^2 / s>
        let eotvos = 1e-9<Gal/cm>