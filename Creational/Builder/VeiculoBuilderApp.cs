namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// O Builder é um padrão de projeto criacional 
    /// que permite a você construir objetos complexos 
    /// passo a passo. O padrão permite que você produza 
    /// diferentes tipos e representações de um objeto 
    /// usando o mesmo código de construção.
    /// Consulte: https://refactoring.guru/pt-br/design-patterns/builder
    /// ou https://www.dofactory.com/net/builder-design-pattern
    /// </summary>
    static class VeiculoBuilderApp
    {
        public static void Execute()
        {
            VeiculoBuilder builder;

            // Cria uma montadora com veiculos builders (construtores de veículos)
            var shop = new Montadora();

            // Constroi e exible os veículos
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Veiculo.Show();

            builder = new CarroBuilder();
            shop.Construct(builder);
            builder.Veiculo.Show();

            builder = new MotocicletaBuilder();
            shop.Construct(builder);
            builder.Veiculo.Show();
        }
    }
}
