using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// Lobo: 'ProductB2' class
    /// </summary>
    class Lobo : Carnivoro
    {
        public override void Comer(Herbivoro herbivore) =>
            // Eat rabbit
            Console.WriteLine(GetType().Name + " come " + herbivore.GetType().Name);
    }
}