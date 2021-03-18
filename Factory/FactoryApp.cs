using System;

namespace DesignPatternsGofDotnet.Factory
{
    static class FactoryApp
    {
        public static void Execute()
        {
            // Constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine(Environment.NewLine + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                    Console.WriteLine(" " + page.GetType().Name);
            }
        }
    }
}
