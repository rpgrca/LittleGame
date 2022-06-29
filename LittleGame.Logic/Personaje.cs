namespace LittleGame.Logic;

public class Personaje
{
    public Personaje(string name)
    {
        if (name == "" || name is null) throw new ArgumentException("Nombre invalido");
    }
}
