using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Outline;

namespace OutlineTests
{
    public class OutlineUnitTests
    {
        [TestCase(new string[0], new string[0])]
        [TestCase(new[]{"0,0,1,1"}, new[]{"0,0", "0,1", "1,1", "1,0"})]
        public void BuildingsHaveOutline(string[] buildingSpecs, string[] pointSpecs)
        {
            var buildings = ParseBuildings(buildingSpecs);
            var expectedPoints = ParsePoints(pointSpecs);
            var outline = OutlineGenerator.GenerateOutline(buildings);
            Assert.That(outline, Is.EqualTo(expectedPoints));
        }

        private static CartesianBuilding[] ParseBuildings(string[] buildingSpecs)
        {
            return buildingSpecs.Select(b =>
            {
                var xywh = b.Split(',').Select(int.Parse).ToArray();
                Assert.That(xywh.Length, Is.EqualTo(4));
                return new CartesianBuilding(){X = xywh[0], Y = xywh[1], W = xywh[2], H = xywh[3]};
            }).ToArray();
        }

        private Point[] ParsePoints(string[] pointSpecs)
        {
            return pointSpecs.Select(b =>
            {
                var xy = b.Split(',').Select(int.Parse).ToArray();
                Assert.That(xy.Length, Is.EqualTo(2));
                return new Point(xy[0], xy[1]);
            }).ToArray();
        }
    }
}
