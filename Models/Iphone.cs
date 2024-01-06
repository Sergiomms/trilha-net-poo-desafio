namespace DesafioPOO.Models
{
  public class Iphone : Smartphone
  {

    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {

    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone");
    }

    public override void MostraModelo()
    {
      Console.WriteLine($"O modelo deste iPhone é: {Modelo}");
    }

    public override void MostraMemoria()
    {
      Console.WriteLine($"Este iPhone possui: {Memoria} Gb de memória");
    }
  }
}