using CalculatorLib;
using Xunit;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {

        //Arrange: Set up the inputs and unites under test
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();

        //Act: Execute the function to test
        double actual = calc.Add(a, b);

        //Assert: Make assertions to compare expected to actual results 
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void TestAdding2and3()
    {
        //Arrange
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();

        //Act
        double actual = calc.Add(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }


}
