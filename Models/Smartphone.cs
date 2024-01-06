namespace DesafioPOO.Models
{
  public abstract class Smartphone
  {

    private string _numero;
    private string _modelo;
    private string _imei;
    private int _memoria;

    public string Numero
    {
      get => _numero;
      set
      {
        bool ehValido = value.Length == 9 && value.All(char.IsDigit);
        if (!ehValido)
        {
          throw new ArgumentException("Número deve conter 9 digitos / numeros.");
        }

        _numero = value;
      }
    }

    protected string Modelo
    {
      get => _modelo;
      set
      {
        if (value.Length > 10)
        {
          throw new ArgumentException("Modelo não pode ter mais do que 10 caracteres.");
        }

        _modelo = value;
      }
    }

    protected string Imei
    {
      get => _imei;
      set
      {
        if (value.Length > 20)
        {
          throw new ArgumentException("Código IMEI maior do que 20 caracteres.");
        }

        _imei = value;
      }
    }

    protected int Memoria
    {
      get => _memoria;
      set
      {
        if (value > 1000)
        {
          throw new ArgumentException("A memoria não pode ser maior que 1.000 Gb.");
        }

        _memoria = value;
      }
    }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
      Numero = numero;
      Modelo = modelo;
      Imei = imei;
      Memoria = memoria;
    }

    public void Ligar()
    {
      Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
    public abstract void MostraModelo();
    public abstract void MostraMemoria();
  }
}