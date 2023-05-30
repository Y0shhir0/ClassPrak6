using ClassPrak6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]  
            public void Zadanie1TestMehod1()
            {
            int[,] matrix = new int[8, 8] {
            { 1, 2, 3, 4, 5, 6, 7, 8 },
            { 9, 10, 11, 12, 13, 14, 15, 16 },
            { 17, 18, 19, 20, 21, 22, 23, 24 },
            { 25, 26, 27, 28, 29, 30, 31, 32 },
            { 33, 34, 35, 36, 37, 38, 39, 40 },
            { 41, 42, 43, 44, 45, 46, 47, 48 },
            { 49, 50, 51, 52, 53, 54, 55, 56 },
            { 57, 58, 59, 60, 61, 62, 63, 64 }  };
            Class1 class1Obj = new Class1(matrix);
            int maxElement = class1Obj.Zadanie1();
            Assert.AreEqual(64, maxElement);
        }
        [TestMethod]
        public void Zadanie1TestMehod2()
        {
            int[,] matrix = new int[8, 8]  {       
            { -1, -2, -3, -4, -5, 6, -7, -8 },
            { -9, -10, -11, -12, -13, -14, -15, -16 },
            { -17, -18, -19, -20, -21, -22, -23, -24 },
            { -25, -26, -27, -28, -29, -30, -31, -32 },
            { -33, -34, -35, 7, -37, -38, 39, -40 },
            { -41, -42, -43, -44, -45, -46, -47, -48 },
            { -49, -50, 51, -52, -53, -54, -55, -56 },
            { -57, -58, -59, -60, -61, -62, -63, -64 } };
            Class1 class1Obj = new Class1(matrix);
            int maxElement = class1Obj.Zadanie1();
            Assert.AreEqual(51, maxElement);
        }


        [TestMethod] 
        public void Zadanie2TestMehod1()
        {
            int[,] matrix = new int[8, 8];
            Class1 obj = new Class1(matrix);

            int[] expected = new int[0];
            int[] actual = obj.Zadanie2();

            Assert.AreEqual(expected.Length, actual.Length);
        }
        [TestMethod]
        public void Zadanie2TestMehod3()
        {
            int[,] matrix = new int[8, 8];
            Class1 obj = new Class1(matrix);

            int[] expected = new int[0];
            int[] actual = obj.Zadanie2();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
