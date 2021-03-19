using System;

namespace DesignPatternsGofDotnet.Structural.Adapter {

    public static class AdapterApp {

        public static void Execute() {

            // Non-adapted chemical compound
            var unknown = new Compound("Unknow");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}