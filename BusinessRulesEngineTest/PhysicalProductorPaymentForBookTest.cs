using BusinessRulesEngine;
using Moq;
using Xunit;

namespace BusinessRulesEngineTest
{
    public class PhysicalProductorPaymentForBookTest
    {
        private PhysicalProductorPaymentForBook _ProductorPaymentForBook;

        public PhysicalProductorPaymentForBookTest()
        {
            _ProductorPaymentForBook = new PhysicalProductorPaymentForBook();
        }
        [Fact]
        public void PaymentForBookTest() 
        {
            Assert.True(_ProductorPaymentForBook.PaymentForBook("Shipping book"));
        }
        [Fact]
        public void PaymentForPhysicalProdcutTest()
        {
            Assert.True(_ProductorPaymentForBook.Physicalproduct("Physical Product"));
        }
    }
}
