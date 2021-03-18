using System;
using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Factory
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private readonly List<Page> _pages = new List<Page>();

        public Document() =>
            CreatePages();

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory method
        public abstract void CreatePages();
    }
}