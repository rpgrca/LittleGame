using Newtonsoft.Json;

namespace LittleGame.Logic;

public class CreadorDePersonajes
{
    private readonly List<string> _nombresUsados;
    private readonly Random _random;

    public CreadorDePersonajes()
    {
        _random = new Random();
        _nombresUsados = new List<string>();
    }

    public async Task<Personaje> Crear()
    {
        var nombre = await ElegirNombre();
        var tipo = ElegirTipo();
        var nacimiento = ElegirNacimiento();
        return new Personaje(nombre, tipo, nacimiento);
    }

    public void InvalidarNombre(string nombre) => _nombresUsados.Add(nombre);

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

    private async Task<string> ElegirNombre()
    {
        string nombreElegido;
        var httpClient = new HttpClient();

        do
        {
            var respuesta = await httpClient.GetStringAsync(new Uri("https://random-names-api.herokuapp.com/random"));
            var nombreAleatorio = JsonConvert.DeserializeObject<RandomName>(respuesta);

            nombreElegido = nombreAleatorio.Body.Name;
        } while (_nombresUsados.Contains(nombreElegido));

        _nombresUsados.Add(nombreElegido);
        return nombreElegido;
    }
}