namespace LittleGame.Logic;

public class ListadoDeGanadores
{
    private readonly string _archivo;

    public ListadoDeGanadores(string archivo)
    {
        _archivo = archivo;
    }

    public void Agregar(Personaje ganador, Personaje perdedor)
    {
        File.AppendAllText(_archivo, $"{ganador.Nombre},{ganador.Salud},{perdedor.Nombre},{perdedor.Salud}");
    }
}