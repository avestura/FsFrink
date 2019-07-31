namespace Frink.Data.Time.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

    /// The SI unit of time (alias of F# unit name)
    [<Measure>] type second = FSharp.Data.UnitSystems.SI.UnitNames.second
    [<Measure>] type minute
    [<Measure>] type hour
    [<Measure>] type day
    [<Measure>] type week
    [<Measure>] type sennight
    [<Measure>] type fortnight
    /// Actual human blink takes 1/3 second
    [<Measure>] type blink
    [<Measure>] type ce
    [<Measure>] type shake
    /// Used for measuring the sedimentation
    /// coefficient for centrifuging.
    [<Measure>] type svedberg



namespace Frink.Data.Time.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Time.UnitNames

    [<Measure>] type sec = s
    [<Measure>] type min = minute
    [<Measure>] type hr = hour
    [<Measure>] type d = day
    [<Measure>] type wk = week
    [<Measure>] type sennight = Frink.Data.Time.UnitNames.sennight
    [<Measure>] type fortnight = Frink.Data.Time.UnitNames.fortnight
    /// Actual human blink takes 1/3 second
    [<Measure>] type blink = Frink.Data.Time.UnitNames.blink
    [<Measure>] type ce = Frink.Data.Time.UnitNames.ce
    [<Measure>] type shake = Frink.Data.Time.UnitNames.shake
    /// Used for measuring the sedimentation
    /// coefficient for centrifuging.
    [<Measure>] type svedberg = Frink.Data.Time.UnitNames.svedberg


namespace Frink.Data.Time
    open Frink.Data.Time.UnitNames
    open Frink.Data.Time.UnitSymbols
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Constants =
        open Frink.Data.Constants
        open Frink.Data.Angle.UnitNames
        /// The cesium frequency which defines
        /// the second:  The unperturbed ground-state
        /// hyperfine transition frequency of the caesium
        /// 133 atom
        let cesiumFrequency = 9192631770L<s^-1>
        let lightSeconds = c*1.<s>
        let lightMinutes = 60. * lightSeconds

        /// Unit of length equal to distance
        ///   from the sun to a point having
        ///   heliocentric parallax of 1
        ///   arcsec (derived from parallax
        ///   second) The formula should use
        ///   tangent, but the error is about
        ///   1e-12.
        let parsec = au * 1.<radian> / 1.<arcsecond>
        let pc = parsec

    module Helpers =
        open Frink.Data.Helper

        let secondsPerMin    = 60.<s/min>
        let minsPerSecond    = secondsPerMin |> reverse

        let minsPerHour      = 60.<min/hr>
        let hoursPerMin      = minsPerHour |> reverse

        let hoursPerDay      = 24.<hr/day>
        let daysPerHour      = hoursPerDay |> reverse

        let daysPerWeek      = 7.<day/week>
        let weeksPerDay      = daysPerWeek |> reverse

        let daysPerSennight  = 7.<day/sennight>
        let sennightPerDay   = daysPerSennight |> reverse

        let daysPerFortnight = 14.<day/fortnight>
        let fortnightPerDay  = daysPerFortnight |> reverse

        let daysPerBlink     = 1e-5<day/blink>
        let blinksPerDay     = daysPerBlink |> reverse

        let daysPerCe        = 1e-2<day/ce>
        let cePerDay         = daysPerCe |> reverse

        let secondsPerShake  = 1e-8<s/shake>
        let shakesPerSeconds = secondsPerShake |> reverse

    module Converters =
        open Helpers
        let minsToSeconds (mins : float<min>) = mins / minsPerSecond
        let secondsToMins (secs : float<s>) =  secs / secondsPerMin

        let hoursToMins (hours:float<hr>) = hours / hoursPerMin
        let minsToHours (mins:float<min>) = mins / minsPerHour
        let hoursToSeconds = hoursToMins >> minsToSeconds
        let secondsToHours = secondsToMins >> minsToHours




