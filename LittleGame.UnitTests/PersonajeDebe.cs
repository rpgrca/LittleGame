using LittleGame.Logic;

namespace LittleGame.UnitTests;

public class PersonajeDebe
{
    [Fact]
    public void LanzarExcepcion_CuandoElPersonajeNoTieneNombre()
    {
        var exception = Assert.Throws<ArgumentException>(() => new Personaje(""));
        Assert.StartsWith("Nombre invalido", exception.Message);
    }
}