namespace DesignPatternsGofDotnet.AbstractFactory
{
    /// <summary>
    /// O Abstract Factory é um padrão de projeto criacional 
    /// que permite que você produza famílias de objetos relacionados 
    /// sem ter que especificar suas classes concretas.
    /// Consulte: https://refactoring.guru/pt-br/design-patterns/abstract-factory
    /// ou https://www.dofactory.com/net/abstract-factory-design-pattern
    /// </summary>
    public static class AbstractFactoryMundoAnimalApp
    {
        public static void Execute()
        {
            // Cria e executa o mundo animal Africano
            var africa = new AfricaFactory();
            var mundo = new MundoAnimal(africa);
            mundo.AdministrarCadeiaAlimentar();

            // Cria e executa o mundo animal Americano
            var america = new AmericaFactory();
            mundo = new MundoAnimal(america);
            mundo.AdministrarCadeiaAlimentar();
        }
    }
}
