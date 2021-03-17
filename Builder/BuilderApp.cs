using System;

namespace DesignPatternsGofDotnet.Builder
{
    static class BuilderApp
    {
        public static void Execute()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            var shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
