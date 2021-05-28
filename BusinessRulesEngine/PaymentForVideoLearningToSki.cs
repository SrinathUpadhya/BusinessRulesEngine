using System;

namespace BusinessRulesEngine
{
    public interface IPaymentForVideoLearningtoSKI
    {
        bool PaymentForVideoLearningtoSKI(string product);
    }
    public class PaymentForVideoLearningToSki : IPaymentForVideoLearningtoSKI
    {
        public void PaymentForVideoLearningtoSKI(string product)
        {
            AddFirstAidVideoToPackingSlip(product);
            return true;
        }

        private void AddFirstAidVideoToPackingSlip(string product)
        {
            Console.Write("AddFirstAidVideoToPackingSlip for the product" + product);
        }
    }
}
