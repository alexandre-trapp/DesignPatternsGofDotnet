using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// Facade Design Pattern.
    /// FacadeHipotecaApp startup class para cenário do mundo real (hipoteca)
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
