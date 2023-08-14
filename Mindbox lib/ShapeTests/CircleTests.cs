using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircleArea()
        {
            var circle = new Mindbox_lib.Models.Circle(3.5);
            var circleArea = Math.Round(circle.CalculateArea(), 2);
            Assert.AreEqual(circleArea, 38.48);
        }
    }
}
