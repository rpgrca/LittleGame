using Newtonsoft.Json;

namespace LittleGame.Logic;

public class ListadoDeGanadores
{
    private readonly string _archivo;

    public ListadoDeGanadores(string archivo) =>
        _archivo = archivo;

    public void Agregar(Personaje ganador, Personaje perdedor) =>
        File.AppendAllText(_archivo, $"{ganador.Nombre},{ganador.Salud},{perdedor.Nombre},{perdedor.Salud}" + Environment.NewLine);

    public void Listar()
    {
        Console.WriteLine("GANADOR |  SALUD  | PERDEDOR |  SALUD");
        foreach (var line in File.ReadAllLines(_archivo))
        {
            var campos = line.Split(",");
            Console.WriteLine($"{campos[0],7} |  {campos[1],5}  | {campos[2],8} |  {campos[3],5}");
        }
    }
}

public class Repositorio
{
    private readonly string _archivo;

    public Repositorio(string archivo) =>
        _archivo = archivo;

    public void Agregar(List<Personaje> personajes)
    {
        var serializador = new JsonSerializer();

        using var sw = new StreamWriter(_archivo);
        using var writer = new JsonTextWriter(sw);

        serializador.Serialize(sw, personajes);
    }

    public void Cargar(List<Personaje> personajes)
    {
        var serializador = new JsonSerializer();

        using var sr = new StreamReader(_archivo);
        using var reader = new JsonTextReader(sr);
        var list = serializador.Deserialize<List<Personaje>>(reader);

        personajes.AddRange(list);
    }
}