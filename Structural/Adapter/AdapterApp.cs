namespace DesignPatternsGofDotnet.Structural.Adapter {

    /// <summary>
    /// O Adapter é um padrão de projeto estrutural 
    /// que permite objetos com interfaces incompatíveis colaborarem entre si.
    /// Consulte: https://refactoring.guru/pt-br/design-patterns/adapter
    /// ou https://www.dofactory.com/net/adapter-design-pattern
    /// </summary>
    public static class AdapterApp {

        public static void Execute() {

            // Composto químico não adaptado
            var unknown = new Composto("Unknow");
            unknown.Exibir();

            // Compostos quimicos adaptados

            Composto agua = new CompostoEnriquecido("agua");
            agua.Exibir();

            Composto benzeno = new CompostoEnriquecido("benzeno");
            benzeno.Exibir();

            Composto etanol = new CompostoEnriquecido("etanol");
            etanol.Exibir();
        }
    }
}