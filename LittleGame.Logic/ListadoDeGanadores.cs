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