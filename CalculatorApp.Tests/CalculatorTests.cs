using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CalculatorApp;
using Xunit;

public class CalculatorTests
{
    Calculator calc = new Calculator();

    [Fact]
    public void Add_Works() => Assert.Equal(5, calc.Add(2, 3));

    [Fact]
    public void Sub_Works() => Assert.Equal(1, calc.Sub(3, 2));

    [Fact]
    public void Mul_Works() => Assert.Equal(6, calc.Mul(2, 3));

    [Fact]
    public void Div_Works() => Assert.Equal(2, calc.Div(4, 2));

    [Fact]
    public void Div_ByZero_Throws() =>
        Assert.Throws<DivideByZeroException>(() => calc.Div(5, 0));
}