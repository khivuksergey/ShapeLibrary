using NUnit.Framework;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateObject_NegativeRadius_ThrowsException()
        {
            Assert.Catch(() => { Circle circle = new(-0.1); });
        }

        [Test]
        public void CreateObject_ZeroRadius_ThrowsException()
        {
            Assert.Catch(() => { Circle circle = new(0); });
        }

        [Test]
        public void GetArea_RadiusEquals1_ReturnsPI()
        {
            Circle circle = new(1);

            Assert.AreEqual(Math.PI, circle.Area);
        }
    }
}