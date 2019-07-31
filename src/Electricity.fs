namespace Frink.Data.Electricity.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    /// The SI unit of electric current (alias of F# unit name)
    [<Measure>] type ampere = FSharp.Data.UnitSystems.SI.UnitNames.ampere

    /// The SI unit of electric charge, amount of electricity (alias of F# unit name)
    [<Measure>] type coulomb = FSharp.Data.UnitSystems.SI.UnitNames.coulomb

    /// The SI unit of electric potential difference, electromotive force (alias of F# unit name)
    [<Measure>] type volt = FSharp.Data.UnitSystems.SI.UnitNames.volt

    /// The SI unit of capacitance (alias of F# unit name)
    [<Measure>] type farad = FSharp.Data.UnitSystems.SI.UnitNames.farad

    /// The SI unit of electric resistance (alias of F# unit name)
    [<Measure>] type ohm = FSharp.Data.UnitSystems.SI.UnitNames.ohm

    /// The SI unit of electric conductance (alias of F# unit name)
    [<Measure>] type siemens = FSharp.Data.UnitSystems.SI.UnitNames.siemens

    /// The SI unit of magnetic flux (alias of F# unit name)
    [<Measure>] type weber = FSharp.Data.UnitSystems.SI.UnitNames.weber

    /// The SI unit of magnetic flux density (alias of F# unit name)
    [<Measure>] type tesla = FSharp.Data.UnitSystems.SI.UnitNames.tesla

    /// The SI unit of inductance (alias of F# unit name)
    [<Measure>] type henry = FSharp.Data.UnitSystems.SI.UnitNames.henry

    /// Inverse of ohm, hence ohm spelled backward (alias of siemens)
    [<Measure>] type mho = siemens

    // Named after Luigi Galvani (alias of ampere)
    [<Measure>] type galvat = ampere

    /// resistivity
    [<Measure>] type preece

    [<Measure>] type sturgeon = henry^-1

    // Elastance (farad spelled backwards)
    [<Measure>] type daraf = 1/farad

    [<Measure>] type megavolt
    [<Measure>] type crocodile = megavolt

namespace Frink.Data.Electricity.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Electricity.UnitNames


    /// The SI unit of electric current (alias of F# unit name)
    [<Measure>] type A = FSharp.Data.UnitSystems.SI.UnitSymbols.A

    /// The SI unit of electric charge, amount of electricity (alias of F# unit name)
    [<Measure>] type C = FSharp.Data.UnitSystems.SI.UnitSymbols.C

    /// The SI unit of electric potential difference, electromotive force (alias of F# unit name)
    [<Measure>] type V = FSharp.Data.UnitSystems.SI.UnitSymbols.V

    /// The SI unit of capacitance (alias of F# unit name)
    [<Measure>] type F = FSharp.Data.UnitSystems.SI.UnitSymbols.F

    /// The SI unit of electric resistance (alias of F# unit name)
    [<Measure>] type ohm = FSharp.Data.UnitSystems.SI.UnitSymbols.ohm

    /// The SI unit of electric conductance (alias of F# unit name)
    [<Measure>] type S = FSharp.Data.UnitSystems.SI.UnitSymbols.S

    /// The SI unit of magnetic flux (alias of F# unit name)
    [<Measure>] type Wb = FSharp.Data.UnitSystems.SI.UnitSymbols.Wb

    /// The SI unit of magnetic flux density (alias of F# unit name)
    [<Measure>] type T = FSharp.Data.UnitSystems.SI.UnitSymbols.T

    /// The SI unit of inductance (alias of F# unit name)
    [<Measure>] type H = FSharp.Data.UnitSystems.SI.UnitSymbols.H

    /// Inverse of ohm, hence ohm spelled backward (alias of siemens)
    [<Measure>] type mho = Frink.Data.Electricity.UnitNames.mho

    // Named after Luigi Galvani (alias of ampere)
    [<Measure>] type galvat = Frink.Data.Electricity.UnitNames.ampere

    /// resistivity
    [<Measure>] type preece = Frink.Data.Electricity.UnitNames.preece

    [<Measure>] type sturgeon = Frink.Data.Electricity.UnitNames.sturgeon

    // Elastance (farad spelled backwards)
    [<Measure>] type daraf = Frink.Data.Electricity.UnitNames.daraf

    [<Measure>] type megavolt = Frink.Data.Electricity.UnitNames.megavolt
    [<Measure>] type crocodile = Frink.Data.Electricity.UnitNames.crocodile


namespace Frink.Data.Electricity
    open Frink.Data.Electricity.UnitSymbols
    open Frink.Data.Electricity.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

    module Helpers =
        open Frink.Data.Helper

        let ohmMetersPerPreece = 1e13<ohm m/preece>
        let preecesPerOhmMeter = ohmMetersPerPreece |> reverse

        let voltsPerMegavolt = 1e6<V/megavolt>
        let megavoltsPerVolt = voltsPerMegavolt |> reverse

    module Constants =
        open Frink.Data.Constants
        open Frink.Data.Material.PhysicoChemicalConstants

        let lorentz = bohrmagneton / h * c
