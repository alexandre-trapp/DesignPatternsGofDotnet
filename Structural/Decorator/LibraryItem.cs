namespace DesignPatternsGofDotnet.Structural.Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get => _numCopies;
            set => _numCopies = value;
        }

        public abstract void Exibir();
    }
}
