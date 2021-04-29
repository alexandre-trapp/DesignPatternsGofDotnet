using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// Banco: classe de subsistema da fachada (Subsystem ClassA)
    /// </summary>
    class Banco
    {
        public bool TemSaldoSuficiente(Cliente cliente, int valor)
        {
            Console.WriteLine("Checando saldo no banco para o cliente " + cliente.Nome);
            return true;
        }
    }
}
