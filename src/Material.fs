namespace Frink.Data.Material.UnitNames
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Volume.UnitNames

    /// The SI unit of amount of substance (alias of F# unit name)
    [<Measure>] type mole = FSharp.Data.UnitSystems.SI.UnitNames.mole

    /// Viscosity
    [<Measure>] type poiseuille

    /// Unit of concentration (moles/liter)
    [<Measure>] type molar = mol / liter


    [<Measure>] type molal = mol / kg

namespace Frink.Data.Material.UnitSymbols
    open Microsoft.FSharp.Core
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Material.UnitNames

    /// The SI unit of amount of substance (alias of F# unit name)
    [<Measure>] type mole = FSharp.Data.UnitSystems.SI.UnitNames.mole

    /// Viscosity
    [<Measure>] type poiseuille = Frink.Data.Material.UnitNames.poiseuille

    /// Unit of concentration (moles/liter)
    [<Measure>] type molar = Frink.Data.Material.UnitNames.molar


    [<Measure>] type molal = Frink.Data.Material.UnitNames.molal


namespace Frink.Data.Material
    open Frink.Data.Material.UnitSymbols
    open Frink.Data.Material.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
    open Frink.Data.Mass.UnitSymbols
    open Frink.Data.Length.UnitSymbols

    // module Converters =

    /// Atomic mass unit is given by the 2018 CODATA value
    /// https://physics.nist.gov/cgi-bin/cuu/Value?u
    module PhysicoChemicalConstants =
        open Frink.Data.Constants

        // Density of mercury (defined)
        let Hg = 13.5951<g/cm^3>
        let mercurydensity = Hg

        // Standard density of water (defined)
        let water = 1.<g/cm^3>
        let H2O = water
        /// Water column
        let wc = water

        /// Atomic mass unit.
        /// Error is +/- 50 in last 2 digits
        /// (defined to be 1/12 of the mass of
        ///  carbon 12)
        let atomicmassunit = 1.66053906660e-27<kg>
        /// A synonim for atomic mass unit
        let m_u = atomicmassunit
        /// A synonim for atomic mass unit
        let u = atomicmassunit
        /// A synonim for atomic mass unit
        let amu = atomicmassunit

        /// 1/16 of the weighted average mass of
        /// the 3 naturally occurring neutral
        /// isotopes of oxygen
        let amu_chem = 1.66026e-27<kg>

        /// 1/16 of the mass of a neutral oxygen 16 atom
        let amu_phys = 1.65981e-27<kg>

        /// Maybe this should be amu_chem?
        let dalton = u

        /// Number of items in a mole
        /// Defined exactly by the SI
        /// rules that go into effect
        /// May 20, 2019
        ///  https://physics.nist.gov/cgi-bin/cuu/Value?na
        let avogadro = 6.02214076e23<mol^-1>

        /// A synonim for Avogadro constant
        let N_A = avogadro

        /// Boltzmann's constant.
        /// Defined exactly by the SI rules
        /// that go into effect May 20, 2019
        let boltzmann = 1.380649e-23<J/K>

        /// Boltzmann's constant
        let boltzmannsconstant = boltzmann
        /// A synonim for boltzmann contant
        let k = boltzmann

        /// Molar gas constant,
        /// Now exactly defined in terms
        /// of Avogadro's constant and
        /// Boltzmann's constant.
        /// https://physics.nist.gov/cgi-bin/cuu/Value?r
        let gasconstant = avogadro*k

        /// A synonim for gas constant
        let R = gasconstant

        /// Volume occupied by one mole of an
        ///   ideal gas at STP.  Units m^3/mol
        let molarvolume = (R*stdtemp) / atm
        /// A synonim of molarvolume
        let amagatvolume = molarvolume

        // Molecules per cubic meter of an
        // ideal gas at STP.  Loschmidt did
        // work similar to Avogadro.
        let loschmidt = avogadro / molarvolume

        /// Used to measure gas densities
        let amagat = loschmidt

        /// The radiant emittance by a
        /// blackbody
        /// at temperature T is given by
        /// sigma T^4.
        /// Exactly defined as of 2019 but since
        /// pi is transcendental, it doesn't
        /// have a finite representation.
        /// https://physics.nist.gov/cgi-bin/cuu/Value?sigma
        let stefanboltzmann = 5.670374419e-8<W m^-2 K^-4>
        /// A synonim for stefanboltzmann
        let sigma = stefanboltzmann

        // Wien's Displacement Law gives the
        //   frequency at which the the Planck
        //   spectrum has maximum intensity.
        //   The relation is lambda T = b where
        //   lambda is wavelength, T is
        //   temperature and b is the Wien
        //   displacement.  This relation is
        //   used to determine the temperature
        //   of stars.  This is the 2018
        //   CODATA value.  NIST claims this
        //   is exact, but they give an
        //   equation with a random
        //   unexplained, inexact, divisor,
        //   " b = (h c / k) / 4.965114231... "
        // https://physics.nist.gov/cgi-bin/cuu/Value?bwien
        let wiendisplacement = 2.897771955e-3<m K>

        /// Josephson Constant.
        /// Direct measurement of the volt is difficult.  Until
        ///   recently, laboratories kept Weston cadmium cells as
        ///   a reference, but they could drift.  In 1987 the
        ///   CGPM officially recommended the use of the
        ///   Josephson effect as a laboratory representation of
        ///   the volt.  The Josephson effect occurs when two
        ///   superconductors are separated by a thin insulating
        ///   layer.  A "supercurrent" flows across the insulator
        ///   with a frequency that depends on the potential
        ///   applied across the superconductors.  This frequency
        ///   can be very accurately measured.  The Josephson
        ///   constant K_J, which is equal to
        ///   2 elementarycharge/h, relates the
        ///   measured frequency to the potential.  From 1990 to
        ///   2019, the value of the Josephson constant was
        ///   specified as as exactly 4.835979ee+14 Hz/V .
        ///   The new 2019 SI redefinition caused it to be
        ///   changed to a slightly different (but exact
        ///   rational number value)  See:
        ///  https://physics.nist.gov/cgi-bin/cuu/Value?kjos
        let K_J = 2.*elementaryCharge/h

        /// A synonim for K_J
        let JosephsonConstant = K_J

        /// Measurement of the ohm also presents difficulties.
        ///   The old approach involved maintaining resistances
        ///   that were subject to drift.  The new standard is
        ///   based on the Hall effect.  When a current carrying
        ///   ribbon is placed in a magnetic field, a potential
        ///   difference develops across the ribbon.  The ratio
        ///   of the potential difference to the current is
        ///   called the Hall resistance.  Klaus von Klitzing
        ///   discovered in 1980 that the Hall resistance varies
        ///   in discrete jumps when the magnetic field is very
        ///   large and the temperature very low.  This enables
        ///   accurate realization of the resistance h/e^2 in the
        ///   lab.  From 1990 to 2019, this was defined as
        ///   exactly 25812.807 ohms.  The 2019 redefinition of
        ///   SI base units cause its definition to change to
        ///   another close but exact rational number in terms
        ///   of the exactly-defined h and elementarycharge.
        ///
        ///   You can see Klaus von Klitzing talk about this
        ///   discovery and its implications for the 2019
        ///   redefinition of the SI here:
        ///  https://www.youtube.com/watch?v=pMnxuA2ljwc
        let R_K = h/elementaryCharge*elementaryCharge

        // A synonim for R_K
        let vonKlitzingConstant = R_K

        // Masses of elementary particles, as given by 2018 CODATA-recommended values.
        // https://physics.nist.gov/cuu/Constants/index.html

        let electronmass =        9.1093837015e-31<kg> // +/- 28 in last 2 digits
        /// A synonim for electronmass. 2018 CODATA value.
        ///  https://physics.nist.gov/cgi-bin/cuu/Value?me
        let m_e =                 electronmass

        let protonmass =          1.67262192369e-27<kg>    // +/- 51 in last 2 digits
        /// A synonim for protonmass. 2018 CODATA value.
        ///  https://physics.nist.gov/cgi-bin/cuu/Value?mp
        let m_p =                 protonmass


        let neutronmass =         1.67492749804e-27<kg>    // +/- 95 in last 2 digits
        let m_n =                 neutronmass
                                 //  2018 CODATA value.
                                 //  https://physics.nist.gov/cgi-bin/cuu/Value?mn

        let muonmass =            1.883531627e-28<kg>    // +/- 42 in last 2 digits
        let m_mu =                muonmass
        let m_muon   =            muonmass
                                 //  2018 CODATA value.
                                 //  https://physics.nist.gov/cgi-bin/cuu/Value?mmu

        let deuteronmass =        3.3435837724e-27<kg>    // +/- 10 in last 2 digits
        let m_d =                 deuteronmass
                                 //  2018 CODATA value.
                                 //  https://physics.nist.gov/cgi-bin/cuu/Value?md

        let alphaparticlemass =   6.6446573357e-27<kg>     // +/- 20 in last 2 digits
        let m_alpha =             alphaparticlemass
                                 //  2018 CODATA value.
                                 //  https://physics.nist.gov/cgi-bin/cuu/Value?mal

        let taumass =             3.16754e-27<kg>       // +/- 21 in last 2 digits
        let m_tau   =             taumass
                                 //  2018 CODATA value.
                                 //  https://physics.nist.gov/cgi-bin/cuu/Value?mtau

        // Atomic constants

        let alpha =                elementaryCharge*elementaryCharge / (2.*epsilon0*h*speedOfLight)
                                // Can also be calculated as
                                //   mu0 c elementarycharge^2 / (2 h)
                                // or
                                //
                                // or, as NIST states,
                                //  elementarycharge^2 / (4 pi epsilon0 hbar c)
                                // 2018 CODATA value is 7.2973525693e-3
                                // https://physics.nist.gov/cgi-bin/cuu/Value?alph
                                // Standard uncertainty is +/- 11 in the last 2
                                // decimal places.
                                //
                                // The fine structure constant was
                                //   introduced to explain fine
                                //   structure visible in spectral
                                //   lines.
        let finestructureconstant =  alpha

        /// 2018 CODATA value is 10973731.568160 m^-1
        /// This can also be calculated as electronmass c alpha^2 / (2 h)
        /// There is some discrepancy between this calculated from constants
        /// and the CODATA value.
        /// https://physics.nist.gov/cgi-bin/cuu/Value?ryd
        /// The standard uncertainty is +/- 21 in the last 2 decimal places.
        let RydbergConstant = 10973731.568160<m^-1>

        /// A synonim for RydbergConstant
        let Rinfinity =           RydbergConstant

        /// The wavelengths of a spectral series
        ///   can be expressed as
        ///     1/lambda = R (1/m^2 - 1/n^2).
        ///   where R is a number that various
        ///   slightly from element to element.
        ///   For hydrogen, R_H is the value,
        ///   and for heavy elements, the value
        ///   approaches Rinfinity.
        let R_H = 10967760<m^-1>

        /// Bohr radius.
        /// This can also be calculated as
        ///   alpha / (4 pi Rinfinity)
        /// 2018 CODATA value, 5.29177210903e-11 m
        ///  There is some discrepancy between calculating this
        /// in terms of other constants and the CODATA value.
        /// uncertainty is +/- 80 in last
        /// 2 digits.
        /// https://physics.nist.gov/cgi-bin/cuu/Value?bohrrada0
        let bohrradius = hbar / (alpha*electronmass*c)

        // Planck constants

        let planckmass = sqrt(hbar*c / G)

        /// A synonim for plank mass
        let m_P = planckmass

        let plancktime =          hbar / (planckmass*c*c)
        /// A synonim for plank time
        let t_P =                 plancktime

        let plancklength =        plancktime*c
        /// A synonim for plank length
        let l_P =                 plancklength

        ///  This can also be calculated as
        ///  planckmass c^2 / k
        ///  which is also
        ///  (hbar c^5 / (G k^2))^(1/2)
        /// 2018 CODATA value gives this as
        /// 1.416785*10^32 K where the
        /// uncertainty is +/- 16 in the last 2
        /// digits.
        /// https://physics.nist.gov/cgi-bin/cuu/Value?plktmp
        let plancktemperature =  planckmass*c*c / k
        /// A synonim for plank temperature
        let T_P = plancktemperature


        // Particle wavelengths: the Compton wavelength of a particle is
        // defined as h / (m c) where m is the mass of the particle.

        let electronwavelength =  h / (m_e*c)
        let lambda_C =            electronwavelength
        let Comptonwavelength =   electronwavelength

        let protonwavelength =    h / (m_p*c)
        let lambda_C_p =          protonwavelength
        let neutronwavelength =   h / (m_n*c)
        let lambda_C_n =          neutronwavelength


        // Magnetic moments

        let bohrmagneton =        elementaryCharge*hbar / (2.*electronmass)
        let mu_B =                bohrmagneton
        let nuclearmagneton =     elementaryCharge*hbar / (2.*protonmass)
        let mu_N =                nuclearmagneton


        // Values below are from 2018 CODATA values

        let muonmagneticmoment = -4.49044830e-26<J/T>   // +/- 10 in last 2 digits
        /// https://physics.nist.gov/cgi-bin/cuu/Value?mumum
        let mu_mu = muonmagneticmoment

        let protonmagneticmoment = 1.41060679736e-26<J/T>  // +/- 60 in last 2 digits
        /// https://physics.nist.gov/cgi-bin/cuu/Value?mup
        let mu_p = protonmagneticmoment

        let electronmagneticmoment= -9.2847647043e-24<J/T> // +/- 28 in last 2 digits
        /// https://physics.nist.gov/cgi-bin/cuu/Value?muem
        let mu_e = electronmagneticmoment

        let neutronmagneticmoment = -9.6623651e-27<J/T> // +/- 23 in last 2 digits
        /// https://physics.nist.gov/cgi-bin/cuu/Value?munn
        let mu_n = neutronmagneticmoment

        let deuteronmagneticmoment = 4.330735094e-27<J/T> // +/- 11 in last 2 digits
        /// https://physics.nist.gov/cgi-bin/cuu/Value?mud
        let mu_d = deuteronmagneticmoment
