using LittleGame.Logic;

namespace LittleGame.UnitTests;

public class PersonajeDebe
{
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData(" ")]
    public void LanzarExcepcion_CuandoElPersonajeNoTieneNombre(string nombreInvalido)
    {
        var exception = Assert.Throws<ArgumentException>(() => new Personaje(nombreInvalido));
        Assert.StartsWith("Nombre invalido", exception.Message);
    }
}