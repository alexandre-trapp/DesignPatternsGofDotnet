namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// MundoAnimal: 'Client' class 
    /// </summary>
    class MundoAnimal
    {
        private readonly Herbivoro _herbivoro;
        private readonly Carnivoro _carnivoro;

        public MundoAnimal(ContinenteFactory factory)
        {
            _herbivoro = factory.CriarHerbivoro();
            _carnivoro = factory.CriarCarnivoro();
        }

        public void AdministrarCadeiaAlimentar() =>
            _carnivoro.Comer(_herbivoro);
    }
}
