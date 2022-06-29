namespace LittleGame.Logic;

public class Personaje
{
    public string Nombre { get; }
    public Tipo Tipo { get; }
    public string Apodo { get; set; }
    public int Salud { get; set; }
    public DateOnly Nacimiento { get; }

    public Personaje(string nombre, Tipo tipo, DateOnly nacimiento)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre invalido");

        Nombre = nombre;
        Tipo = tipo;
        Salud = 100;
        Nacimiento = nacimiento;
    }
}
