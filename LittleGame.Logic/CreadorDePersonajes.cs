namespace LittleGame.Logic;

public class CreadorDePersonajes
{
    private readonly List<string> _nombres;
    private readonly Random _random;

    public CreadorDePersonajes()
    {
        _random = new Random();
        _nombres = new()
        {
            "Gandalf",
            "Legolas",
            "Gimli",
            "Raistlin",
            "Tanis",
            "Drizzt",
            "Goldmoon",
            "Riverwind",
            "Sturm",
            "Frodo"
        };
    }

    public Personaje Crear()
    {
        var nombre = ElegirNombre();
        var tipo = ElegirTipo();
        var nacimiento = ElegirNacimiento();
        return new Personaje(nombre, tipo, nacimiento);
    }

    private DateOnly ElegirNacimiento()
    {
        var years = _random.Next(1, 301);
        var date = DateTime.Now.AddYears(-years);

        // TODO: elegir mes y dia al azar tambien
        return DateOnly.FromDateTime(date);
    }

    private Tipo ElegirTipo()
    {
        var tipos = Enum.GetValues<Tipo>();
        var index = _random.Next(0, tipos.Length);
        return tipos[index];
    }

    private string ElegirNombre()
    {
        // TODO: que pasa si se me acaban los nombres
        var index = _random.Next(0, _nombres.Count);
        var nombreElegido = _nombres[index];
        _nombres.RemoveAt(index);

        return nombreElegido;
    }
}