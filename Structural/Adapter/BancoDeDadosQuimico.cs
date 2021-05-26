namespace DesignPatternsGofDotnet.Structural.Adapter {

  /// <summary>
  /// Classe 'Adapter'
  /// </summary>
  public class BancoDeDadosQuimico {

    // banco de dados 'API legada'
    public float ObterPontoCritico(string composto, string point) {

      // Ponto de fusão
      if (point == "M") {

        return (composto.ToLower()) switch {
        "agua" => 0.0f,
        "benzeno" => 5.5f,
        "etanol" => -114.1f,
        _ => 0f,
        };
      }

      // Ponto de ebulição
      else {

        return (composto.ToLower()) switch {
          "agua" => 100.0f,
          "benzeno" => 80.1f,
          "etanol" => 78.3f,
          _ => 0f,
        };
      }
    }

        public string ObterEstruturaMolecular(string composto) => (composto.ToLower()) switch
        {
            "agua" => "H20",
            "benzeno" => "C6H6",
            "etanol" => "C2H5OH",
            _ => "",
        };

        public double ObterPesoMolecular(string composto) => (composto.ToLower()) switch
        {
            "agua" => 18.015,
            "benzeno" => 78.1134,
            "etanol" => 46.0688,
            _ => 0d,
        };
    }
}