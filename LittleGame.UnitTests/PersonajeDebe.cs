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
        var exception = Assert.Throws<ArgumentException>(() => new Personaje(nombreInvalido, Tipo.Mago, new DateOnly(2000, 1, 1)));
        Assert.StartsWith("Nombre invalido", exception.Message);
    }

    [Fact]
    public void RetornarElNombreCorrectamente()
    {
        var sut = CreateSubjectUnderTest();
        Assert.Equal("Raistlin", sut.Nombre);
    }

    private static Personaje CreateSubjectUnderTest()
    {
        return new Personaje("Raistlin", Tipo.Mago, new DateOnly(2000, 1, 1));
    }

    [Theory]
    [InlineData("The Sly One")]
    [InlineData("")]
    public void RetornarElApodoCorrectamente(string apodo)
    {
        var sut = CreateSubjectUnderTest();
        sut.Apodo = apodo;

        Assert.Equal(apodo, sut.Apodo);
    }

    [Fact]
    public void RetornarSaludCorrectamente()
    {
        var sut = CreateSubjectUnderTest();
        Assert.Equal(100, sut.Salud);
    }

    [Fact]
    public void RetornarTipoCorrectamente()
    {
        var sut = CreateSubjectUnderTest();
        Assert.Equal(Tipo.Mago, sut.Tipo);
    }

    [Fact]
    public void RetornarNacimientoCorrectamente()
    {
        var sut = CreateSubjectUnderTest();
        Assert.Equal(new DateOnly(2000, 1, 1), sut.Nacimiento);
    }
}