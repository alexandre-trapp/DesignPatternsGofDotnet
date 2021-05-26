namespace DesignPatternsGofDotnet.Creational.Prototype
{
    /// <summary>
    /// O Prototype é um padrão de projeto criacional 
    /// que permite copiar objetos existentes sem fazer 
    /// seu código ficar dependente de suas classes.
    /// Consulte: https://refactoring.guru/pt-br/design-patterns/prototype
    /// ou https://www.dofactory.com/net/prototype-design-pattern
    /// </summary>
    public static class PrototypeCoresApp
    {
        public static void Execute()
        {
            var coresmanager = new CoresManager();

            // Incializar com cores padrões
            coresmanager["vermelho"] = new Cores(255, 0, 0);
            coresmanager["verde"] = new Cores(0, 255, 0);
            coresmanager["azul"] = new Cores(0, 0, 255);

            // Adicionar cores personalizadas
            coresmanager["nervoso"] = new Cores(255, 54, 0);
            coresmanager["paz"] = new Cores(128, 211, 128);
            coresmanager["flamejante"] = new Cores(211, 34, 20);

            // Clonar cores selecionadas
            var cores1 = coresmanager["vermelho"].Clone() as Cores;
            var cores2 = coresmanager["paz"].Clone() as Cores;
            var cores3 = coresmanager["flamejante"].Clone() as Cores;
        }
    }
}
