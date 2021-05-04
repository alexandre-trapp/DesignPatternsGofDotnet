using System;
using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Builder
{
    /// <summary>
    /// Veiculo: classe 'Product'
    /// </summary>
    internal class Veiculo
    {
        private readonly string _veiculoType;

        private readonly Dictionary<string, string> _pecas =
            new Dictionary<string, string>();

        public Veiculo(string vehicleType) => 
            _veiculoType = vehicleType;

        // Indexador
        public string this[string key]
        {
            get => _pecas[key];
            set => _pecas[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de veiculo: {0}", _veiculoType);
            Console.WriteLine(" Carroceria : {0}", _pecas["carroceria"]);
            Console.WriteLine(" Motor : {0}", _pecas["motor"]);
            Console.WriteLine(" #Rodas: {0}", _pecas["rodas"]);
            Console.WriteLine(" #Portas : {0}", _pecas["portas"]);
        }
    }
}