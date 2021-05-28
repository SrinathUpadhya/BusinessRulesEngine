using System;

namespace BusinessRulesEngine
{
    public class BusinessRulesEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Order processing");
            PhysicalProductorPaymentForBook physicalProductorPaymentForBook = new PhysicalProductorPaymentForBook();
            physicalProductorPaymentForBook.Physicalproduct("Shipping book");
            physicalProductorPaymentForBook.PaymentForBook("Shipping book");

        }
    }
}
