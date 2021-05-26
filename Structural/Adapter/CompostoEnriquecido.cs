using System;

namespace DesignPatternsGofDotnet.Structural.Adapter {
  
  /// <summary>
  /// classe 'Adapter'
  /// </summary>
  class CompostoEnriquecido : Composto 
  {
    public CompostoEnriquecido(string name) : base(name) { }

    public override void Exibir()
    {
      // The Adaptee
      var _bank = new BancoDeDadosQuimico();
 
      _pontoEbulicao = _bank.ObterPontoCritico(_quimica, "B");
      _pontoFusao = _bank.ObterPontoCritico(_quimica, "M");
      _pesoMolecular = _bank.ObterPesoMolecular(_quimica);
      _formaMolecular = _bank.ObterEstruturaMolecular(_quimica);

      base.Exibir();
      Console.WriteLine(" Formula molecular: {0}", _formaMolecular);
      Console.WriteLine(" Peso : {0}", _pesoMolecular);
      Console.WriteLine(" Fusão Pt: {0}", _pontoFusao);
      Console.WriteLine(" Ebulição Pt: {0}", _pontoEbulicao);
    }
  }
}