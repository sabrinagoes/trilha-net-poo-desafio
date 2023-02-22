namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
    public class Iphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
    }
}
