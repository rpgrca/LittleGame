namespace LittleGame.Logic;

public class Personaje
{
    public Personaje(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Nombre invalido");
    }
}
