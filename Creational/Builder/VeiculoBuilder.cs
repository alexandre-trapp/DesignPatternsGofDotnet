namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// VeiculoBuilder: classe abstrata 'Builder'
    /// </summary>
    abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;

        // Obtem instância de 'veiculo'
        public Veiculo Veiculo => _veiculo;

        // Metodos de 'build' abstratos
        public abstract void BuildCarroceria();
        public abstract void BuildMotor();
        public abstract void BuildRodas();
        public abstract void BuildPortas();
    }
}