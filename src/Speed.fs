namespace Frink.Data.Speed.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    [<Measure>] type leo


namespace Frink.Data.Speed.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Speed.UnitNames

    [<Measure>] type leo = Frink.Data.Speed.UnitNames.leo

namespace Frink.Data.Speed
    open Frink.Data.Speed.UnitSymbols
    open Frink.Data.Speed.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    module Helpers =
        open Frink.Data.Helper

        let ``m/s^2PerLeo`` = 10.<(m/s^2)/leo>
        let ``leosPerM/s^2`` = ``m/s^2PerLeo`` |> reverse

    module Converters =
        open Helpers

        let ``m/s^2ToLeo`` (value : float<m/s^2>) = value / ``m/s^2PerLeo``
        let ``leoToM/s^2`` (value : float<leo>) = value / ``leosPerM/s^2``