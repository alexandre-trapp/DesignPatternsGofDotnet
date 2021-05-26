namespace DesignPatternsGofDotnet.Structural.Composite
{
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    abstract class DrawingElement
    {
        protected string _name;

        // Constructor
        public DrawingElement(string name)
        {
            _name = name;
        }

        public abstract void Add(DrawingElement element);
        public abstract void Remove(DrawingElement element);
        public abstract void Exibir(int indent);
    }
}