namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() =>
            new Lion();

        public override Herbivore CreateHerbivore() =>
            new Rabbit();
    }
}
