namespace Frink.Data.Volume.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Length.UnitSymbols
    open Frink.Data.Mass.UnitSymbols

    [<Measure>] type cubicCentimetre = cm^3

    /// The liter was defined in 1901 as the
    /// space occupied by 1 kg of pure water at
    /// the temperature of its maximum density
    /// under a pressure of 1 atm.  This was
    /// supposed to be 1000 cubic cm, but it
    /// was discovered that the original
    /// measurement was off.  In 1964, the
    /// liter was redefined to be exactly 1000
    /// cubic centimeters.
    [<Measure>] type liter

    [<Measure>] type oldLiter

    [<Measure>] type gammil = mg/liter

    [<Measure>] type microliter

    [<Measure>] type lambda = microliter

namespace Frink.Data.Volume.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Volume.UnitNames

    ///  A synonim for Cubic Centimetre
    [<Measure>] type cc = cubicCentimetre
    ///  A synonim for Liter.
    /// This unit and its symbol l were adopted by
    /// the CIPM in 1879. The alternative symbol for
    /// the liter, L, was adopted by the CGPM in 1979
    /// in order to avoid the risk of confusion
    /// between the letter l and the number 1. Thus,
    /// although both l and L are internationally
    /// accepted symbols for the liter, to avoid this
    /// risk the preferred symbol for use in the
    /// United States is L.
    [<Measure>] type l = liter
    ///  A synonim for Liter.
    /// This unit and its symbol l were adopted by
    /// the CIPM in 1879. The alternative symbol for
    /// the liter, L, was adopted by the CGPM in 1979
    /// in order to avoid the risk of confusion
    /// between the letter l and the number 1. Thus,
    /// although both l and L are internationally
    /// accepted symbols for the liter, to avoid this
    /// risk the preferred symbol for use in the
    /// United States is L.
    [<Measure>] type L = liter

    [<Measure>] type microliter = Frink.Data.Volume.UnitNames.microliter
    [<Measure>] type lambda = Frink.Data.Volume.UnitNames.lambda

namespace Frink.Data.Volume
    open Frink.Data.Volume.UnitSymbols
    open Frink.Data.Volume.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Length.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let ccPerLiters = 1000.<cc/liter>
        let litersPerCc = ccPerLiters |> reverse

        let dm3sPerOldLiters =  1.000028<dm^3/oldLiter>
        let oldlitersPerDm3 = dm3sPerOldLiters |> reverse

    module Converters =
        open Helpers

        let ccToLiter (cc:float<cc>) = cc / ccPerLiters
        let literToCc (liter : float<liter>) = liter / litersPerCc