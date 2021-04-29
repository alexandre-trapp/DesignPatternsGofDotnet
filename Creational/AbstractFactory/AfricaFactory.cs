namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() =>
            new Leao();

        public override Herbivoro CriarHerbivoro() =>
            new Coelho();
    }
}
