using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void setUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            int expected, actual;
          //  Caculation c = new Caculation(10, 5);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected,actual);
                
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
         //   Caculation c = new Caculation(10, 5);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
         //   Caculation c = new Caculation(10, 5);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
          //  Caculation c = new Caculation(10, 5);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        public void TestWithDataSource()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Caculation(a, b);
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);

        }
   

    }
}
