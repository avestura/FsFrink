namespace Frink.Data.Length.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    /// The SI unit of length (alias of F# unit name)
    [<Measure>] type metre = FSharp.Data.UnitSystems.SI.UnitNames.metre
    /// The SI unit of length (alias of F# unit name)
    [<Measure>] type meter = metre
    /// One tenth of a metre
    [<Measure>] type decimetre
    [<Measure>] type centimeters
    [<Measure>] type millimeters
    [<Measure>] type kilometers
    /// One millionth of a meter
    [<Measure>] type micron
    /// One millionth of a meter
    [<Measure>] type bicron

    /// Convenient for describing molecular sizes
    [<Measure>] type angstrom

    /// Used for measuring wavelengths
    /// of X-rays.  It is defined to be
    /// 1/3029.45 of the spacing of calcite
    /// planes at 18 degC.  It was intended
    /// to be exactly 1e-13 m, but was
    /// later found to be off slightly.
    [<Measure>] type xunit
    /// An alias of xunit
    [<Measure>] type siegbahn = xunit

    /// Convenient for describing nuclear sizes
    /// Nuclear radius is from 1 to 10 fermis
    [<Measure>] type fermi

    /// Rarely used for astronomical measurements
    [<Measure>] type spat

    [<Measure>] type inch
    [<Measure>] type foot
    [<Measure>] type feet = foot
    [<Measure>] type yard

    [<Measure>] type mile

    [<Measure>] type lightyear

namespace Frink.Data.Length.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Length.UnitNames

    /// A synonim for meter
    [<Measure>] type m = FSharp.Data.UnitSystems.SI.UnitSymbols.m
    /// A synonim for decimeters
    [<Measure>] type dm = decimetre
    /// A synonim for centimeters
    [<Measure>] type cm = centimeters
    /// A synonim for kilometers
    [<Measure>] type km
    /// A synonim for foot
    [<Measure>] type ft = foot
    /// One millionth of a meter
    [<Measure>] type micron = Frink.Data.Length.UnitNames.micron
    /// One millionth of a meter
    [<Measure>] type bicron = Frink.Data.Length.UnitNames.bicron
    /// A synonim for yard
    [<Measure>] type yd = yard
    [<Measure>] type mm = millimeters

    [<Measure>] type ly = lightyear

    /// Convenient for describing molecular sizes
    [<Measure>] type angstrom

    /// Used for measuring wavelengths
    /// of X-rays.  It is defined to be
    /// 1/3029.45 of the spacing of calcite
    /// planes at 18 degC.  It was intended
    /// to be exactly 1e-13 m, but was
    /// later found to be off slightly.
    [<Measure>] type xunit = Frink.Data.Length.UnitNames.xunit
    /// An alias of xunit
    [<Measure>] type siegbahn = Frink.Data.Length.UnitNames.siegbahn

    /// Convenient for describing nuclear sizes
    /// Nuclear radius is from 1 to 10 fermis
    [<Measure>] type fermi = Frink.Data.Length.UnitNames.fermi

    /// Rarely used for astronomical measurements
    [<Measure>] type spat = Frink.Data.Length.UnitNames.spat

    [<Measure>] type inch = Frink.Data.Length.UnitNames.inch
    [<Measure>] type mile = Frink.Data.Length.UnitNames.mile

namespace Frink.Data.Length
    open Frink.Data.Length.UnitSymbols
    open Frink.Data.Length.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Time.UnitNames
    open Frink.Data.Constants

    module Helpers =
        open Frink.Data.Helper

        let metersPerMicron = 1e-6<m/micron>
        let micronsPerMeter = metersPerMicron |> reverse

        let metersPerBicrons = 1e-12<m/bicron>
        let bicronsPerMeters = metersPerBicrons |> reverse

        let metersPerAngstrom = 1e-10<m/angstrom>
        let angstromsPerMeters = metersPerAngstrom |> reverse

        let metersPerXunit = 1.00202e-13<m/xunit>
        let xunitsPerMeters = metersPerXunit |> reverse

        let metersPerFermis = 1e-15<m/fermi>
        let fermisPerMeters = metersPerFermis |> reverse

        let metersPerSpat = 1e12<m/spat>
        let spatsPerMeters = metersPerSpat |> reverse

        let cmPerInch = 2.54<cm/inch>
        let inchPerCm = cmPerInch |> reverse

        let inchPerFoot = 12.<inch/foot>
        let footPerInch = inchPerFoot |> reverse

        let ftPerYard = 3.<ft/yard>
        let yardsPerFt = ftPerYard |> reverse

        let ftPerMile = 5280.<ft/mile>
        let milesPerFt = ftPerMile |> reverse

        let kmPerLightyear = 9.4607e12<km/lightyear>
        let lightyearsPerKm = kmPerLightyear |> reverse

    module Constants =
        /// Ratio to give survey length
        let survey = (1200./3937.) *1.<m/ft>
        let geodetic = survey
        let statute = survey
        ///Convert US Survey measures to
        ///   international measures
        let int = (3937./1200.) * 1.<ft/m>

        let line = (1./12.) * 1.<inch>
        let rod = (11./2.)*survey*1.<yard>
        let rd = rod
        let perch = rod
        let furlong = 40.*rod
        let statutemile = statute * 1.<mile>
        let league = 3.*statutemile
