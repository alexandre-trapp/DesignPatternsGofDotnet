using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Creational.Prototype
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}