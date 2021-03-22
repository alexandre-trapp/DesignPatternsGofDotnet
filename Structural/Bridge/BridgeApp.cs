namespace DesignPatternsGofDotnet.Structural.Bridge
{
    static class BridgeApp
    {
        public static void Execute()
        {
            // Create RefinedAbstraction
            var customers = new Customers("Chicago")
            {
                Data = new CustomersData() // Set ConcreteImplementor 
            };

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }
    }
}
