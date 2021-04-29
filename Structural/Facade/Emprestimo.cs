using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// Emprestimo: classe de subsistema da fachada (Subsystem ClassC)
    /// </summary>
    class Emprestimo
    {
        public bool PossuiHistoricoDeEmprestimosRuins(Cliente cliente)
        {
            Console.WriteLine("Checando histório de empréstimos para o cliente " + cliente.Nome);
            return true;
        }
    }
}
