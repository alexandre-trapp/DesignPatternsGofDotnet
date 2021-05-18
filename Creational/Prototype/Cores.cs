using System;

namespace DesignPatternsGofDotnet.Creational.Prototype
{
    /// <summary>
    /// Cores: classe concreta
    /// </summary>
    class Cores : CoresPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Cores(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override CoresPrototype Clone()
        {
            Console.WriteLine(
                "Cloning cores RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return MemberwiseClone() as CoresPrototype;
        }
    }
}