using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Atomizer
{
    public static class ElementDatabase
    {
        public static Dictionary<Type, List<Type>> ClassificatonTrees;
        public static void InitializeLists()
        {
            ClassificatonTrees = new Dictionary<Type, List<Type>>();
            foreach (Type type in ElementDatabase.Classifications)
            {
                List<Type> types = new List<Type>();
                for (Type thisType = type; thisType != typeof(Element); thisType = thisType.BaseType)
                    types.Add(thisType);
                ClassificatonTrees.Add(type, types);
            }
        }

        public static List<Type> Classifications = new List<Type>()
        {
            typeof(Metal),
            typeof(AlkaliMetal),
            typeof(AlkalineEarthMetal),
            typeof(RareEarthMetal),
            typeof(Lanthanide),
            typeof(Actinide),
            typeof(CoinageMetal),
            typeof(VolatileMetal),
            typeof(TransitionMetal),
            typeof(PostTransitionMetal),
            typeof(Metalloid),
            typeof(NonMetal),
            typeof(OtherNonMetal),
            typeof(Halogen),
            typeof(NobleGas),
        };

        #region Perl Generated Code
        public static readonly OtherNonMetal Hydrogen = new OtherNonMetal(AtomicMass: "1.008", AtomicNumber: 1, Classification: "OtherNonMetal", Symbol: "H", Name: "Hydrogen");
        public static readonly NobleGas Helium = new NobleGas(AtomicMass: "4.002602", AtomicNumber: 2, Classification: "NobleGas", Symbol: "He", Name: "Helium");
        public static readonly AlkaliMetal Lithium = new AlkaliMetal(AtomicMass: "6.94", AtomicNumber: 3, Classification: "AlkaliMetal", Symbol: "Li", Name: "Lithium");
        public static readonly AlkalineEarthMetal Beryllium = new AlkalineEarthMetal(AtomicMass: "9.012182", AtomicNumber: 4, Classification: "AlkalineEarthMetal", Symbol: "Be", Name: "Beryllium");
        public static readonly Metalloid Boron = new Metalloid(AtomicMass: "10.811", AtomicNumber: 5, Classification: "Metalloid", Symbol: "B", Name: "Boron");
        public static readonly OtherNonMetal Carbon = new OtherNonMetal(AtomicMass: "12.011", AtomicNumber: 6, Classification: "OtherNonMetal", Symbol: "C", Name: "Carbon");
        public static readonly OtherNonMetal Nitrogen = new OtherNonMetal(AtomicMass: "14.00674", AtomicNumber: 7, Classification: "OtherNonMetal", Symbol: "N", Name: "Nitrogen");
        public static readonly OtherNonMetal Oxygen = new OtherNonMetal(AtomicMass: "15.999", AtomicNumber: 8, Classification: "OtherNonMetal", Symbol: "O", Name: "Oxygen");
        public static readonly Halogen Fluorine = new Halogen(AtomicMass: "18.998403", AtomicNumber: 9, Classification: "Halogen", Symbol: "F", Name: "Fluorine");
        public static readonly NobleGas Neon = new NobleGas(AtomicMass: "20.1797", AtomicNumber: 10, Classification: "NobleGas", Symbol: "Ne", Name: "Neon");
        public static readonly AlkaliMetal Sodium = new AlkaliMetal(AtomicMass: "22.98976928", AtomicNumber: 11, Classification: "AlkaliMetal", Symbol: "Na", Name: "Sodium");
        public static readonly AlkalineEarthMetal Magnesium = new AlkalineEarthMetal(AtomicMass: "24.305", AtomicNumber: 12, Classification: "AlkalineEarthMetal", Symbol: "Mg", Name: "Magnesium");
        public static readonly PostTransitionMetal Aluminium = new PostTransitionMetal(AtomicMass: "26.9815386", AtomicNumber: 13, Classification: "PostTransitionMetal", Symbol: "Al", Name: "Aluminium");
        public static readonly Metalloid Silicone = new Metalloid(AtomicMass: "28.085", AtomicNumber: 14, Classification: "Metalloid", Symbol: "Si", Name: "Silicone");
        public static readonly OtherNonMetal Phosphorus = new OtherNonMetal(AtomicMass: "30.973762", AtomicNumber: 15, Classification: "OtherNonMetal", Symbol: "P", Name: "Phosphorus");
        public static readonly OtherNonMetal Sulfur = new OtherNonMetal(AtomicMass: "32.06", AtomicNumber: 16, Classification: "OtherNonMetal", Symbol: "S", Name: "Sulfur");
        public static readonly Halogen Chlorine = new Halogen(AtomicMass: "35.45", AtomicNumber: 17, Classification: "Halogen", Symbol: "Cl", Name: "Chlorine");
        public static readonly NobleGas Argon = new NobleGas(AtomicMass: "39.948", AtomicNumber: 18, Classification: "NobleGas", Symbol: "Ar", Name: "Argon");
        public static readonly AlkaliMetal Potassium = new AlkaliMetal(AtomicMass: "39.0983", AtomicNumber: 19, Classification: "AlkaliMetal", Symbol: "K", Name: "Potassium");
        public static readonly AlkalineEarthMetal Calcium = new AlkalineEarthMetal(AtomicMass: "40.078", AtomicNumber: 20, Classification: "AlkalineEarthMetal", Symbol: "Ca", Name: "Calcium");
        public static readonly TransitionMetal Scandium = new TransitionMetal(AtomicMass: "44.955910", AtomicNumber: 21, Classification: "TransitionMetal", Symbol: "Sc", Name: "Scandium");
        public static readonly TransitionMetal Titanium = new TransitionMetal(AtomicMass: "47.867", AtomicNumber: 22, Classification: "TransitionMetal", Symbol: "Ti", Name: "Titanium");
        public static readonly TransitionMetal Vanadium = new TransitionMetal(AtomicMass: "50.9415", AtomicNumber: 23, Classification: "TransitionMetal", Symbol: "V", Name: "Vanadium");
        public static readonly TransitionMetal Chromium = new TransitionMetal(AtomicMass: "51.9961", AtomicNumber: 24, Classification: "TransitionMetal", Symbol: "Cr", Name: "Chromium");
        public static readonly TransitionMetal Manganese = new TransitionMetal(AtomicMass: "54.938049", AtomicNumber: 25, Classification: "TransitionMetal", Symbol: "Mn", Name: "Manganese");
        public static readonly TransitionMetal Iron = new TransitionMetal(AtomicMass: "55.845", AtomicNumber: 26, Classification: "TransitionMetal", Symbol: "Fe", Name: "Iron");
        public static readonly TransitionMetal Cobalt = new TransitionMetal(AtomicMass: "58.933200", AtomicNumber: 27, Classification: "TransitionMetal", Symbol: "Co", Name: "Cobalt");
        public static readonly TransitionMetal Nickel = new TransitionMetal(AtomicMass: "58.6934", AtomicNumber: 28, Classification: "TransitionMetal", Symbol: "Ni", Name: "Nickel");
        public static readonly CoinageMetal Copper = new CoinageMetal(AtomicMass: "63.546", AtomicNumber: 29, Classification: "CoinageMetal", Symbol: "Cu", Name: "Copper");
        public static readonly VolatileMetal Zinc = new VolatileMetal(AtomicMass: "65.39", AtomicNumber: 30, Classification: "VolatileMetal", Symbol: "Zn", Name: "Zinc");
        public static readonly PostTransitionMetal Gallium = new PostTransitionMetal(AtomicMass: "69.723", AtomicNumber: 31, Classification: "PostTransitionMetal", Symbol: "Ga", Name: "Gallium");
        public static readonly Metalloid Germanium = new Metalloid(AtomicMass: "72.61", AtomicNumber: 32, Classification: "Metalloid", Symbol: "Ge", Name: "Germanium");
        public static readonly Metalloid Arsenic = new Metalloid(AtomicMass: "74.92160", AtomicNumber: 33, Classification: "Metalloid", Symbol: "As", Name: "Arsenic");
        public static readonly OtherNonMetal Selenium = new OtherNonMetal(AtomicMass: "78.96", AtomicNumber: 34, Classification: "OtherNonMetal", Symbol: "Se", Name: "Selenium");
        public static readonly Halogen Bromine = new Halogen(AtomicMass: "79.904", AtomicNumber: 35, Classification: "Halogen", Symbol: "Br", Name: "Bromine");
        public static readonly NobleGas Krypton = new NobleGas(AtomicMass: "83.80", AtomicNumber: 36, Classification: "NobleGas", Symbol: "Kr", Name: "Krypton");
        public static readonly AlkaliMetal Rubidium = new AlkaliMetal(AtomicMass: "85.4678", AtomicNumber: 37, Classification: "AlkaliMetal", Symbol: "Rb", Name: "Rubidium");
        public static readonly AlkalineEarthMetal Strontium = new AlkalineEarthMetal(AtomicMass: "87.62", AtomicNumber: 38, Classification: "AlkalineEarthMetal", Symbol: "Sr", Name: "Strontium");
        public static readonly TransitionMetal Yttrium = new TransitionMetal(AtomicMass: "88.90585", AtomicNumber: 39, Classification: "TransitionMetal", Symbol: "Y", Name: "Yttrium");
        public static readonly TransitionMetal Zirconium = new TransitionMetal(AtomicMass: "91.224", AtomicNumber: 40, Classification: "TransitionMetal", Symbol: "Zr", Name: "Zirconium");
        public static readonly TransitionMetal Niobium = new TransitionMetal(AtomicMass: "92.90638", AtomicNumber: 41, Classification: "TransitionMetal", Symbol: "Nb", Name: "Niobium");
        public static readonly TransitionMetal Molybdenum = new TransitionMetal(AtomicMass: "95.94", AtomicNumber: 42, Classification: "TransitionMetal", Symbol: "Mo", Name: "Molybdenum");
        public static readonly TransitionMetal Technetium = new TransitionMetal(AtomicMass: "(98)", AtomicNumber: 43, Classification: "TransitionMetal", Symbol: "Tc", Name: "Technetium");
        public static readonly TransitionMetal Ruthenium = new TransitionMetal(AtomicMass: "101.07", AtomicNumber: 44, Classification: "TransitionMetal", Symbol: "Ru", Name: "Ruthenium");
        public static readonly TransitionMetal Rhodium = new TransitionMetal(AtomicMass: "102.90550", AtomicNumber: 45, Classification: "TransitionMetal", Symbol: "Rh", Name: "Rhodium");
        public static readonly TransitionMetal Palladium = new TransitionMetal(AtomicMass: "106.42", AtomicNumber: 46, Classification: "TransitionMetal", Symbol: "Pd", Name: "Palladium");
        public static readonly CoinageMetal Silver = new CoinageMetal(AtomicMass: "107.8682", AtomicNumber: 47, Classification: "CoinageMetal", Symbol: "Ag", Name: "Silver");
        public static readonly VolatileMetal Cadmium = new VolatileMetal(AtomicMass: "112.411", AtomicNumber: 48, Classification: "VolatileMetal", Symbol: "Cd", Name: "Cadmium");
        public static readonly PostTransitionMetal Indium = new PostTransitionMetal(AtomicMass: "114.818", AtomicNumber: 49, Classification: "PostTransitionMetal", Symbol: "In", Name: "Indium");
        public static readonly PostTransitionMetal Tin = new PostTransitionMetal(AtomicMass: "118.710", AtomicNumber: 50, Classification: "PostTransitionMetal", Symbol: "Sn", Name: "Tin");
        public static readonly Metalloid Antimony = new Metalloid(AtomicMass: "121.760", AtomicNumber: 51, Classification: "Metalloid", Symbol: "Sb", Name: "Antimony");
        public static readonly Metalloid Tellurium = new Metalloid(AtomicMass: "127.60", AtomicNumber: 52, Classification: "Metalloid", Symbol: "Te", Name: "Tellurium");
        public static readonly Halogen Iodine = new Halogen(AtomicMass: "126.90447", AtomicNumber: 53, Classification: "Halogen", Symbol: "I", Name: "Iodine");
        public static readonly NobleGas Xenon = new NobleGas(AtomicMass: "131.29", AtomicNumber: 54, Classification: "NobleGas", Symbol: "Xe", Name: "Xenon");
        public static readonly AlkaliMetal Cesium = new AlkaliMetal(AtomicMass: "132.90545", AtomicNumber: 55, Classification: "AlkaliMetal", Symbol: "Cs", Name: "Cesium");
        public static readonly AlkalineEarthMetal Barium = new AlkalineEarthMetal(AtomicMass: "137.327", AtomicNumber: 56, Classification: "AlkalineEarthMetal", Symbol: "Ba", Name: "Barium");
        public static readonly Lanthanide Lanthanum = new Lanthanide(AtomicMass: "138.9055", AtomicNumber: 57, Classification: "Lanthanide", Symbol: "La", Name: "Lanthanum");
        public static readonly Lanthanide Cerium = new Lanthanide(AtomicMass: "140.116", AtomicNumber: 58, Classification: "Lanthanide", Symbol: "Ce", Name: "Cerium");
        public static readonly Lanthanide Praseodymium = new Lanthanide(AtomicMass: "140.90765", AtomicNumber: 59, Classification: "Lanthanide", Symbol: "Pr", Name: "Praseodymium");
        public static readonly Lanthanide Neodymium = new Lanthanide(AtomicMass: "144.24", AtomicNumber: 60, Classification: "Lanthanide", Symbol: "Nd", Name: "Neodymium");
        public static readonly Lanthanide Promethium = new Lanthanide(AtomicMass: "(145)", AtomicNumber: 61, Classification: "Lanthanide", Symbol: "Pm", Name: "Promethium");
        public static readonly Lanthanide Samarium = new Lanthanide(AtomicMass: "150.36", AtomicNumber: 62, Classification: "Lanthanide", Symbol: "Sm", Name: "Samarium");
        public static readonly Lanthanide Europium = new Lanthanide(AtomicMass: "151.964", AtomicNumber: 63, Classification: "Lanthanide", Symbol: "Eu", Name: "Europium");
        public static readonly Lanthanide Gadolinium = new Lanthanide(AtomicMass: "157.25", AtomicNumber: 64, Classification: "Lanthanide", Symbol: "Gd", Name: "Gadolinium");
        public static readonly Lanthanide Terbium = new Lanthanide(AtomicMass: "158.92535", AtomicNumber: 65, Classification: "Lanthanide", Symbol: "Tb", Name: "Terbium");
        public static readonly Lanthanide Dysprosium = new Lanthanide(AtomicMass: "162.50", AtomicNumber: 66, Classification: "Lanthanide", Symbol: "Dy", Name: "Dysprosium");
        public static readonly Lanthanide Holmium = new Lanthanide(AtomicMass: "164.93032", AtomicNumber: 67, Classification: "Lanthanide", Symbol: "Ho", Name: "Holmium");
        public static readonly Lanthanide Erbium = new Lanthanide(AtomicMass: "167.26", AtomicNumber: 68, Classification: "Lanthanide", Symbol: "Er", Name: "Erbium");
        public static readonly Lanthanide Thulium = new Lanthanide(AtomicMass: "168.93421", AtomicNumber: 69, Classification: "Lanthanide", Symbol: "Tm", Name: "Thulium");
        public static readonly Lanthanide Ytterbium = new Lanthanide(AtomicMass: "173.04", AtomicNumber: 70, Classification: "Lanthanide", Symbol: "Yb", Name: "Ytterbium");
        public static readonly Lanthanide Lutetium = new Lanthanide(AtomicMass: "174.967", AtomicNumber: 71, Classification: "Lanthanide", Symbol: "Lu", Name: "Lutetium");
        public static readonly TransitionMetal Hafnium = new TransitionMetal(AtomicMass: "178.49", AtomicNumber: 72, Classification: "TransitionMetal", Symbol: "Hf", Name: "Hafnium");
        public static readonly TransitionMetal Tantalum = new TransitionMetal(AtomicMass: "180.9479", AtomicNumber: 73, Classification: "TransitionMetal", Symbol: "Ta", Name: "Tantalum");
        public static readonly TransitionMetal Tungsten = new TransitionMetal(AtomicMass: "183.84", AtomicNumber: 74, Classification: "TransitionMetal", Symbol: "W", Name: "Tungsten");
        public static readonly TransitionMetal Rhenium = new TransitionMetal(AtomicMass: "186.207", AtomicNumber: 75, Classification: "TransitionMetal", Symbol: "Re", Name: "Rhenium");
        public static readonly TransitionMetal Osmium = new TransitionMetal(AtomicMass: "190.23", AtomicNumber: 76, Classification: "TransitionMetal", Symbol: "Os", Name: "Osmium");
        public static readonly TransitionMetal Iridium = new TransitionMetal(AtomicMass: "192.217", AtomicNumber: 77, Classification: "TransitionMetal", Symbol: "Ir", Name: "Iridium");
        public static readonly TransitionMetal Platinum = new TransitionMetal(AtomicMass: "195.078", AtomicNumber: 78, Classification: "TransitionMetal", Symbol: "Pt", Name: "Platinum");
        public static readonly CoinageMetal Gold = new CoinageMetal(AtomicMass: "196.96655", AtomicNumber: 79, Classification: "CoinageMetal", Symbol: "Au", Name: "Gold");
        public static readonly VolatileMetal Mercury = new VolatileMetal(AtomicMass: "200.59", AtomicNumber: 80, Classification: "VolatileMetal", Symbol: "Hg", Name: "Mercury");
        public static readonly PostTransitionMetal Thallium = new PostTransitionMetal(AtomicMass: "204.3833", AtomicNumber: 81, Classification: "PostTransitionMetal", Symbol: "Tl", Name: "Thallium");
        public static readonly PostTransitionMetal Lead = new PostTransitionMetal(AtomicMass: "207.2", AtomicNumber: 82, Classification: "PostTransitionMetal", Symbol: "Pb", Name: "Lead");
        public static readonly PostTransitionMetal Bismuth = new PostTransitionMetal(AtomicMass: "208.98038", AtomicNumber: 83, Classification: "PostTransitionMetal", Symbol: "Bi", Name: "Bismuth");
        public static readonly Metalloid Polonium = new Metalloid(AtomicMass: "(209)", AtomicNumber: 84, Classification: "Metalloid", Symbol: "Po", Name: "Polonium");
        public static readonly Halogen Astatine = new Halogen(AtomicMass: "(210)", AtomicNumber: 85, Classification: "Halogen", Symbol: "At", Name: "Astatine");
        public static readonly NobleGas Radon = new NobleGas(AtomicMass: "(222)", AtomicNumber: 86, Classification: "NobleGas", Symbol: "Rn", Name: "Radon");
        public static readonly AlkaliMetal Francium = new AlkaliMetal(AtomicMass: "(223)", AtomicNumber: 87, Classification: "AlkaliMetal", Symbol: "Fr", Name: "Francium");
        public static readonly AlkalineEarthMetal Radium = new AlkalineEarthMetal(AtomicMass: "(226)", AtomicNumber: 88, Classification: "AlkalineEarthMetal", Symbol: "Ra", Name: "Radium");
        public static readonly Actinide Actinium = new Actinide(AtomicMass: "(227)", AtomicNumber: 89, Classification: "Actinide", Symbol: "Ac", Name: "Actinium");
        public static readonly Actinide Thorium = new Actinide(AtomicMass: "232.0381", AtomicNumber: 90, Classification: "Actinide", Symbol: "Th", Name: "Thorium");
        public static readonly Actinide Protactinium = new Actinide(AtomicMass: "231.03588", AtomicNumber: 91, Classification: "Actinide", Symbol: "Pa", Name: "Protactinium");
        public static readonly Actinide Uranium = new Actinide(AtomicMass: "238.0289", AtomicNumber: 92, Classification: "Actinide", Symbol: "U", Name: "Uranium");
        public static readonly Actinide Neptunium = new Actinide(AtomicMass: "(237)", AtomicNumber: 93, Classification: "Actinide", Symbol: "Np", Name: "Neptunium");
        public static readonly Actinide Plutonium = new Actinide(AtomicMass: "(244)", AtomicNumber: 94, Classification: "Actinide", Symbol: "Pu", Name: "Plutonium");
        public static readonly Actinide Americium = new Actinide(AtomicMass: "(243)", AtomicNumber: 95, Classification: "Actinide", Symbol: "Am", Name: "Americium");
        public static readonly Actinide Curium = new Actinide(AtomicMass: "(247)", AtomicNumber: 96, Classification: "Actinide", Symbol: "Cm", Name: "Curium");
        public static readonly Actinide Berkelium = new Actinide(AtomicMass: "(247)", AtomicNumber: 97, Classification: "Actinide", Symbol: "Bk", Name: "Berkelium");
        public static readonly Actinide Californium = new Actinide(AtomicMass: "(251)", AtomicNumber: 98, Classification: "Actinide", Symbol: "Cf", Name: "Californium");
        public static readonly Actinide Einsteinium = new Actinide(AtomicMass: "(252)", AtomicNumber: 99, Classification: "Actinide", Symbol: "Es", Name: "Einsteinium");
        public static readonly Actinide Fermium = new Actinide(AtomicMass: "(257)", AtomicNumber: 100, Classification: "Actinide", Symbol: "Fm", Name: "Fermium");
        public static readonly Actinide Mendelevium = new Actinide(AtomicMass: "(258)", AtomicNumber: 101, Classification: "Actinide", Symbol: "Md", Name: "Mendelevium");
        public static readonly Actinide Nobelium = new Actinide(AtomicMass: "(259)", AtomicNumber: 102, Classification: "Actinide", Symbol: "No", Name: "Nobelium");
        public static readonly Actinide Lawrencium = new Actinide(AtomicMass: "(262)", AtomicNumber: 103, Classification: "Actinide", Symbol: "Lr", Name: "Lawrencium");
        public static readonly TransitionMetal Rutherfordium = new TransitionMetal(AtomicMass: "(267)", AtomicNumber: 104, Classification: "TransitionMetal", Symbol: "Rf", Name: "Rutherfordium");
        public static readonly TransitionMetal Dubnium = new TransitionMetal(AtomicMass: "(268)", AtomicNumber: 105, Classification: "TransitionMetal", Symbol: "Db", Name: "Dubnium");
        public static readonly TransitionMetal Seaborgium = new TransitionMetal(AtomicMass: "(271)", AtomicNumber: 106, Classification: "TransitionMetal", Symbol: "Sg", Name: "Seaborgium");
        public static readonly TransitionMetal Bohrium = new TransitionMetal(AtomicMass: "(272)", AtomicNumber: 107, Classification: "TransitionMetal", Symbol: "Bh", Name: "Bohrium");
        public static readonly TransitionMetal Hassium = new TransitionMetal(AtomicMass: "(270)", AtomicNumber: 108, Classification: "TransitionMetal", Symbol: "Hs", Name: "Hassium");
        public static readonly TransitionMetal Meitnerium = new TransitionMetal(AtomicMass: "(276)", AtomicNumber: 109, Classification: "TransitionMetal", Symbol: "Mt", Name: "Meitnerium");
        public static readonly TransitionMetal Darmstadtium = new TransitionMetal(AtomicMass: "(281)", AtomicNumber: 110, Classification: "TransitionMetal", Symbol: "Ds", Name: "Darmstadtium");
        public static readonly CoinageMetal Roentgenium = new CoinageMetal(AtomicMass: "(280)", AtomicNumber: 111, Classification: "CoinageMetal", Symbol: "Rg", Name: "Roentgenium");
        public static readonly VolatileMetal Copernicium = new VolatileMetal(AtomicMass: "(285)", AtomicNumber: 112, Classification: "VolatileMetal", Symbol: "Cn", Name: "Copernicium");
        public static readonly PostTransitionMetal Ununtrium = new PostTransitionMetal(AtomicMass: "(284)", AtomicNumber: 113, Classification: "PostTransitionMetal", Symbol: "Uut", Name: "Ununtrium");
        public static readonly PostTransitionMetal Flerovium = new PostTransitionMetal(AtomicMass: "(289)", AtomicNumber: 114, Classification: "PostTransitionMetal", Symbol: "Fl", Name: "Flerovium");
        public static readonly PostTransitionMetal Ununpentium = new PostTransitionMetal(AtomicMass: "(288)", AtomicNumber: 115, Classification: "PostTransitionMetal", Symbol: "Uup", Name: "Ununpentium");
        public static readonly PostTransitionMetal Livermorium = new PostTransitionMetal(AtomicMass: "(293)", AtomicNumber: 116, Classification: "PostTransitionMetal", Symbol: "Lv", Name: "Livermorium");
        public static readonly Halogen Ununseptium = new Halogen(AtomicMass: "(294)", AtomicNumber: 117, Classification: "Halogen", Symbol: "Uus", Name: "Ununseptium");
        public static readonly NobleGas Ununoctium = new NobleGas(AtomicMass: "(294)", AtomicNumber: 118, Classification: "NobleGas", Symbol: "Uuo", Name: "Ununoctium");

        public static readonly List<Element> elementList = new List<Element>()
        {
        	Hydrogen,
        	Helium,
        	Lithium,
        	Beryllium,
        	Boron,
        	Carbon,
        	Nitrogen,
        	Oxygen,
        	Fluorine,
        	Neon,
        	Sodium,
        	Magnesium,
        	Aluminium,
        	Silicone,
        	Phosphorus,
        	Sulfur,
        	Chlorine,
        	Argon,
        	Potassium,
        	Calcium,
        	Scandium,
        	Titanium,
        	Vanadium,
        	Chromium,
        	Manganese,
        	Iron,
        	Cobalt,
        	Nickel,
        	Copper,
        	Zinc,
        	Gallium,
        	Germanium,
        	Arsenic,
        	Selenium,
        	Bromine,
        	Krypton,
        	Rubidium,
        	Strontium,
        	Yttrium,
        	Zirconium,
        	Niobium,
        	Molybdenum,
        	Technetium,
        	Ruthenium,
        	Rhodium,
        	Palladium,
        	Silver,
        	Cadmium,
        	Indium,
        	Tin,
        	Antimony,
        	Tellurium,
        	Iodine,
        	Xenon,
        	Cesium,
        	Barium,
        	Lanthanum,
        	Cerium,
        	Praseodymium,
        	Neodymium,
        	Promethium,
        	Samarium,
        	Europium,
        	Gadolinium,
        	Terbium,
        	Dysprosium,
        	Holmium,
        	Erbium,
        	Thulium,
        	Ytterbium,
        	Lutetium,
        	Hafnium,
        	Tantalum,
        	Tungsten,
        	Rhenium,
        	Osmium,
        	Iridium,
        	Platinum,
        	Gold,
        	Mercury,
        	Thallium,
        	Lead,
        	Bismuth,
        	Polonium,
        	Astatine,
        	Radon,
        	Francium,
        	Radium,
        	Actinium,
        	Thorium,
        	Protactinium,
        	Uranium,
        	Neptunium,
        	Plutonium,
        	Americium,
        	Curium,
        	Berkelium,
        	Californium,
        	Einsteinium,
        	Fermium,
        	Mendelevium,
        	Nobelium,
        	Lawrencium,
        	Rutherfordium,
        	Dubnium,
        	Seaborgium,
        	Bohrium,
        	Hassium,
        	Meitnerium,
        	Darmstadtium,
        	Roentgenium,
        	Copernicium,
        	Ununtrium,
        	Flerovium,
        	Ununpentium,
        	Livermorium,
        	Ununseptium,
        	Ununoctium,
		};

        public static readonly Dictionary<string, Element> elementDictionary = new Dictionary<string, Element>()
        {
        	{"Hydrogen", Hydrogen},
        	{"H", Hydrogen},
        	{"1", Hydrogen},
        	{"Helium", Helium},
        	{"He", Helium},
        	{"2", Helium},
        	{"Lithium", Lithium},
        	{"Li", Lithium},
        	{"3", Lithium},
        	{"Beryllium", Beryllium},
        	{"Be", Beryllium},
        	{"4", Beryllium},
        	{"Boron", Boron},
        	{"B", Boron},
        	{"5", Boron},
        	{"Carbon", Carbon},
        	{"C", Carbon},
        	{"6", Carbon},
        	{"Nitrogen", Nitrogen},
        	{"N", Nitrogen},
        	{"7", Nitrogen},
        	{"Oxygen", Oxygen},
        	{"O", Oxygen},
        	{"8", Oxygen},
        	{"Fluorine", Fluorine},
        	{"F", Fluorine},
        	{"9", Fluorine},
        	{"Neon", Neon},
        	{"Ne", Neon},
        	{"10", Neon},
        	{"Sodium", Sodium},
        	{"Na", Sodium},
        	{"11", Sodium},
        	{"Magnesium", Magnesium},
        	{"Mg", Magnesium},
        	{"12", Magnesium},
        	{"Aluminium", Aluminium},
        	{"Al", Aluminium},
        	{"13", Aluminium},
        	{"Silicone", Silicone},
        	{"Si", Silicone},
        	{"14", Silicone},
        	{"Phosphorus", Phosphorus},
        	{"P", Phosphorus},
        	{"15", Phosphorus},
        	{"Sulfur", Sulfur},
        	{"S", Sulfur},
        	{"16", Sulfur},
        	{"Chlorine", Chlorine},
        	{"Cl", Chlorine},
        	{"17", Chlorine},
        	{"Argon", Argon},
        	{"Ar", Argon},
        	{"18", Argon},
        	{"Potassium", Potassium},
        	{"K", Potassium},
        	{"19", Potassium},
        	{"Calcium", Calcium},
        	{"Ca", Calcium},
        	{"20", Calcium},
        	{"Scandium", Scandium},
        	{"Sc", Scandium},
        	{"21", Scandium},
        	{"Titanium", Titanium},
        	{"Ti", Titanium},
        	{"22", Titanium},
        	{"Vanadium", Vanadium},
        	{"V", Vanadium},
        	{"23", Vanadium},
        	{"Chromium", Chromium},
        	{"Cr", Chromium},
        	{"24", Chromium},
        	{"Manganese", Manganese},
        	{"Mn", Manganese},
        	{"25", Manganese},
        	{"Iron", Iron},
        	{"Fe", Iron},
        	{"26", Iron},
        	{"Cobalt", Cobalt},
        	{"Co", Cobalt},
        	{"27", Cobalt},
        	{"Nickel", Nickel},
        	{"Ni", Nickel},
        	{"28", Nickel},
        	{"Copper", Copper},
        	{"Cu", Copper},
        	{"29", Copper},
        	{"Zinc", Zinc},
        	{"Zn", Zinc},
        	{"30", Zinc},
        	{"Gallium", Gallium},
        	{"Ga", Gallium},
        	{"31", Gallium},
        	{"Germanium", Germanium},
        	{"Ge", Germanium},
        	{"32", Germanium},
        	{"Arsenic", Arsenic},
        	{"As", Arsenic},
        	{"33", Arsenic},
        	{"Selenium", Selenium},
        	{"Se", Selenium},
        	{"34", Selenium},
        	{"Bromine", Bromine},
        	{"Br", Bromine},
        	{"35", Bromine},
        	{"Krypton", Krypton},
        	{"Kr", Krypton},
        	{"36", Krypton},
        	{"Rubidium", Rubidium},
        	{"Rb", Rubidium},
        	{"37", Rubidium},
        	{"Strontium", Strontium},
        	{"Sr", Strontium},
        	{"38", Strontium},
        	{"Yttrium", Yttrium},
        	{"Y", Yttrium},
        	{"39", Yttrium},
        	{"Zirconium", Zirconium},
        	{"Zr", Zirconium},
        	{"40", Zirconium},
        	{"Niobium", Niobium},
        	{"Nb", Niobium},
        	{"41", Niobium},
        	{"Molybdenum", Molybdenum},
        	{"Mo", Molybdenum},
        	{"42", Molybdenum},
        	{"Technetium", Technetium},
        	{"Tc", Technetium},
        	{"43", Technetium},
        	{"Ruthenium", Ruthenium},
        	{"Ru", Ruthenium},
        	{"44", Ruthenium},
        	{"Rhodium", Rhodium},
        	{"Rh", Rhodium},
        	{"45", Rhodium},
        	{"Palladium", Palladium},
        	{"Pd", Palladium},
        	{"46", Palladium},
        	{"Silver", Silver},
        	{"Ag", Silver},
        	{"47", Silver},
        	{"Cadmium", Cadmium},
        	{"Cd", Cadmium},
        	{"48", Cadmium},
        	{"Indium", Indium},
        	{"In", Indium},
        	{"49", Indium},
        	{"Tin", Tin},
        	{"Sn", Tin},
        	{"50", Tin},
        	{"Antimony", Antimony},
        	{"Sb", Antimony},
        	{"51", Antimony},
        	{"Tellurium", Tellurium},
        	{"Te", Tellurium},
        	{"52", Tellurium},
        	{"Iodine", Iodine},
        	{"I", Iodine},
        	{"53", Iodine},
        	{"Xenon", Xenon},
        	{"Xe", Xenon},
        	{"54", Xenon},
        	{"Cesium", Cesium},
        	{"Cs", Cesium},
        	{"55", Cesium},
        	{"Barium", Barium},
        	{"Ba", Barium},
        	{"56", Barium},
        	{"Lanthanum", Lanthanum},
        	{"La", Lanthanum},
        	{"57", Lanthanum},
        	{"Cerium", Cerium},
        	{"Ce", Cerium},
        	{"58", Cerium},
        	{"Praseodymium", Praseodymium},
        	{"Pr", Praseodymium},
        	{"59", Praseodymium},
        	{"Neodymium", Neodymium},
        	{"Nd", Neodymium},
        	{"60", Neodymium},
        	{"Promethium", Promethium},
        	{"Pm", Promethium},
        	{"61", Promethium},
        	{"Samarium", Samarium},
        	{"Sm", Samarium},
        	{"62", Samarium},
        	{"Europium", Europium},
        	{"Eu", Europium},
        	{"63", Europium},
        	{"Gadolinium", Gadolinium},
        	{"Gd", Gadolinium},
        	{"64", Gadolinium},
        	{"Terbium", Terbium},
        	{"Tb", Terbium},
        	{"65", Terbium},
        	{"Dysprosium", Dysprosium},
        	{"Dy", Dysprosium},
        	{"66", Dysprosium},
        	{"Holmium", Holmium},
        	{"Ho", Holmium},
        	{"67", Holmium},
        	{"Erbium", Erbium},
        	{"Er", Erbium},
        	{"68", Erbium},
        	{"Thulium", Thulium},
        	{"Tm", Thulium},
        	{"69", Thulium},
        	{"Ytterbium", Ytterbium},
        	{"Yb", Ytterbium},
        	{"70", Ytterbium},
        	{"Lutetium", Lutetium},
        	{"Lu", Lutetium},
        	{"71", Lutetium},
        	{"Hafnium", Hafnium},
        	{"Hf", Hafnium},
        	{"72", Hafnium},
        	{"Tantalum", Tantalum},
        	{"Ta", Tantalum},
        	{"73", Tantalum},
        	{"Tungsten", Tungsten},
        	{"W", Tungsten},
        	{"74", Tungsten},
        	{"Rhenium", Rhenium},
        	{"Re", Rhenium},
        	{"75", Rhenium},
        	{"Osmium", Osmium},
        	{"Os", Osmium},
        	{"76", Osmium},
        	{"Iridium", Iridium},
        	{"Ir", Iridium},
        	{"77", Iridium},
        	{"Platinum", Platinum},
        	{"Pt", Platinum},
        	{"78", Platinum},
        	{"Gold", Gold},
        	{"Au", Gold},
        	{"79", Gold},
        	{"Mercury", Mercury},
        	{"Hg", Mercury},
        	{"80", Mercury},
        	{"Thallium", Thallium},
        	{"Tl", Thallium},
        	{"81", Thallium},
        	{"Lead", Lead},
        	{"Pb", Lead},
        	{"82", Lead},
        	{"Bismuth", Bismuth},
        	{"Bi", Bismuth},
        	{"83", Bismuth},
        	{"Polonium", Polonium},
        	{"Po", Polonium},
        	{"84", Polonium},
        	{"Astatine", Astatine},
        	{"At", Astatine},
        	{"85", Astatine},
        	{"Radon", Radon},
        	{"Rn", Radon},
        	{"86", Radon},
        	{"Francium", Francium},
        	{"Fr", Francium},
        	{"87", Francium},
        	{"Radium", Radium},
        	{"Ra", Radium},
        	{"88", Radium},
        	{"Actinium", Actinium},
        	{"Ac", Actinium},
        	{"89", Actinium},
        	{"Thorium", Thorium},
        	{"Th", Thorium},
        	{"90", Thorium},
        	{"Protactinium", Protactinium},
        	{"Pa", Protactinium},
        	{"91", Protactinium},
        	{"Uranium", Uranium},
        	{"U", Uranium},
        	{"92", Uranium},
        	{"Neptunium", Neptunium},
        	{"Np", Neptunium},
        	{"93", Neptunium},
        	{"Plutonium", Plutonium},
        	{"Pu", Plutonium},
        	{"94", Plutonium},
        	{"Americium", Americium},
        	{"Am", Americium},
        	{"95", Americium},
        	{"Curium", Curium},
        	{"Cm", Curium},
        	{"96", Curium},
        	{"Berkelium", Berkelium},
        	{"Bk", Berkelium},
        	{"97", Berkelium},
        	{"Californium", Californium},
        	{"Cf", Californium},
        	{"98", Californium},
        	{"Einsteinium", Einsteinium},
        	{"Es", Einsteinium},
        	{"99", Einsteinium},
        	{"Fermium", Fermium},
        	{"Fm", Fermium},
        	{"100", Fermium},
        	{"Mendelevium", Mendelevium},
        	{"Md", Mendelevium},
        	{"101", Mendelevium},
        	{"Nobelium", Nobelium},
        	{"No", Nobelium},
        	{"102", Nobelium},
        	{"Lawrencium", Lawrencium},
        	{"Lr", Lawrencium},
        	{"103", Lawrencium},
        	{"Rutherfordium", Rutherfordium},
        	{"Rf", Rutherfordium},
        	{"104", Rutherfordium},
        	{"Dubnium", Dubnium},
        	{"Db", Dubnium},
        	{"105", Dubnium},
        	{"Seaborgium", Seaborgium},
        	{"Sg", Seaborgium},
        	{"106", Seaborgium},
        	{"Bohrium", Bohrium},
        	{"Bh", Bohrium},
        	{"107", Bohrium},
        	{"Hassium", Hassium},
        	{"Hs", Hassium},
        	{"108", Hassium},
        	{"Meitnerium", Meitnerium},
        	{"Mt", Meitnerium},
        	{"109", Meitnerium},
        	{"Darmstadtium", Darmstadtium},
        	{"Ds", Darmstadtium},
        	{"110", Darmstadtium},
        	{"Roentgenium", Roentgenium},
        	{"Rg", Roentgenium},
        	{"111", Roentgenium},
        	{"Copernicium", Copernicium},
        	{"Cn", Copernicium},
        	{"112", Copernicium},
        	{"Ununtrium", Ununtrium},
        	{"Uut", Ununtrium},
        	{"113", Ununtrium},
        	{"Flerovium", Flerovium},
        	{"Fl", Flerovium},
        	{"114", Flerovium},
        	{"Ununpentium", Ununpentium},
        	{"Uup", Ununpentium},
        	{"115", Ununpentium},
        	{"Livermorium", Livermorium},
        	{"Lv", Livermorium},
        	{"116", Livermorium},
        	{"Ununseptium", Ununseptium},
        	{"Uus", Ununseptium},
        	{"117", Ununseptium},
        	{"Ununoctium", Ununoctium},
        	{"Uuo", Ununoctium},
        	{"118", Ununoctium},
		};
        #endregion

        public static readonly Dictionary<Type, Color> ColorScheme1 = new Dictionary<Type, Color>()
        {
            {typeof(Metal), System.Drawing.Color.DeepSkyBlue},
            {typeof(AlkaliMetal), System.Drawing.Color.Beige},
            {typeof(AlkalineEarthMetal), System.Drawing.Color.Bisque},
            {typeof(RareEarthMetal), System.Drawing.Color.DodgerBlue},
            {typeof(Lanthanide), System.Drawing.Color.SaddleBrown},
            {typeof(Actinide), System.Drawing.Color.Brown},
            {typeof(CoinageMetal), System.Drawing.Color.LightGray},
            {typeof(VolatileMetal), System.Drawing.Color.LightGray},
            {typeof(TransitionMetal), System.Drawing.Color.LightGray},
            {typeof(PostTransitionMetal), System.Drawing.Color.DarkGray},
            {typeof(Metalloid), System.Drawing.Color.LightGreen},
            {typeof(NonMetal), System.Drawing.Color.LemonChiffon},
            {typeof(OtherNonMetal), System.Drawing.Color.Lime},
            {typeof(Halogen), System.Drawing.Color.LightBlue},
            {typeof(NobleGas), System.Drawing.Color.Cyan},
        };

        public static readonly Color HighlightTextColor = Color.Red;
        public static readonly Color HightlightBorderColor = Color.Red;

        public static readonly Color NormalTextColor = Color.Black;
        public static readonly Color NormalBorderColor = Color.Black;

        public static readonly Color DeHightlightTextColor = Color.Gray;
        public static readonly Color DeHightlightBorderColor = Color.DarkGray;

        public static readonly Color HightlightBackColor = Color.Yellow;
        public static readonly Color DehighlightBackColor = Color.DarkGray;

        public static Color GetNormalBackColor(Type classification)
        {
            Color retCol;
            if (ColorScheme1.TryGetValue(classification, out retCol))
                return retCol;
            return Color.Black;
        }
        public static Color GetNormalBackColor(Type classification, Dictionary<Type, Color> ColorScheme)
        {
            Color retCol;
            if (ColorScheme.TryGetValue(classification, out retCol))
                return retCol;
            return Color.Black;
        }
    }

}
