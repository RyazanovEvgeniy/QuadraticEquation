using Equations;

namespace QuadraticEquationTests;

public class QuadraticEquationTests
{
    [Test]
    public void QuadraticEquationSolveTest1()
    {
        // Arrange
        QuadraticEquation equation = new QuadraticEquation(1.0, 0.0, 1.0);

        List<double> expectedResult = new List<double>();
        bool expectedBool = false;

        // Act
        bool actualBool = equation.TrySolve(out List<double> actualResult);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void SolveQuadraticEquationTest2()
    {
        // Arrange
        QuadraticEquation equation = new QuadraticEquation(1.0, 2.0, 1.0);

        List<double> expectedResult = new List<double> { -1.0 };
        bool expectedBool = true;

        // Act
        bool actualBool = equation.TrySolve(out List<double> actualResult);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreEqual(expectedBool, actualBool);
    }

    [Test]
    public void SolveQuadraticEquationTest3()
    {
        // Arrange
        QuadraticEquation equation = new QuadraticEquation(1.0, 4.0, 3.0);

        List<double> expectedResult = new List<double> { -1.0, -3.0 };
        bool expectedBool = true;

        // Act
        bool actualBool = equation.TrySolve(out List<double> actualResult);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreEqual(expectedBool, actualBool);
    }
}