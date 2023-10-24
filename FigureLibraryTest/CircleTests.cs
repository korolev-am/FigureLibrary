using FigureLibrary;

namespace FigureLibraryTest;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CircleTest1()
    {
        Circle circle = new Circle(3);
        Assert.IsTrue(Figure.DoubleComparer(circle.GetSquare(), 28.2743338815));
    }

    [TestMethod]
    public void CircleTest2()
    {
        Circle circle = new Circle(900);
        Assert.IsTrue(Figure.DoubleComparer(circle.GetSquare(), 2544690.049335, 0.001));
    }

    [TestMethod]
    public void CircleTest3()
    {
        try 
        {
            Circle circle = new Circle(-1);
            Assert.Fail();
        }
        catch(Exception e)
        {
            if (!e.Message.Contains("Radius should be non-negative."))
            {
                Assert.Fail("Assert expected in Circle()");
            }
        }
    }

    [TestMethod]
    public void CircleTest4()
    {
        Circle circle = new Circle(0);
        Assert.AreEqual(0, circle.GetSquare());
    }
}