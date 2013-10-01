using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomizer
{
    public abstract class Element
    {
        public readonly string Name;
		public readonly string Symbol;
		public readonly string Classification;
        public readonly int AtomicNumber;
        public readonly string AtomicMass;
		public ElementBox Control;

        public Element(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass)
        {
            this.Name = Name;
            this.Symbol = Symbol;
            if (Classification == "CoinageMetal" || Classification == "VolatileMetal")
                Classification = "TransitionMetal";
            this.Classification = Classification;
            this.AtomicMass = AtomicMass;
            this.AtomicNumber = AtomicNumber;
        }
    }
    public abstract class Metal : Element { public Metal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class AlkaliMetal : Metal { public AlkaliMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class AlkalineEarthMetal : Metal { public AlkalineEarthMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public abstract class RareEarthMetal : Metal { public RareEarthMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class Lanthanide : RareEarthMetal { public Lanthanide(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class Actinide : RareEarthMetal { public Actinide(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class TransitionMetal : Metal { public TransitionMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class CoinageMetal : TransitionMetal { public CoinageMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class VolatileMetal : TransitionMetal { public VolatileMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class PostTransitionMetal : Metal { public PostTransitionMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }

    public class Metalloid : Element { public Metalloid(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }

    public class NonMetal : Element { public NonMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class OtherNonMetal : NonMetal { public OtherNonMetal(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class Halogen : NonMetal { public Halogen(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }
    public class NobleGas : NonMetal { public NobleGas(string Name, string Symbol, string Classification, int AtomicNumber, string AtomicMass) : base(Name, Symbol, Classification, AtomicNumber, AtomicMass) { } }


    //public enum Classifications
    //{
    //    Metal = 0x1,

    //        Alkali = 0x3,
    //        AlkaliEarth = 0x05,

    //        Lanthanoids = 0x09,
    //        Actinoids = 0x11,

    //        TransitionMetals = 0x21,
    //            CoinageMetal = 0x61,
    //            VolatileMetal = 0xA1,

    //        PostTransitionMetal = 0x101,
    //        BasicMetal = 0x101,

    //    Metalloid = 0x200,
    //    SemiMetal = 0x200,

    //    NonMetal = 0x400,
    //        Halogen = 0xC00,
    //        NobleGas = 0x1400,
    //}
    /*public enum Groups
    {
        Lithium = 1,
        Beryllium = 2,
        Scandium = 3,
        Titanium = 4,
        Vanadium = 5,
        Chromium = 6,
        Manganese = 7,
        IronGroup = 8,
        Cobalt = 9,
        Nickel = 10,
        Copper = 11,
        Zinc = 12,
        Boron = 13,
        Carbon = 14,
        Nitrogen = 15,  
        Oxygen = 16,
        Fluorine = 17,
        Helium = 18,
        Neon = 18,
        fblock = 19
    }*/
}
