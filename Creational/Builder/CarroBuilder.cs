namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// CarroBuilder: classe 'ConcreteBuilder2'
    /// </summary>
    class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder() => _veiculo = new Veiculo("Carro");

        public override void BuildPortas() =>
            _veiculo["portas"] = "4";

        public override void BuildMotor() =>
            _veiculo["motor"] = "2500 cc";

        public override void BuildCarroceria() =>
            _veiculo["carroceria"] = "Car Frame";

        public override void BuildRodas() =>
            _veiculo["rodas"] = "4";
    }
}
