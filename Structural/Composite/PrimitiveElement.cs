using System;

namespace DesignPatternsGofDotnet.Structural.Composite
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name) { }

        public override void Add(DrawingElement element) =>
            Console.WriteLine("Cannot add to a PrimitiveElement");

        public override void Exibir(int indent) =>
            Console.WriteLine(new string('-', indent) + " " + _name);

        public override void Remove(DrawingElement element) =>
            Console.WriteLine("Cannot remove from a PrimitiveElement");
    }
}