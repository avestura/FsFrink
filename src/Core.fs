namespace Frink.Data

module Helper =
    let inline reverse (item : float<'u>) = 1. / item

module MetricSystem =
    let yotta = 1e24                      // 1E24 Greek or Latin octo, "eight"
    let zetta = 1e21                      // 1E21 Latin septem, "seven"
    let exa   = 1e18                      // 1E18 Greek hex, "six"
    let peta  = 1e15                      // 1E15 Greek pente, "five"
    let tera  = 1e12                      // 1E12 Greek teras, "monster"
    let giga  = 1e9                       // 1E9  Greek gigas, "giant"
    let mega  = 1e6                       // 1E6  Greek megas, "large"
    let myria = 1e4                       // 1E4  Not an official SI prefix
    let kilo  = 1000                       // 1E3  Greek chilioi, "thousand"
    let hecto = 100                        // 1E2  Greek hekaton, "hundred"
    let deca  = 10                         // 1E1  Greek deka, "ten"
    let deka  = 10
    let deci  = 1/10                       // 1E-1 Latin decimus, "tenth"
    let centi = 1/100                      // 1E-2 Latin centum, "hundred"
    let milli = 1/1000                     // 1E-3 Latin mille, "thousand"
    let micro = 1e-6                      // 1E-6 Latin micro/Greek mikros,"small"
    let nano  = 1e-9                      // 1E-9 Latin nanus or Greek nanos,"dwarf"
    let pico  = 1e-12                     // 1E-12 Spanish pico, "a bit"
    let femto = 1e-15                     // 1E-15 Danish-Norwegian femten,"fifteen"
    let atto  = 1e-18                     // 1E-18 Danish-Norwegian atten,"eighteen"
    let zepto = 1e-21                     // 1E-21 Latin septem, "seven"
    let yocto = 1e-24                     // 1E-24 Greek or Latin octo, "eight"

    let unit = 1
    let semi = 1/2
    let demi = 1/2
    let hemi = 1/2
    let half = 1/2
    let third  = 1/3
    let quarter = 1/4
    let eighth = 1/8

    let uni = 1
    let bi  = 2
    let tri = 3

    let hundred =             100
    let thousand =            1000
    let million =             1e6
    let billion =             1e9
    let trillion =            1e12
    let quadrillion =         1e15
    let quintillion =         1e18
    let sextillion =          1e21
    let septillion =          1e24
    let octillion =           1e27
    let nonillion =           1e30
    let noventillion =        nonillion
    let decillion =           1e33
    let undecillion =         1e36
    let duodecillion =        1e39
    let tredecillion =        1e42
    let quattuordecillion =   1e45
    let quindecillion =       1e48
    let sexdecillion =        1e51
    let septendecillion =     1e54
    let octodecillion =       1e57
    let novemdecillion =      1e60
    let vigintillion =        1e63
    let centillion =          1e303

    let googol =              1e100

    // These number terms were described by N. Chuquet and De la Roche in the 16th
    // century as being successive powers of a million.  These definitions are
    // still used in most European countries.  The current US definitions for these
    // numbers arose in the 17th century and don't make nearly as much sense.
    // These numbers are listed in the CRC Concise Encyclopedia of Mathematics by
    // Eric W. Weisstein.
    let brbillion =           million**2.
    let brtrillion =          million**3.
    let brquadrillion =       million**4.
    let brquintillion =       million**5.
    let brsextillion =        million**6.
    let brseptillion =        million**7.
    let broctillion =         million**8.
    let brnonillion =         million**9.
    let brnoventillion =      brnonillion
    let brdecillion =         million**10.
    let brundecillion =       million**11.
    let brduodecillion =      million**12.
    let brtredecillion =      million**13.
    let brquattuordecillion = million**14.
    let brquindecillion =     million**15.
    let brsexdecillion =      million**16.
    let brseptdecillion =     million**17.
    let broctodecillion =     million**18.
    let brnovemdecillion =    million**19.
    let brvigintillion =      million**20.

    // These numbers fill the gaps left by the European system above.

    let milliard =            1000.*million
    let billiard =            1000.*million**2.
    let trilliard =           1000.*million**3.
    let quadrilliard =        1000.*million**4.
    let quintilliard =        1000.*million**5.
    let sextilliard =         1000.*million**6.
    let septilliard =         1000.*million**7.
    let octilliard =          1000.*million**8.
    let nonilliard =          1000.*million**9.
    let noventilliard =       nonilliard
    let decilliard =          1000.*million**10.

    // For consistency

    let brmilliard =          milliard
    let brbilliard =          billiard
    let brtrilliard =         trilliard
    let brquadrilliard =      quadrilliard
    let brquintilliard =      quintilliard
    let brsextilliard =       sextilliard
    let brseptilliard =       septilliard
    let broctilliard =        octilliard
    let brnonilliard =        nonilliard
    let brnoventilliard =     noventilliard
    let brdecilliard =        decilliard

    // The British Centillion would be 1ee600.  The googolplex is another
    // familiar large number equal to 10^googol.


    // Indian dimensionless numbers (used in English)
    // See: https://en.wikipedia.org/wiki/Indian_Numbering_System
    let lakh  = 100*thousand
    let lac   = lakh
    let crore = 10.*million

    let percent  =             1./100.

    /// Alcohol content measured by volume at
    /// 60 degrees Fahrenheit.  This is a USA
    /// measure. In Europe proof=percent.
    let proof  =               1./200.
    let ppm  =                 1e-6
    let partspermillion  =     ppm
    let ppb  =                 1e-9
    let partsperbillion  =     ppb
    let ppt  =                 1e-12
    let partspertrillion  =    ppt

    /// Measure of gold purity
    let karat  =               1./24.

    /// Measure of gold purity
    let fine  =                1./1000.
    let caratgold  =           karat

    /// Used in finance
    let basispoint  =          (1./100.)*percent


module Constants =
    open FSharp.Data.UnitSystems.SI.UnitSymbols

    /// A synonim for System.Math.PI
    let pi = System.Math.PI

    /// Base of natural logarithm
    /// 'e' was previously used to be
    /// the charge of the electron, but
    /// changed to this.  Mathematicians and
    /// particle physicists may battle this
    /// out.
    let e  = System.Math.E

    /// See http://en.wikipedia.org/wiki/Euler-Mascheroni_constant
    let eulerMascheroniConstant = 0.577215664901532860606512090082402431042159335939923598805767234884867726777664670936947063291746749

    /// speed of light in vacuum (exact)
    /// The speed of light is the same to
    /// all observers in all local frames.
    /// The relation between the meter and
    /// the second is thus fixed by this
    /// definition.  This is good.
    let speedOfLight = 299792458.<m/s>

    /// A synonim for speedOfLight
    let c = speedOfLight

    /// permeability of vacuum
    /// 2018 CODATA value after 2019 redefinition of SI base
    /// units.  Uncertainty is +/- 19 in the last 2 digits.
    ///
    ///  https://physics.nist.gov/cgi-bin/cuu/Value?eqmu0
    ///
    /// Before the 2019 SI redefinition,
    /// mu0 was a defined "exact" constant (but without a
    /// finite decimal representation because pi is
    /// transcendental) with the exact defining value:
    ///   4 pi 1ee-7 N/A^2
    ///
    ///  The value of the ampere and other electrical units
    /// were indirectly defined through this definition.
    ///
    /// After the redefinition, it now is an "experimentally
    /// determined" value with an uncertainty.
    /// It can be written in terms of other units as:
    ///  mu0  = 4 pi alpha hbar / (elementarycharge^2 c)
    /// or
    ///  mu0  = 2 alpha h / (elementarycharge^2 c)
    let mu0 = 1.25663706212e-6<N/A^2>

    /// permittivity of vacuum
    /// This is the 2018 CODATA value after 2019 redefinition
    /// of SI base units.  Uncertainty is +/- 13 in the last
    /// 2 digits.
    ///  https://physics.nist.gov/cgi-bin/cuu/Value?eqep0
    ///
    /// Before the 2019 SI redefinition, epsilon0 was defined
    /// in terms of the "exact" definitions of mu0 and c,
    /// with the relation
    ///   epsilon0  = 1/(mu0 c^2)
    ///
    /// After the 2019 SI redefinition, it is now an inexact
    /// "experimentally determined" value with an uncertainty.
    let epsilon0 = 8.8541878128e-12<F/m>

    /// A synonim for epsilon0
    let permittivityOfVacuum = epsilon0
    /// A synonim for epsilon0
    let electricConstant = epsilon0

    /// listed as "k_e" or sometimes "k"
    /// The repulsive electric force
    /// between two charged pointlike
    /// particles is:
    /// coulombconst q1 q2 / dist^2
    let coulombConst = 1./(4. * pi * epsilon0)
    /// An alis of coulombConst
    let k_e = coulombConst

    /// Characteristic impedance of vacuum
    let Z0 = mu0 * speedOfLight
    /// A synonim for Z0
    let impedanceOfVacuum = Z0

    /// Characteristic admittance of vacuum
    let Y0 = 1./(mu0 * speedOfLight)
    /// A synonim for Y0
    let admittanceofvacuum = Y0

    /// Convert mass to energy
    let energy = speedOfLight * speedOfLight

    /// Defined exactly by the SI rules
    /// that take effect on May 20, 2019
    /// https://physics.nist.gov/cgi-bin/cuu/Value?e
    /// also called "e"
    /// but that's reserved for the
    /// base of the natural logarithm.
    let elementaryCharge =  1.602176634e-19<C>

    let electroncharge  =         - elementaryCharge
    let protoncharge    =         + elementaryCharge
    let neutroncharge   =      0. * elementaryCharge
    let upquarkcharge   =  +2./3. * elementaryCharge
    let downquarkcharge =  -1./3. * elementaryCharge

    /// Planck's constant, exactly
    /// defined by the SI rules that take effect
    /// on May 20, 2019.
    /// https://physics.nist.gov/cgi-bin/cuu/Value?h
    ///
    /// As h is now exactly defined, as are the speed
    /// of light c, and the length of the meter m,
    /// this makes the definition of the kilogram
    /// no longer exactly-defined, but
    /// an experimentally-measured value.
    ///
    ///
    /// You can see Jean-Phillipe Uzan talk about the
    /// role of Planck's constant in physics as it
    /// relates to the 2019 SI redefinitions here:
    /// https://www.youtube.com/watch?v=yhgb23tAFFs
    let h = 6.62607015e-34<J s>
    /// A synonim for h
    let plancksconstant = h
    /// A synonim for h
    let hbar = h

    /// 2018 CODATA value
    /// https://physics.nist.gov/cgi-bin/cuu/Value?re
    /// uncertainty is +/- 13 in the last 2 digits
    let classicalElectronRadius = 2.8179403262e-15<m>
    /// A synonim for classicalElectronRadius
    let r_E = classicalElectronRadius

    /// 2018 CODATA value
    /// https://physics.nist.gov/cgi-bin/cuu/Value?sigmae
    /// The "classical" cross-section of an electron when
    /// illuminated by radiation.
    /// Uncertainty is +/- 60 in the last 2 digits.
    let thomsonCrossSection = 6.6524587321e-29<m^2>
    /// A synonim for thomsonCrossSection
    let sigma_e = thomsonCrossSection
    /// A synonim for thomsonCrossSection
    let sigma_t = thomsonCrossSection

    /// Newtonian gravity constant
    /// From 2018 CODATA figures.  There is a standard uncertainty in the
    /// last two figures of +/- 15.  The uncertainty decreased from 31
    /// from the 2014 value.
    /// Given by https://physics.nist.gov/cgi-bin/cuu/Value?bg
    /// The gravitational force between the centers of two (spherelike)
    /// bodies is:
    /// G mass1 mass2 / dist^2
    let G = 6.67430e-11<N m^2 / kg^2>

    /// A synonim for G
    let gravitationalconstant = G

    /// astronomical unit, approximately
    /// the average radius of earth's orbit
    /// around the sun.
    let au = 149597870700.<m>

    /// The SI defines "ua" as the international symbol
    /// for the astronomical unit, but the IAU recommends
    /// that "au" be used.  See 2012 resolution B2 here:
    /// http://www.iau.org/static/resolutions/IAU2012_English.pdf
    let ua = au

    // A synonim for au
    let astronomicalunit = au

    /// Standard acceleration of gravity
    /// (exact)
    /// see https://physics.nist.gov/cgi-bin/cuu/Value?gn
    let gravity = (980665./100000.) * 1.<m/s^2>
    /// A synonim for gravity
    let g_n = gravity
    /// A synonim for gravity
    let gee = gravity
    /// A synonim for gravity
    let gravities = gravity
    /// A synonim for gravity
    let force = gravity

    // Standard atmospheric pressure (exact)
    // See https://physics.nist.gov/cgi-bin/cuu/Value?stdatm
    let atm = 101325.<Pa>

    /// Speed of sound in dry air at STP
    let mach =                331.46<m/s>
    /// Standard temperature, exactly defined
    let standardtemp =        273.15<K>
    let stdtemp =             standardtemp
