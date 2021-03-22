using System;
using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Structural.Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> _elements =
            new List<DrawingElement>();

        public CompositeElement(string name) : base(name) { }

        public override void Add(DrawingElement element) =>
            _elements.Add(element);

        public override void Remove(DrawingElement element) =>
            _elements.Remove(element);

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + "+ " + _name);

            // Display each child element on this node
            foreach (DrawingElement element in _elements)
                element.Display(indent + 2);
        }
    }
}