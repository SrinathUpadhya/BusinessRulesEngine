using BusinessRulesEngine;
using Xunit;

namespace BusinessRulesEngineTest
{
    public class PaymentForVideoLearningToSkiTest
    {
        private IPaymentForVideoLearningtoSKI _PaymentForVideoLearningtoSKI = null;

        public PaymentForVideoLearningToSkiTest()
        {
            _PaymentForVideoLearningtoSKI = new PaymentForVideoLearningToSki();
        }

        [Fact]
        public void PaymentForVideoLearningTest()
        {
            Assert.True(_PaymentForVideoLearningtoSKI.PaymentForVideoLearningtoSKI("Learning to Ski"));
        }
    }
}
