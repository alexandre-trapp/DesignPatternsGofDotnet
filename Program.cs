using System;

using DesignPatternsGofDotnet.AbstractFactory;
using DesignPatternsGofDotnet.Builder;
using DesignPatternsGofDotnet.Factory;
using DesignPatternsGofDotnet.Singleton;
using DesignPatternsGofDotnet.Structural.Adapter;

namespace DesignPatternsGofDotnet {
    static class Program {
        static void Main(string [] args) {
            
            Console.WriteLine("-------- CREATIONALS PATTERNS --------");
            Console.WriteLine();

            Console.WriteLine("-------- ABSTRACT FACTORY --------");
            AbstractFactoryApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- BUILDER --------");
            BuilderApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- FACTORY --------");
            FactoryApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- SINGLETON --------");
            SingletonApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- STRUCTURALS PATTERNS --------");
            Console.WriteLine();

            Console.WriteLine("-------- ADAPTER --------");
            AdapterApp.Execute();
        }
    }
}