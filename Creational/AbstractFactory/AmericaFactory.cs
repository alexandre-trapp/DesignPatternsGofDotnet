namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() =>
            new Lobo();

        public override Herbivoro CriarHerbivoro() =>
            new Bison();
    }
}
