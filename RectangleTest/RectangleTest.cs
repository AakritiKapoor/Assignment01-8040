using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment01;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle rec = new Rectangle();

        [Test(Description = "Adding two positive integers")]
        public void paremetercheck()
        {
            double l = 10, w = 15;
            rec.SetLength(l);
            rec.SetWidth(w);

            double result = rec.GetPerimeter();
            Assert.AreEqual(result, 50);
        }
        [Test]
        public void area()
        {
            double l = 10, w = 15;
            rec.SetLength(l);
            rec.SetWidth(w);

            double result = rec.GetPerimeter();
            Assert.AreEqual(result, 50);
        }
    }
}
