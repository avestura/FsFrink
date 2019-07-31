namespace Frink.Data.Mass.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    /// The SI unit of mass (alias of F# unit name)
    [<Measure>] type kilogram = FSharp.Data.UnitSystems.SI.UnitNames.kilogram
    [<Measure>] type gram
    [<Measure>] type milligram
    [<Measure>] type tonne
    [<Measure>] type metricton = tonne
    [<Measure>] type sthene = tonne m / s^2
    [<Measure>] type funal = sthene
    [<Measure>] type pieze = sthene / m^2
    [<Measure>] type quintal
    [<Measure>] type microgram
    [<Measure>] type gamma = microgram
    [<Measure>] type metricounce
    [<Measure>] type mounce = metricounce

namespace Frink.Data.Mass.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Mass.UnitNames

    [<Measure>] type kg = kilogram

    ///  A synonim for gram
    [<Measure>] type g = gram

    ///  A synonim for milligram
    [<Measure>] type mg = milligram

    ///  A synonim for tonne
    [<Measure>] type t = tonne

    [<Measure>] type metricton = Frink.Data.Mass.UnitNames.metricton
    [<Measure>] type sthene = Frink.Data.Mass.UnitNames.sthene
    [<Measure>] type funal = Frink.Data.Mass.UnitNames.funal
    [<Measure>] type pieze = Frink.Data.Mass.UnitNames.pieze
    [<Measure>] type quintal = Frink.Data.Mass.UnitNames.quintal
    [<Measure>] type microgram = Frink.Data.Mass.UnitNames.microgram
    [<Measure>] type gamma = Frink.Data.Mass.UnitNames.gamma
    [<Measure>] type metricounce = Frink.Data.Mass.UnitNames.metricounce
    [<Measure>] type mounce = Frink.Data.Mass.UnitNames.mounce


namespace Frink.Data.Mass
    open Frink.Data.Mass.UnitSymbols
    open Frink.Data.Mass.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let gramsPerKg = 1000.<g/kg>
        let kgsPerGrams = gramsPerKg |> reverse

        let kgsPerTonnes = 1e3<kg/tonne>
        let tonnesPerKg = kgsPerTonnes |> reverse

        let kgsPerQuintal = 100.<kg/quintal>
        let quintalsPerKg = kgsPerQuintal |> reverse

        let microgramsPerGrams = 1e6<microgram/gram>
        let gramsPerMicrograms = microgramsPerGrams |> reverse

        let gramsPerMetricounce = 25.<g/metricounce>
        let metricouncesPerGrams = gramsPerMetricounce |> reverse

        let mgsPerGrams = 1000.<mg/g>
        let gramsPerMgs = mgsPerGrams |> reverse

    module Converters =
        open Helpers

        let gramToKilogram (grams : float<g>) = grams / gramsPerKg

    module Constants =
        /// The crith is the mass of one
        ///   liter of hydrogen at standard
        ///   temperature and pressure.
        let crith = 0.089885<g>