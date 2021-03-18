namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            _vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildDoors() =>
            _vehicle["doors"] = "0";

        public override void BuildEngine() =>
            _vehicle["engine"] = "500cc";

        public override void BuildFrame() =>
            _vehicle["frame"] = "MotorCycle Frame";

        public override void BuildWheels() =>
            _vehicle["wheels"] = "2";
    }
}
