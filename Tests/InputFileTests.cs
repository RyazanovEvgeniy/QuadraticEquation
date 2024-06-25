using Equations;

namespace InputFileTests;

public class InputFileTests
{
    [Test]
    public void ConvertLineToEquationTest1()
    {
        // Arrange
        string line = "2 3 4";
        QuadraticEquation expectedEquation = new QuadraticEquation(2.0, 3.0, 4.0);
        bool expectedBool = true;

        // Act
        bool actualBool = InputFile.TryConvertLineToEquation(line, out QuadraticEquation actualEquation);

        // Assert
        Assert.AreEqual(expectedEquation, actualEquation);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void ConvertLineToEquationTest2()
    {
        // Arrange
        string line = "2 4";
        QuadraticEquation expectedEquation = new QuadraticEquation();
        bool expectedBool = false;

        // Act
        bool actualBool = InputFile.TryConvertLineToEquation(line, out QuadraticEquation actualEquation);

        // Assert
        Assert.AreEqual(expectedEquation, actualEquation);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void ConvertLineToEquationTest3()
    {
        // Arrange
        string line = "2 4 5 47";
        QuadraticEquation expectedEquation = new QuadraticEquation();
        bool expectedBool = false;

        // Act
        bool actualBool = InputFile.TryConvertLineToEquation(line, out QuadraticEquation actualEquation);

        // Assert
        Assert.AreEqual(expectedEquation, actualEquation);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void ConvertLineToEquationTest4()
    {
        // Arrange
        string line = "2,0 4 5,3";
        QuadraticEquation expectedEquation = new QuadraticEquation(2.0, 4.0, 5.3);
        bool expectedBool = true;

        // Act
        bool actualBool = InputFile.TryConvertLineToEquation(line, out QuadraticEquation actualEquation);

        // Assert
        Assert.AreEqual(expectedEquation, actualEquation);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void ConvertLineToEquationTest5()
    {
        // Arrange
        string line = "";
        QuadraticEquation expectedEquation = new QuadraticEquation();
        bool expectedBool = false;

        // Act
        bool actualBool = InputFile.TryConvertLineToEquation(line, out QuadraticEquation actualEquation);

        // Assert
        Assert.AreEqual(expectedEquation, actualEquation);
        Assert.AreEqual(expectedBool, actualBool);
    }
}