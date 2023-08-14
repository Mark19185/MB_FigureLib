using Mindbox_lib.Models;

namespace ShapeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Проверка на существование такого треугольника
        /// </summary>
        [Test]
        public void TestTrinagleExistence()
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(new List<double> { 6, 2, 9 }); });
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(new List<double> { 6, 6, 8 });
            var area = Math.Round(triangle.CalculateArea(), 2);

            Assert.AreEqual(area, 17.89);
        }


        /// <summary>
        /// Проверка на равносторонность
        /// </summary>
        [Test]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(new List<double> { 6, 6, 6 });
            var isRight = triangle.IsRightTriangle();

            Assert.IsTrue(isRight);
        }

        [Test]
        public void TestRectangular()
        {
            var triangle = new Triangle(new List<double> { 6, 8, 10 });
            var isRect = triangle.IsRectangular();

            Assert.IsTrue(isRect);
        }
    }
}