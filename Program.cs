using System;
using DesignPatternsGofDotnet.Builder;
using DesignPatternsGofDotnet.Factory;
using DesignPatternsGofDotnet.Singleton;
using DesignPatternsGofDotnet.AbstractFactory;
using DesignPatternsGofDotnet.Structural.Bridge;
using DesignPatternsGofDotnet.Structural.Adapter;
using DesignPatternsGofDotnet.Creational.Prototype;
using DesignPatternsGofDotnet.Structural.Composite;
using DesignPatternsGofDotnet.Structural.Decorator;
using DesignPatternsGofDotnet.Structural.Facade;

namespace DesignPatternsGofDotnet {
    static class Program {
        static void Main(string [] args) {
            
            Console.WriteLine("-------- CREATIONALS PATTERNS --------");
            Console.WriteLine();

            Console.WriteLine("-------- ABSTRACT FACTORY --------");
            AbstractFactoryMundoAnimalApp.Execute();

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

            Console.WriteLine();

            Console.WriteLine("-------- COMPOSITE --------");
            CompositeApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- DECORATOR --------");
            DecoratorApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- FACADE --------");
            FacadeHipotecaApp.Execute();
        }
    }
}