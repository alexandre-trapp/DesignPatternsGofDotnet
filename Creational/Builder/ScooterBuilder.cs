namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// ScooterBuilder: classe 'ConcreteBuilder3'
    /// </summary>
    class ScooterBuilder : VeiculoBuilder
    {
        public ScooterBuilder() =>
            _veiculo = new Veiculo("Scooter");
        
        public override void BuildPortas() =>
            _veiculo["portas"] = "0";

        public override void BuildMotor() =>
            _veiculo["motor"] = "50 cc";

        public override void BuildCarroceria() =>
            _veiculo["carroceria"] = "Quadro de scooter";

        public override void BuildRodas() =>
            _veiculo["rodas"] = "2";
    }
}
