using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// Bison: 'ProductA2' class
    /// </summary>
    internal class Bisao : Herbivoro
    {
        public override void Comer() =>
            Console.WriteLine(GetType().Name + " come capim.");
    }
}