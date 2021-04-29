using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// Coelho: 'ProductA1' class
    /// </summary>
    internal class Coelho : Herbivoro
    {
        public override void Comer() =>
            Console.WriteLine(GetType().Name + " come cenoura.");
    }
}