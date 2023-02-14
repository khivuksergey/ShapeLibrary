using ShapeLibrary.Shapes;

namespace ShapeLibrary.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateObject_NegativeSide_ThrowsException()
        {
            Assert.Catch(() => { Triangle triangle = new(-0.1, 2, 3); });
        }

        [Test]
        public void CreateObject_IncorrectSidesLength_ThrowsException()
        {
            Assert.Catch(() => { Triangle triangle = new(1.2, 3.4, 5.6); });
        }

        [Test]
        public void CreateObject_RightSides_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => { Triangle triangle = new(5.55, 6.666, 7.7777); });
        }

        [Test]
        public void IsRight_NotRight_ReturnsFalse()
        {
            Triangle triangle = new(3.45, 6.789, 8.76543);

            Assert.False(triangle.IsRight());
        }

        [Test]
        public void IsRight_HighPrecision_ReturnsFalse()
        {
            Triangle triangle = new(3.1, 4.2, 5.22);

            Assert.False(triangle.IsRight(1E-6));
        }

        [Test]
        public void IsRight_Right_ReturnsTrue()
        {
            Triangle triangle = new(3, 4, 5);

            Assert.True(triangle.IsRight());
        }

        [Test]
        public void GetArea_SidesAreThreeFourFive_ReturnsSevenAndAHalf()
        {
            Triangle triangle = new(3, 4, 5);

            Assert.That(triangle.Area, Is.EqualTo(6));
        }
    }
}
