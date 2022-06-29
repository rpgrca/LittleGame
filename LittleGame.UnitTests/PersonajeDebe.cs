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

    [Fact]
    public void RetornarElNombreCorrectamente()
    {
        var sut = new Personaje("Raistlin");
        Assert.Equal("Raistlin", sut.Nombre);
    }

    [Theory]
    [InlineData("The Sly One")]
    [InlineData("")]
    public void RetornarElApodoCorrectamente(string apodo)
    {
        var sut = new Personaje("Raistlin");
        sut.Apodo = apodo;

        Assert.Equal(apodo, sut.Apodo);
    }

}