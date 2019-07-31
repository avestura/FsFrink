namespace Frink.Data.Pressure.UnitNames
    open Microsoft.FSharp.Core

    /// The SI unit of pressure, stress (alias of F# unit name)
    [<Measure>] type pascal = FSharp.Data.UnitSystems.SI.UnitNames.pascal

    [<Measure>] type bar
    [<Measure>] type vac

    [<Measure>] type inHg
    [<Measure>] type inH2O
    [<Measure>] type inchmercury = inHg
    [<Measure>] type inchesmercury = inHg
    [<Measure>] type mmH2O
    [<Measure>] type mmHg

namespace Frink.Data.Pressure.UnitSymbols
    open Microsoft.FSharp.Core

    /// The SI unit of pressure, stress (alias of F# unit name)
    [<Measure>] type Pa = FSharp.Data.UnitSystems.SI.UnitSymbols.Pa

    [<Measure>] type bar = Frink.Data.Pressure.UnitNames.bar
    [<Measure>] type vac = Frink.Data.Pressure.UnitNames.vac

    [<Measure>] type inHg = Frink.Data.Pressure.UnitNames.inHg
    [<Measure>] type inH2O = Frink.Data.Pressure.UnitNames.inH2O
    [<Measure>] type inchmercury = Frink.Data.Pressure.UnitNames.inchmercury
    [<Measure>] type inchesmercury = Frink.Data.Pressure.UnitNames.inchesmercury
    [<Measure>] type mmH2O = Frink.Data.Pressure.UnitNames.mmH2O
    [<Measure>] type mmHg = Frink.Data.Pressure.UnitNames.mmHg


namespace Frink.Data.Pressure
    open Frink.Data.Pressure.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Constants
    open Frink.Data.Material.PhysicoChemicalConstants
    open Frink.Data.Length.UnitSymbols
    open Frink.Data.Mass.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let barsPerPascal = 1e5<bar/Pa>
        let pascalsPerBar = barsPerPascal |> reverse

        let vacsPerBar    = 1e-3<vac/bar>
        let barsPerVacs   = vacsPerBar |> reverse

    module Constants =
        let inHgUnit = gravity * Hg * 1.<inch>
        let inH20Unit = gravity * water * 1.<inch>
        let mmH20Unit = gravity * water * 1.<mm>
        let mmHg = gravity * Hg * 1.<mm>
        let kgf = gravity * 1.<kg>
        let technicalatmosphere = kgf / 1.<cm^2>
        let at = technicalatmosphere
        let hyl = kgf * 1.<s^2/m>
        let torr = (101325./760.) * 1.<Pa>