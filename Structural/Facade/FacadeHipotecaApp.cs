using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// O Facade é um padrão de projeto estrutural 
    /// que fornece uma interface simplificada para uma biblioteca, 
    /// um framework, ou qualquer conjunto complexo de classes.
    /// Consulte: https://refactoring.guru/pt-br/design-patterns/facade
    /// ou https://www.dofactory.com/net/facade-design-pattern
    /// </summary>
    public static class FacadeHipotecaApp
    { 
        public static void Execute()
        {
            // Facade
            var hipoteca = new Hipoteca();

            // avaliar se cliente é elegível para hipoteca
            var cliente = new Cliente("Alexandre Trapp");

            bool eligible = hipoteca.Elegivel(cliente, 125000);

            Console.WriteLine("\nEmpréstimo para o cliente " + cliente.Nome +
                " foi " + (eligible ? "Aprovado" : "Rejeitado"));
        }
    }
}
