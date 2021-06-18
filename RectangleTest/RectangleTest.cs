﻿using System;
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

        [Test]
        public void Setting_negative_length()
        {
         //ARRANGE
            double l = -10.0, w = 15.02;
         //ACT and ASSERT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetLength(l));
            rec.SetWidth(w);
           
            Assert.That(ex.Message.Contains("Invalid dimension"));
           
        }
        [Test]
        public void Setting_negative_Width()
        {
            //ARRANGE
            double l =10.0, w = -15.01;
            //ACT
            rec.SetLength(l);
            //ASSERT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetWidth(w));
            Assert.That(ex.Message.Contains("Invalid dimension"));

        }
        [Test]
        public void Setting_zero_length()
        {
            //ARRANGE
            double l = 0, w = 10;
            //ACT
            rec.SetWidth(w);
            //ASSERT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetLength(l));
            Assert.That(ex.Message.Contains("Invalid dimension"));

        }
        [Test]
        public void Setting_zero_width()
        {  //ARRANGE
            double l = 10, w =0;
            //ACT and ASSET
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetWidth(w));
            rec.SetLength(l);
            Assert.That(ex.Message.Contains("Invalid dimension"));

        }
        [Test]
        public void Setting_negative_length_and_width()
        {
            //ARRANGE
            double l = -10, w = -15;
            //ACT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetLength(l));
            var ex2 = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetWidth(w));
            //ASSERT
            Assert.That(ex.Message.Contains("Invalid dimension"));
            Assert.That(ex2.Message.Contains("Invalid dimension"));
            
        }
        [Test]
        public void Get_Neg_Width()
        {
            //ARRANGE
            double w = -22;
            //ACT AND ASSERT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetWidth(w));
            Assert.That(ex.Message.Contains("Invalid dimension"));

            double actual_Width = rec.GetWidth();
            Assert.NotNull(actual_Width);


        }
        [Test]
        public void CalculatePerimeter()
        {
            //ARRANGE
            double l = 10.3, w = 15;
            //ACT
            rec.SetLength(l);
            rec.SetWidth(w);
            double result = rec.GetPerimeter();
            //ASSERT
            Assert.AreEqual(50.6, result);

        }
        [Test]
        public void Calculate_perimeter_withDecimal()
        {
            //ARRANGE
            double l = 10.3, w = 15.02;
            //ACT
            rec.SetLength(l);
            rec.SetWidth(w);
            double result = rec.GetPerimeter();
            //ASSERT
            Assert.AreEqual(50.64, result);

        }
        [Test]
        public void Area_with_whole_number_values()
        {
            //ARRANGE
            double l = 18, w = 15;
            //ACT
            rec.SetLength(l);
            rec.SetWidth(w);
            var result = rec.GetArea();
            //ASSERT
            Assert.AreEqual(270.0, result);
        }


        [Test]
        public void Area_decimal_value()
        {
            //ARRANGE
            double l = 18.024, w = 15.02;
            //ACT
            rec.SetLength(l);
            rec.SetWidth(w);
            var  result = rec.GetArea();
            //ASSERT
            Assert.AreEqual(270.72, result);
        }

        [Test]
        public void Get_width()
        {
            //ASSERT
            double w = 15.01;
            //ACT
            rec.SetWidth(w);
            double actualWidth=rec.GetWidth();
            //ASSERT
            Assert.AreEqual(15.01,actualWidth);

        }
        [Test]
        public void Get_length()
        {
            //ARRANGE
            double l = 22;
            //ACT
            rec.SetLength(l);
            double actual_Length = rec.GetLength();
            //ASSERT
            Assert.AreEqual(22, actual_Length);

        }
        [Test]
        public void Get_Neg_length()
        {
            //ARRANGE
            double l =-22;
            //ACT AND ASSERT
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => rec.SetLength(l));
            Assert.That(ex.Message.Contains("Invalid dimension"));
            
            double actual_Length = rec.GetLength();
            Assert.NotNull(actual_Length);
           

        }
       
    }
}
