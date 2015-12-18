using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CSharpStudy0._20151217160000;

namespace CSharpStudy0._20151217160000Test
{
    [TestFixture]
    public class MaximumTest
    {
        [Test]
        public void TestArgumentException()
        {
            Assert.That("引数を1つ以上設定してください。" == Assert.Throws<ArgumentException>(() => Maximum.Max()).Message);
        }

        [Test]
        public void TestParamNum1()
        {
            decimal expected = 8;
            Assert.AreEqual(expected, Maximum.Max(expected));
        }

        [Test]
        public void TestParamNum2()
        {
            decimal expected1 = 8;
            decimal expected2 = 16;
            Assert.AreEqual(
                System.Math.Max(expected1, expected2),
                Maximum.Max(expected1, expected2));
        }

        [TestCase(0, 65535, Result = 65535)]
        [TestCase(-2147483648, 2147483647, Result = 2147483647)]
        [TestCase(0.0000000001, 0.1, Result = 0.1)]
        [TestCase(-0.005, -0.1, Result = -0.005)]
        [TestCase(50, -0.8, Result = 50)]
        public decimal TestParamNum2_(decimal expected1, decimal expected2)
        {
            return Maximum.Max(expected1, expected2);
        }

        [Test]
        public void TestParamNum3()
        {
            decimal expected1 = 16;
            decimal expected2 = 4;
            decimal expected3 = 8;
            Assert.AreEqual(16, Maximum.Max(expected1, expected2, expected3));
        }

        [TestCase(0, 9, 65535, Result = 65535)]
        [TestCase(0, 65535, 9, Result = 65535)]
        [TestCase(9, 65535, 0, Result = 65535)]
        [TestCase(9, 0, 65535, Result = 65535)]
        [TestCase(65535, 9, 0, Result = 65535)]
        [TestCase(65535, 0, 9, Result = 65535)]
        [TestCase(0.0000000001, 0.7, 39, Result = 39)]
        [TestCase(0.7, 0.0000000001, 39, Result = 39)]
        [TestCase(39, 0.7, 0.0000000001, Result = 39)]
        [TestCase(-2147483648, -0.1, 2147483647, Result = 2147483647)]
        public decimal TestParamNum3_(decimal expected1, decimal expected2, decimal expected3)
        {
            return Maximum.Max(expected1, expected2, expected3);
        }

        [Test]
        public void TestParamNum4()
        {
            decimal expected1 = 7;
            decimal expected2 = -2;
            decimal expected3 = 0;
            decimal expected4 = 8;
            Assert.AreEqual(8, Maximum.Max(expected1, expected2, expected3, expected4));
        }

        [TestCase(0, 9, 898, 65535, Result = 65535)]
        [TestCase(0, 9, 65535, 898, Result = 65535)]
        [TestCase(0, 898, 9, 65535, Result = 65535)]
        [TestCase(0, 898, 65535, 9, Result = 65535)]
        [TestCase(0, 65535, 9, 898, Result = 65535)]
        [TestCase(0, 65535, 898, 9, Result = 65535)]

        [TestCase(9, 0, 898, 65535, Result = 65535)]
        [TestCase(9, 0, 65535, 898, Result = 65535)]
        [TestCase(898, 0, 9, 65535, Result = 65535)]
        [TestCase(898, 0, 65535, 9, Result = 65535)]
        [TestCase(65535, 0, 9, 898, Result = 65535)]
        [TestCase(65535, 0, 898, 9, Result = 65535)]

        [TestCase(9, 898, 0, 65535, Result = 65535)]
        [TestCase(9, 65535, 0, 898, Result = 65535)]
        [TestCase(898, 9, 0, 65535, Result = 65535)]
        [TestCase(898, 65535, 0, 9, Result = 65535)]
        [TestCase(65535, 9, 0, 898, Result = 65535)]
        [TestCase(65535, 898, 0, 9, Result = 65535)]

        [TestCase(9, 898, 65535, 0, Result = 65535)]
        [TestCase(9, 65535, 898, 0, Result = 65535)]
        [TestCase(898, 9, 65535, 0, Result = 65535)]
        [TestCase(898, 65535, 9, 0, Result = 65535)]
        [TestCase(65535, 9, 898, 0, Result = 65535)]
        [TestCase(65535, 898, 9, 0, Result = 65535)]

        [TestCase(-2147483648, 59.6, -0.038, 2147483647, Result = 2147483647)]
        public decimal TestParamNum4_(decimal expected1, decimal expected2, decimal expected3, decimal expected4)
        {
            return Maximum.Max(expected1, expected2, expected3, expected4);
        }

    }
}
