# FsFrink
An effort to bring [frinklang.org](https://frinklang.org) UoMs into F# ecosystem

## Adding UoMs
Add UoM in `Frink.Data.{Category}.UnitNames`, then the symbol form in `Frink.Data.{Category}.UnitSymbols` namespace.
If there is no symbol for that UoM, add the unit name in unit symbols namespace and alias it to the correct type. Like:

```fsharp
namespace Frink.Data.Volume.UnitSymbols
  [<Measure>] type lambda = Frink.Data.Volume.UnitNames.lambda
```
