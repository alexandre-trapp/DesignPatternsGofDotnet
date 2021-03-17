﻿namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            _vehicle = new Vehicle("Car");
        }

        public override void BuildDoors() =>
            _vehicle["doors"] = "4";

        public override void BuildEngine() =>
            _vehicle["engine"] = "2500 cc";

        public override void BuildFrame() =>
            _vehicle["frame"] = "Car Frame";

        public override void BuildWheels() =>
            _vehicle["wheels"] = "4";
    }
}
