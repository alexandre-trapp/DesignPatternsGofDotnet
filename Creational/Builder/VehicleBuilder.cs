namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}