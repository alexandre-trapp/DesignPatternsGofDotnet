using System;
using DesignPatternsGofDotnet.Builder;
using DesignPatternsGofDotnet.Factory;
using DesignPatternsGofDotnet.Singleton;
using DesignPatternsGofDotnet.AbstractFactory;
using DesignPatternsGofDotnet.Structural.Bridge;
using DesignPatternsGofDotnet.Structural.Adapter;
using DesignPatternsGofDotnet.Creational.Prototype;

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

            Console.WriteLine("-------- PROTOTYPE --------");
            PrototypeApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- STRUCTURALS PATTERNS --------");
            Console.WriteLine();

            Console.WriteLine("-------- ADAPTER --------");
            AdapterApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- BRIDGE --------");
            BridgeApp.Execute();
        }
    }
}