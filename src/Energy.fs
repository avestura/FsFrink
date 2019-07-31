namespace Frink.Data.Energy.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    /// The SI unit of energy, work, amount of heat (alias of F# unit name)
    [<Measure>] type joule = FSharp.Data.UnitSystems.SI.UnitNames.joule

    [<Measure>] type planck = J s

    [<Measure>] type fluxunit

    /// K. G. Jansky identified radio waves coming
    /// from outer space in 1931.
    [<Measure>] type jansky = fluxunit

    [<Measure>] type calorie
    [<Measure>] type kilocalorie

    /// Energy acquired by a particle with charge e
    /// when it is accelerated through 1 V
    [<Measure>] type electronVolt


namespace Frink.Data.Energy.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Energy.UnitNames

    /// A synonim for jansky
    [<Measure>] type Jy = jansky
    /// A synonim of kilocalorie
    [<Measure>] type Cal = kilocalorie
    /// A synonim of calorie
    [<Measure>] type cal = calorie
    /// A synonim of kilocalorie
    [<Measure>] type kcal = kilocalorie
    /// A synonim of electronVolt
    [<Measure>] type eV = electronVolt

    /// A synonym for joule, the SI unit of energy, work, amount of heat
    [<Measure>] type J = joule

    [<Measure>] type planck = Frink.Data.Energy.UnitNames.planck

    [<Measure>] type fluxunit = Frink.Data.Energy.UnitNames.fluxunit


namespace Frink.Data.Energy
    open Frink.Data.Energy.UnitSymbols
    open Frink.Data.Energy.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    module Helpers =
        open Frink.Data.Helper

        let ``W/(m^2 Hz)PerFluxunit`` = 1e-26<(W/(m^2 Hz))/fluxunit>
        let ``fluxunitPerW/(m^2 Hz)`` = ``W/(m^2 Hz)PerFluxunit`` |> reverse

        let caloriePerKcal = 1000.<cal/kcal>
        let kcalPerCalorie = caloriePerKcal |> reverse

    module Converters =
        open Helpers
        let ``W/(m^2 Hz)ToFluxunit`` (value : float<W/(m^2 Hz)>) = value / ``W/(m^2 Hz)PerFluxunit``

    module Constants =
        open Frink.Data.Constants
        open Frink.Data.Material.PhysicoChemicalConstants
        // Calories: energy to raise a gram of water one degree celsius

        /// International Table calorie, 4.1868 J
        let calIT =       4.1868<J>
        /// Thermochemical calorie, 4.184 J
        let calTh =       4.184<J>
        /// Energy to go from 14.5 to 15.5 degC
        let calFifteen =  4.18580<J>
        /// Energy to go from 19.5 to 20.5 degC
        let calTwenty =   4.18190<J>
        /// 1/100 energy to go from 0 to 100 degC
        let calMean =     4.19002<J>
        let calorie =     calIT
        let cal =         calorie
        let calorieIT =   calIT
        let thermcalorie = calTh
        let calorieTh =   thermcalorie
        /// Heat required to raise the
        /// temperature of a tonne of
        /// water from 14.5 to 15.5 degC.
        let thermie = 1e6*calFifteen

        let rydberg = h*c*Rinfinity

        /// Unit of energy used in infrared spectroscopy.
        let cminv = h * c / 0.01<m>
        let invcm = cminv
        let wavenumber = cminv
        /// kcal/mol is used as a unit of
        ///   energy by physical chemists.
        let cal_mol = cal / N_A * 1.<mol>

        /// Suggested by Richard Terrett
        let J_mol = 1.<J> / (N_A * 1.<mol>)
