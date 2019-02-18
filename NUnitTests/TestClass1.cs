using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;
using Model;

namespace NUnitTests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestAdd()
        {
            int actual = Maths.MathsHelpers.add(2, 3);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1,2)]
        [TestCase(2,2,4)]
        [TestCase(-1,-1,-2)]
        public void TestAddLocalData(int a, int b, int expected)
        {
            int actual = Maths.MathsHelpers.add(a, b);
            Assert.AreEqual(expected, actual);
        }


        [Test, TestCaseSource(typeof(TestData), "GetTestData")]
        public void AddTestWithDataFromDatabase(TestData myTest)
        {
            int actual = Maths.MathsHelpers.add(myTest.a, myTest.b);
            Assert.AreEqual(myTest.expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            var context = TestContext.CurrentContext;
            int testPass = context.Result.PassCount;
            int testFail = context.Result.FailCount;
            var assertions = context.Result.Assertions;
            var currentMethod = context.Test.MethodName;
            var result = context.Result.Outcome.ToString();
            CDTResult myResults = new CDTResult(currentMethod, result);
            ResultsMethods.AddResult(myResults);

        }

    }
}
