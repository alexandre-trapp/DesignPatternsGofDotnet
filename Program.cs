using System;
using DesignPatternsGofDotnet.Builder;
using DesignPatternsGofDotnet.AbstractFactory;
using DesignPatternsGofDotnet.Factory;

namespace DesignPatternsGofDotnet
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- ABSTRACT FACTORY --------");
            AbstractFactoryApp.Execute();
            
            Console.WriteLine();

            Console.WriteLine("-------- BUILDER --------");
            BuilderApp.Execute();

            Console.WriteLine();

            Console.WriteLine("-------- FACTORY --------");
            FactoryApp.Execute();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
