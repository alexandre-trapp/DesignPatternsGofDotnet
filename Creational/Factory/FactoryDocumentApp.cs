using System;

namespace DesignPatternsGofDotnet.Factory
{
    /// <summary>
    /// O Factory Method é um padrão criacional de projeto 
    /// que fornece uma interface para criar objetos em uma 
    /// superclasse, mas permite que as subclasses alterem 
    /// o tipo de objetos que serão criados.
    /// </summary>
    static class FactoryDocumentApp
    {
        public static void Execute()
        {
            // Contrutores chamam o método Factory
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Exibir páginas dos documentos
            foreach (Document document in documents)
            {
                Console.WriteLine(Environment.NewLine + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                    Console.WriteLine(" " + page.GetType().Name);
            }
        }
    }
}
