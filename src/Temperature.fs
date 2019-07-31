namespace Frink.Data.Temperature.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Mass.UnitSymbols

    /// The SI unit of thermodynamic temperature (alias of F# unit name)
    [<Measure>] type kelvin = FSharp.Data.UnitSystems.SI.UnitNames.kelvin

     /// In 1741  Anders Celsius introduced a
     /// Temperature scale with water boiling at 0
     /// degrees and freezing at 100 degrees at
     /// standard pressure.  After his death the
     /// fixed points were reversed and the scale
     /// was called the centigrade scale.  Due to
     /// the difficulty of accurately measuring the
     /// temperature of melting ice at standard
     /// pressure, the centigrade scale was replaced
     /// in 1954 by the Celsius scale which is
     /// defined by subtracting 273.15 from the
     /// temperature in Kelvins.  This definition
     /// differed slightly from the old centigrade
     /// definition, but the Kelvin scale depends on
     /// the triple point of water rather than a
     /// melting point, so it can be measured
     /// accurately.
    [<Measure>] type degreeCelsius

    [<Measure>] type degreeFahrenheit

    [<Measure>] type degreesRankine

    /// The Reaumur scale was used in Europe and
    /// particularly in France.  It is defined
    /// to be 0 at the freezing point of water
    /// and 80 at the boiling point.  Reaumur
    /// apparently selected 80 because it is
    /// divisible by many numbers.
    [<Measure>] type degreaumur

    [<Measure>] type microK

    /// Specific heat capacity
    [<Measure>] type mayer = J/(g K)

    /// Reciprocal color temperature.  The name
    /// abbreviates micro reciprocal degree.
    [<Measure>] type mired = microK^-1



namespace Frink.Data.Temperature.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Temperature.UnitNames

    /// A synonym for kelvin, the SI unit of thermodynamic temperature
    [<Measure>] type K = kelvin

    /// A synonim for degreeCelsius
    [<Measure>] type degC = degreeCelsius

    /// A synonim for degreeFahrenheit
    [<Measure>] type degF = degreeFahrenheit

    /// A synonim for degreesRankine
    [<Measure>] type degR = degreesRankine

    /// The Reaumur scale was used in Europe and
    /// particularly in France.  It is defined
    /// to be 0 at the freezing point of water
    /// and 80 at the boiling point.  Reaumur
    /// apparently selected 80 because it is
    /// divisible by many numbers.
    [<Measure>] type degreaumur = Frink.Data.Temperature.UnitNames.degreaumur

    [<Measure>] type microK = Frink.Data.Temperature.UnitNames.microK

    /// Specific heat capacity
    [<Measure>] type mayer = Frink.Data.Temperature.UnitNames.mayer

    /// Reciprocal color temperature.  The name
    /// abbreviates micro reciprocal degree.
    [<Measure>] type mired = Frink.Data.Temperature.UnitNames.mired


namespace Frink.Data.Temperature
    open Frink.Data.Temperature.UnitSymbols
    open Frink.Data.Temperature.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let microKelvinsPerKelvin = 1e6<microK/K>
        let kelvinsPerMicroKelvin = microKelvinsPerKelvin |> reverse

    module Constants =
        let zeroCelsius = 0.<degC>
        let zeroKelvin  = 0.<K>
        let zeroCelsiusInKelvin = 273.15<K>
        let zeroKelvinInCelsius = -273.15<degC>
        let degreaumurInDegC = 1.<degC> * 10./8.

        /// The *size* of a degree in the Fahrenheit scale.
        let degFInDegC = 1.<degC> * 5./9.

        /// The *size* of a degreeR in the Kelvin scale.
        let degRInK = 1.<K> * 5./9.

    module Converters =
        open Helpers
        open Constants

        let microKtoK (mk : float<microK>) = mk / microKelvinsPerKelvin
        let ktoMicroK (k : float<K>) = k / kelvinsPerMicroKelvin
        let degreAumurToDegC (da : float<degreaumur>) = da * (10./8.) * 1.<degC/degreaumur>

        let degCtoDegF (temp:float<degC>) = 9.0<degF> / 5.0<degC> * temp + 32.0<degF>
        let degFtoDegC (temp:float<degF>) = 5.0<degC> / 9.0<degF> * ( temp - 32.0<degF>)

        let degCtoKelvin (temp:float<degC>) = (float temp * 1.<K>) + zeroCelsiusInKelvin
        let kelvinToDegC (temp:float<K>) = (float temp * 1.<degC>) + zeroKelvinInCelsius

        let degFtoKelvin = degFtoDegC >> degCtoKelvin
        let kelvintoDegF = kelvinToDegC >> degCtoDegF