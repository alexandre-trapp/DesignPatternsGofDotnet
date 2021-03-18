namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() =>
            new Wolf();

        public override Herbivore CreateHerbivore() =>
            new Bison();
    }
}
