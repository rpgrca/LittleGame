namespace LittleGame.Logic;

public enum Tipo
{
    Mago,
    Caballero,
    Arquero,
    Elfo,
    Ladron
}

public class Personaje
{
    public string Nombre { get; }
    public Tipo Tipo { get; }
    public string Apodo { get; set; }
    public int Salud { get; set; }

    public Personaje(string nombre, Tipo tipo)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre invalido");

        Nombre = nombre;
        Tipo = tipo;
        Salud = 100;
    }
}
