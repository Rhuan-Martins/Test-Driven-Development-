using Calculadora.Console.Models;

namespace Calculadora.Teste;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSoma(int num1, int num2, int resultado)
    {
        CalculadoraC calc = new CalculadoraC();

        int resultadoCalc = calc.Somar(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (3, 2, 1)]
    [InlineData (10, 5, 5)]
    public void TestSubtrair(int num1, int num2, int resultado)
    {
        CalculadoraC calc = new CalculadoraC();

        int resultadoCalc = calc.Subtrair(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (5, 5, 25)]
    [InlineData (4, 1, 4)]
    public void TestMultiplicar(int num1, int num2, int resultado)
    {
        CalculadoraC calc = new CalculadoraC();

        int resultadoCalc = calc.Multiplicar(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (4, 4, 1)]
    [InlineData (50, 5, 10)]
    public void TestDividir(int num1, int num2, int resultado)
    {
        CalculadoraC calc = new CalculadoraC();

        int resultadoCalc = calc.Dividir(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }
    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraC calc = new CalculadoraC();

        Assert.Throws<DivideByZeroException>(
          () => calc.Dividir(3,0)
        );

    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraC calc = new CalculadoraC();

        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(3,7);
        calc.Somar(4,1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }



}