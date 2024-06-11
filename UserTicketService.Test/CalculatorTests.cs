using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTicketService;

namespace UserTicketService.Test
{
    public class CalculatorTests
    {
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 30);
        }
    }
}
