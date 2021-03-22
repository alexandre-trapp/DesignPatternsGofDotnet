using System;

namespace DesignPatternsGofDotnet.Structural.Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class Customers : CustomersBase
    {
        public Customers(string group) : base(group) { }

        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}