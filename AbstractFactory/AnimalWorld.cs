namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    class AnimalWorld
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain() =>
            _carnivore.Eat(_herbivore);
    }
}
