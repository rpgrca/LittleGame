using LittleGame.Logic;

namespace LittleGame.UnitTests;

public class CreadorDePersonajesDebe
{
    [Fact]
    public async void RetornarUnPersonajeConDatos()
    {
        var sut = new CreadorDePersonajes();
        var personaje = await sut.Crear();
        Assert.NotNull(personaje);
    }
}