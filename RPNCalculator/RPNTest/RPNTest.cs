using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPNCalculator;
using NUnit.Framework;

namespace RPNTest
{
    [TestFixture()]
    public class RPNTest
    {
        RPNCalculator.RPNCalculator rpnCalc = new RPNCalculator.RPNCalculator();

        [Test]
        [Category("Valid Scenario")]
        public void testAddition2Operands()
        {
            String equation = "1 2 +";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(3, result);
        }

        [Test]
        [Category("Valid Scenario")]
        public void testSubtraction2Operands()
        {
            String equation = "15 5 -";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(10, result);
        }

        [Test]
        [Category("Valid Scenario")]
        public void testMultiplication2Operands()
        {
            String equation = "3 5 *";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(15, result);
        }

        [Test]
        [Category("Valid Scenario")]
        public void testDivision2Operands()
        {
            String equation = "100 5 /";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(20, result);
        }

        [Test]
        [Category("Valid Scenario")]
        public void testFactorial()
        {
            String equation = "5 !";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(120, result);
        }

        [Test]
        [Category("Valid Scenario")]
        public void test3Operands2Operators()
        {
            String equation = "1 2 + 3 -";
            Int64 result = (Int64)rpnCalc.SolveEquation(equation);
            Assert.AreEqual(0, result);
        }

        [Test]
        [Category("InValid Scenario")]
        public void testEmptyString()
        {
            String equation = "";
            try
            {
                String result = (String)rpnCalc.SolveEquation(equation);
                Assert.Fail(result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid String!", ex.Message);
            }
        }

        [Test]
        [Category("InValid Scenario")]
        public void test5Operands3Operators()
        {
            String equation = "2 3 * 4 5 6 - /";
            try
            {
                String result = (String)rpnCalc.SolveEquation(equation);
                Assert.Fail(result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid String!", ex.Message);
            }
        }

        [Test]
        [Category("InValid Scenario")]
        public void test5Operands3Operators()
        {
            String equation = "2 3 * 4 5 6 - /";
            try
            {
                String result = (String)rpnCalc.SolveEquation(equation);
                Assert.Fail(result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid String!", ex.Message);
            }
        }
    }
}
