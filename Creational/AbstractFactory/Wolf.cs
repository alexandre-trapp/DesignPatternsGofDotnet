using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore) =>
            // Eat rabbit
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
    }
}