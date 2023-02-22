namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

    public class Nokia
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
    }
}
