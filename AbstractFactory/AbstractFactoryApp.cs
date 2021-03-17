using System;

namespace DesignPatternsGofDotnet.AbstractFactory
{
    public static class AbstractFactoryApp
    {
        public static void Execute()
        {
            // Create and run the African animal world
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            var america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
