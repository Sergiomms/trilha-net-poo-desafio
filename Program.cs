using DesafioPOO.Models;

try 
{
  Console.WriteLine("Smartphone Nokia");
  Smartphone nokia = new Nokia("123456789", "XPTO-11", "987456321000hf", 512);
  nokia.Ligar();
  nokia.InstalarAplicativo("Instagram");
  nokia.MostraModelo();
  nokia.MostraMemoria();

  Console.WriteLine("\n");

  Console.WriteLine("Smartphone iPhone");
  Smartphone iphone = new Iphone("987654321", "i-15", "987456321000hf", 128);
  iphone.ReceberLigacao();
  iphone.InstalarAplicativo("Whatsapp");
  iphone.MostraModelo();
  iphone.MostraMemoria();

}
catch (ArgumentException ex)
{
  Console.WriteLine($"Erro: {ex.Message} \n Por favor, corrija o erro e tente rodar o programa novamente!");
}
  

