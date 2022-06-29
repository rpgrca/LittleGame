namespace LittleGame.Logic;

public class Personaje
{
    private int _velocidad;
    private int _fuerza;
    private int _nivel;
    private int _armadura;
    private int _destreza;

    public string Nombre { get; }
    public Tipo Tipo { get; }
    public string Apodo { get; set; }
    public int Salud { get; set; }
    public DateOnly Nacimiento { get; }
    public int Edad { get; }
    public int Velocidad
    {
        get
        {
            return _velocidad;
        }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _velocidad = value;
            }
        }
    }

    public int Fuerza
    {
        get
        {
            return _fuerza;
        }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _fuerza = value;
            }
        }
    }

    public int Nivel
    {
        get
        {
            return _nivel;
        }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _nivel = value;
            }
        }
    }

    public int Armadura
    {
        get
        {
            return _armadura;
        }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _armadura = value;
            }
        }
    }

    public int Destreza
    {
        get
        {
            return _destreza;
        }
        set
        {
            if (value >= 1 && value <= 5)
            {
                _destreza = value;
            }
        }
    }

    public Personaje(string nombre, Tipo tipo, DateOnly nacimiento)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre invalido");

        Nombre = nombre;
        Tipo = tipo;
        Salud = 100;
        Nacimiento = nacimiento;
        Edad =  DateTime.Now.Year - Nacimiento.Year;

        var random = new Random();
        Velocidad = random.Next(1, 11);
        Fuerza = random.Next(1, 11);
        Nivel = random.Next(1, 11);
        Armadura = random.Next(1, 11);
        Destreza = random.Next(1, 6);
    }
}