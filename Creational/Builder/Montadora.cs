namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// Montadora: classe 'Director'
    /// </summary>
    class Montadora
    {
        // Builder usa uma série de passos
        public void Construct(VeiculoBuilder veiculoBuilder)
        {
            veiculoBuilder.BuildCarroceria();
            veiculoBuilder.BuildMotor();
            veiculoBuilder.BuildRodas();
            veiculoBuilder.BuildPortas();
        }
    }
}
