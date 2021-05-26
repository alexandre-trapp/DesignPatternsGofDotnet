using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Creational.Prototype
{
    /// <summary>
    /// CoresManager: classe gerenciadora 'Prototype manager'
    /// </summary>
    class CoresManager
    {
        private readonly Dictionary<string, CoresPrototype> _cores =
            new Dictionary<string, CoresPrototype>();

        // Indexer
        public CoresPrototype this[string key]
        {
            get => _cores[key];
            set => _cores.Add(key, value);
        }
    }
}