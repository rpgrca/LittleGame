namespace LittleGame.Logic;

public class Personaje
{
    public string Nombre { get; }
    public string Apodo { get; set; }

    public Personaje(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre invalido");

        Nombre = nombre;
    }
}
