using System;

namespace DesignPatternsGofDotnet.Structural.Adapter {

  /// <summary>
  /// Classe 'Alvo/Target'
  /// </summary>
  class Composto {

    protected string _quimica;
    protected float _pontoEbulicao;
    protected float _pontoFusao;
    protected double _pesoMolecular;
    protected string _formaMolecular;

    public Composto(string quimica) =>
      _quimica = quimica;

    public virtual void Exibir() =>
      Console.WriteLine("\nComposto químico: {0} ------ ", _quimica);
  }
}