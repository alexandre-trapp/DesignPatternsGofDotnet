namespace DesignPatternsGofDotnet.Structural.Composite
{
    static class CompositeApp
    {
        public static void Execute()
        {
            // Create a tree structure 
            var root = new CompositeElement("Picture");

            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));

            root.Add(comp);

            // Add and remove a PrimitiveElement
            var pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Exibir(1);
        }
    }
}
