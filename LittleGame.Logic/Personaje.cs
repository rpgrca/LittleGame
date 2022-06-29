namespace LittleGame.Logic;

public class Personaje
{
    public Personaje(string name)
    {
        if (name == "") throw new ArgumentException("Nombre invalido");
    }
}
