using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace UserTicketService.Test
{
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(50, 10);
            ClassicAssert.AreEqual(60, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Miltiplication(3, 2);
            ClassicAssert.AreEqual(6, result);
        }
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(3, 2);
            ClassicAssert.AreEqual(1, result);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(10, 3);
            ClassicAssert.AreEqual(3, result);
        }
    }
}
