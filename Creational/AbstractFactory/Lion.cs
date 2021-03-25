using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore) =>
            // Eat bison
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
    }
}