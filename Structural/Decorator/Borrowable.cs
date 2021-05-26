using System;
using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Structural.Decorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem) { }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Exibir()
        {
            base.Exibir();

            foreach (string borrower in borrowers)
                Console.WriteLine(" borrower: " + borrower);
        }
    }
}