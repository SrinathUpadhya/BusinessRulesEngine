using System;

namespace BusinessRulesEngine
{
    public interface IPaymentForBook
    {
        public bool PaymentForBook(string book);
    }
    public interface IPhysicalproduct
    {
        bool Physicalproduct(string product);
    }

    public class PhysicalProductorPaymentForBook : IPaymentForBook, IPhysicalproduct
    {
        public bool PaymentForBook(string bookType)
        {
            DuplicatepackingslipforRoyaltyDepartment(bookType);
            GenerateComissionpaymentForAgent();
            return true;
        }
        public bool Physicalproduct(string product)
        {
            Generatepackingslipforshipping(product);
            GenerateComissionpaymentForAgent();
            return true;
        }
        private void Generatepackingslipforshipping(string product)
        {
            Console.WriteLine("Generatepackingslipforshipping" + product);
        }
        private void DuplicatepackingslipforRoyaltyDepartment(string bookType)
        {
            Console.WriteLine("DuplicatepackingslipforRoyaltyDepartment" + bookType);
        }
        private void GenerateComissionpaymentForAgent()
        {
            Console.WriteLine("GenerateComissionpaymentForAgent");
        }
    }

}
