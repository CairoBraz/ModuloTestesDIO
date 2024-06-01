namespace CalculadoraTestes;
using Calculadora.Services;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange ->Montar o cenário
        int num1 = 5;
        int num2 = 10;

        //Act -> Chamar a ação
        var resultado = _calc.Somar(num1, num2);

        //Assert -> Validar o resultado esperado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange ->Montar o cenário
        int num1 = 10;
        int num2 = 10;

        //Act -> Chamar a ação
        var resultado = _calc.Somar(num1, num2);

        //Assert -> Validar o resultado esperado
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        var resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 4, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numero)
    {
        //Act /assert
        Assert.All(numero, num => Assert.True(_calc.EhPar(num)));

    }
}
