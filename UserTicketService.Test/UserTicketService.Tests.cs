using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTicketService.Interfaces;

namespace UserTicketService.Test
{
    internal class UserTicketService
    {
        [TestFixture]
        public class TicketServiceTests
        {
            [Test]
            public void GetTicketPriceMustReturnExistingPrice()
            {
                var ticketServiceTest = new TicketService();
                ClassicAssert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
            }

            [Test]
            public void GetTicketPriceMustThrowException()
            {
                var ticketServiceTest = new TicketService();
                Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
            }

            [Test]
            public void GetTicketMustReturnNotNullableTicket()
            {
                var ticketServiceTest = new TicketService();
                ClassicAssert.IsNotNull(ticketServiceTest.GetTicket(1));
            }
        }
    }
}
