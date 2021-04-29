namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// ContinenteFactory: 'AbstractFactory' abstract class
    /// </summary>
    abstract class ContinenteFactory
    {
        public abstract Herbivoro CriarHerbivoro();
        public abstract Carnivoro CriarCarnivoro();
    }
}
