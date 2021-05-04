namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// MotocicletaBuilder: 'ConcreteBuilder1'
    /// </summary>
    class MotocicletaBuilder : VeiculoBuilder
    {
        public MotocicletaBuilder() => _veiculo = new Veiculo("Motorcicleta");

        public override void BuildPortas() =>
            _veiculo["portas"] = "0";

        public override void BuildMotor() =>
            _veiculo["motor"] = "500cc";

        public override void BuildCarroceria() =>
            _veiculo["carroceria"] = "Quadro de motocicleta";

        public override void BuildRodas() =>
            _veiculo["rodas"] = "2";
    }
}
