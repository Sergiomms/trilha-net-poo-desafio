namespace DesafioPOO.Models
{
  public class Nokia : Smartphone
  {
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {

    }
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia");
    }

    public override void MostraModelo()
    {
      Console.WriteLine($"O modelo deste smartphone Nokia é: {Modelo}");
    }

    public override void MostraMemoria()
    {
      Console.WriteLine($"Este smartphone Nokia possui: {Memoria} Gb de memória");
    }
  }
}