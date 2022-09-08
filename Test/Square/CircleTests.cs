using System;
using Calculator.Square.Figures;
using NUnit.Framework;

namespace Calculator.Test.Square;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CircleNegativeRadiusShouldThrowError()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0, 0, -3));
    }
		
    [Test]
    public void CircleSquareCalculate()
    {
        var circle = new Circle(0, 0, 3);

        Assert.AreEqual(28.274333882308138, circle.Square);
    }
}