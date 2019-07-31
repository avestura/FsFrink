namespace Frink.Data.Area.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    [<Measure>] type are

    /// Used to measure cross section for
    /// particle physics collision, said to
    /// have originated in the phrase "big as
    /// a barn".
    [<Measure>] type barn

    /// Defined to be a smaller companion to the
    ///  barn, but it's too small to be of
    ///   much use.
    [<Measure>] type shed

namespace Frink.Data.Area.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Area.UnitNames

    [<Measure>] type are = Frink.Data.Area.UnitNames.are

    /// Used to measure cross section for
    /// particle physics collision, said to
    /// have originated in the phrase "big as
    /// a barn".
    [<Measure>] type barn = Frink.Data.Area.UnitNames.barn

    /// Defined to be a smaller companion to the
    ///  barn, but it's too small to be of
    ///   much use.
    [<Measure>] type shed = Frink.Data.Area.UnitNames.shed


namespace Frink.Data.Area
    open Frink.Data.Area.UnitSymbols
    open Frink.Data.Area.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let m2sPerAre = 100.<m^2/are>
        let aresPerM2 = m2sPerAre |> reverse

        let m2sPerBarn = 1e-28<m^2/barn>
        let barnsPerM2 = m2sPerBarn |> reverse

        let barnsPerShed = 1e-24<barn/shed>
        let shedsPerBarn = barnsPerShed |> reverse

