using System;

namespace DesignPatternsGofDotnet.Structural.Facade
{
    /// <summary>
    /// Hipoteca: classe 'Facade' 
    /// </summary>
    class Hipoteca
    {
        private readonly Banco _banco = new Banco();
        private readonly Emprestimo _emprestimo = new Emprestimo();
        private readonly Credito _credito = new Credito();

        public bool Elegivel(Cliente cliente, int valor)
        {
            Console.WriteLine("Análise de solicitação de empréstimo para o cliente {0} no valor de {1:C}.\n", 
                cliente.Nome, valor);

            bool elegivel = true;

            // Check creditworthyness of applicant

            if (!_banco.TemSaldoSuficiente(cliente, valor))
            {
                elegivel = false;
            }
            else if (_emprestimo.PossuiHistoricoDeEmprestimosRuins(cliente))
            {
                elegivel = false;
            }
            else if (!_credito.TemUmBomCredito(cliente))
            {
                elegivel = false;
            }

            return elegivel;
        }
    }
}