using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// Leao: 'ProductB1' class
    /// </summary>
    class Leao : Carnivoro
    {
        public override void Comer(Herbivoro herbivoro) =>
            // Eat bison
            Console.WriteLine(GetType().Name + " come " + herbivoro.GetType().Name);
    }
}