namespace Frink.Data.Angle.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    [<Measure>] type radian
    [<Measure>] type circle
    [<Measure>] type cycle  = circle
    [<Measure>] type turn = circle
    [<Measure>] type revolution = circle
    [<Measure>] type rev = circle
    [<Measure>] type degree
    [<Measure>] type arcdegree
    [<Measure>] type arcminute
    [<Measure>] type arcsecond
    [<Measure>] type milliarcsecond
    [<Measure>] type pulsatance = radian / s
    [<Measure>] type steradian = radian^2

namespace Frink.Data.Angle.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Angle.UnitNames

    [<Measure>] type rad = radian
    [<Measure>] type circle = Frink.Data.Angle.UnitNames.circle
    [<Measure>] type cycle = Frink.Data.Angle.UnitNames.cycle
    [<Measure>] type turn = Frink.Data.Angle.UnitNames.turn
    [<Measure>] type rev = Frink.Data.Angle.UnitNames.rev
    [<Measure>] type deg = degree
    [<Measure>] type arcdeg = degree
    [<Measure>] type arcmin = arcminute
    [<Measure>] type arcsec = arcsecond
    [<Measure>] type mas = milliarcsecond
    [<Measure>] type pulsatance = radian / s
    [<Measure>] type sr = steradian


namespace Frink.Data.Angle
    open Frink.Data.Angle.UnitSymbols
    open Frink.Data.Angle.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Constants

    module Helpers =
        open Frink.Data.Helper

        let radiansPerCircle = 2.<radian/circle> * pi
        let circlesPerRadians = radiansPerCircle |> reverse

        let circlesPerDegree = 1.<circle/deg> / 360.
        let degreePerCircle = circlesPerDegree |> reverse

        let degreePerArcmin = 1.<deg/arcmin> / 60.
        let arcminPerDegree = degreePerArcmin |> reverse

        let arcminPerArcsec = 1.<arcmin/arcsec> / 60.
        let arcsecPerArcmin = arcminPerArcsec |> reverse

        let arcsecPerDegree = arcsecPerArcmin * arcminPerDegree
        let degreePerArcsec = degreePerArcmin * arcminPerArcsec

        let masPerArcsec = 1e-3<mas/arcsec>
        let arcsecPerMas = masPerArcsec |> reverse

    module Constants =
        let rightAngle = 90.<deg>
        let quadrant = 1.<circle> / 4.
        let quintant = 1.<circle> / 5.
        let sextant  = 1.<circle> / 6.

        /// Angular extent of one sign of the zodiac
        let sign     = 1.<circle> / 12.

        /// measure of grade
        let gon      = rightAngle / 100.
        let grade = gon
        let centesimalminute = grade / 100.
        let centesimalsecond = centesimalminute / 100.

        /// Official NIST definition.
        /// Another choice is 1ee-3 radian.
        let milangle = 1.<circle> / 6400.
        let pointangle = 1.<circle> / 32.

        /// Used for angular deviation of light
        /// through a prism.
        let centrad = 1.<radian> / 100.

        /// Binary radian--used to fit angular measurements into
        /// a byte.  Questionable but what the hell.
        let brad = 1.<circle> / 256.

        let sphere = 4.<sr> * pi
        let squaredegree = 1.<sr>*(1./180.**2.)*(pi**2.)
        let squareminute = (1./60.**2.)*squaredegree
        let squaresecond = (1./60.**2.)*squareminute
        let squarearcmin = squareminute
        let squarearcsec = squaresecond
        let sphericalrightangle = 0.5<sr>*pi
        let octant = 0.5<sr>*pi

        module Converters =
            open Helpers
            let radianToDegree (rad : float<radian>) = rad * (180./pi) * 1.<degree/radian>
            let degreeToRadian (deg : float<deg>) = deg * (pi/180.) * 1.<radian/deg>

            let circleToRadian (c : float<circle>) = c / circlesPerRadians
            let circleToDegree (c : float<circle>) = c / circlesPerDegree

            let degreeToCircle (deg : float<deg>) = deg / degreePerCircle
            let radianToCircle (rad : float<radian>) = rad / radiansPerCircle

            let degreeToArcmin (deg:float<deg>) = deg / degreePerArcmin
            let radianToArcmin = radianToDegree >> degreeToArcmin

            let arcminToDegree (arcm:float<arcmin>) = arcm / arcminPerDegree
            let arcminToRadian = arcminToDegree >> degreeToRadian

            let arcminToArcsec (arcm:float<arcmin>) = arcm / arcminPerArcsec
            let arcsecToArcmin (arcs:float<arcsec>) = arcs / arcsecPerArcmin
