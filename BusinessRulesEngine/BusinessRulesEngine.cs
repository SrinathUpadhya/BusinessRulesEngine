using System;

namespace BusinessRulesEngine
{
    public class BusinessRulesEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Order processing");
            IPhysicalproduct physicalproductForBook = new PhysicalProductorPaymentForBook();
            physicalproductForBook.Physicalproduct("Shipping book");
            IPaymentForBook physicalProductorPaymentForBook = new PhysicalProductorPaymentForBook();
            physicalProductorPaymentForBook.PaymentForBook("Shipping book");

        }
    }
}
