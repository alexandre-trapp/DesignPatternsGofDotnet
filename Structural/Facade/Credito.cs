using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// Credito: classe de subsistema da fachada (Subsystem ClassB)
    /// </summary>
    class Credito
    {
        public bool TemUmBomCredito(Cliente cliente)
        {
            Console.WriteLine("Checando crédito para o cliente " + cliente.Nome);
            return true;
        }
    }
}
