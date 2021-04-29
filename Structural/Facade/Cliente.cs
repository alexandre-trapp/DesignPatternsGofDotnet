namespace DesignPatternsGofDotnet.Structural.Facade
{
    class Cliente
    {
        private readonly string _nome;

        public Cliente(string nome) => 
            _nome = nome;

        public string Nome => _nome;
    }
}