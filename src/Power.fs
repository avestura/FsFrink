namespace Frink.Data.Power.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    /// The SI unit of power, radiant flux (alias of F# unit name)
    [<Measure>] type watt = FSharp.Data.UnitSystems.SI.UnitNames.watt


namespace Frink.Data.Power.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Power.UnitNames

    /// A synonym for watt, the SI unit of power, radiant flux
    [<Measure>] type W = watt

namespace Frink.Data.Power
    open Frink.Data.Power.UnitSymbols
    open Frink.Data.Power.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    // module Converters =
