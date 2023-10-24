using FigureLibrary;

namespace FigureLibraryTest;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TriangleTest1()
    {
        Triangle triangle = new Triangle(3.0, 4.0, 5.0);
        Assert.AreEqual(6, triangle.GetSquare());
    }

    [TestMethod]
    public void TriangleTest2()
    {
        try 
        {
            Triangle triangle = new Triangle(1.0, 2.0, 3.0);
            Assert.Fail();
        } 
        catch (Exception e) 
        { 
            if (!e.Message.Contains("Is not a triangle, check sides length."))
            {
                Assert.Fail("Assert expected in Triangle()");
            }
        }
    }

    [TestMethod]
    public void TriangleTest3()
    {
        Triangle triangle = new Triangle(13.0, 9.0, 8.0);
        Assert.IsTrue(Figure.DoubleComparer(triangle.GetSquare(), 35.4964786985));
    }

    [TestMethod]
    public void TriangleTest4()
    {
        Triangle triangle = new Triangle(9000.0, 10000.0, 13000.0);
        Assert.IsTrue(Figure.DoubleComparer(triangle.GetSquare(), 44899888.6412873));
    }

    [TestMethod]
    public void TriangleTest5()
    {
        Triangle triangle = new Triangle(5, 12, 13);
        Assert.IsTrue(triangle.CheckIfRectangular());
    }

    [TestMethod]
    public void TriangleTest6()
    {
        Triangle triangle = new Triangle(5, 12, 12);
        Assert.IsFalse(triangle.CheckIfRectangular());
    }

    [TestMethod]
    public void TriangleTest7()
    {
        try 
        {
            Triangle triangle = new Triangle(-3, -4, -5);
            Assert.Fail();
        } 
        catch (Exception e) 
        { 
            if (!e.Message.Contains("Is not a triangle, check sides length."))
            {
                Assert.Fail("Assert expected in Triangle()");
            }
        }
    }
}