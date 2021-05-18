using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Creational.Prototype
{
    /// <summary>
    /// CoresManager: classe gerenciadora 'Prototype manager'
    /// </summary>
    class CoresManager
    {
        private readonly Dictionary<string, CoresPrototype> _coress =
            new Dictionary<string, CoresPrototype>();

        // Indexer
        public CoresPrototype this[string key]
        {
            get => _coress[key];
            set => _coress.Add(key, value);
        }
    }
}