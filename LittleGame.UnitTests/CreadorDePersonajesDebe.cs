using LittleGame.Logic;

namespace LittleGame.UnitTests;

public class CreadorDePersonajesDebe
{
    [Fact]
    public void RetornarUnPersonajeConDatos()
    {
        var sut = new CreadorDePersonajes();
        var personaje = sut.Crear();
        Assert.NotNull(personaje);
    }
}