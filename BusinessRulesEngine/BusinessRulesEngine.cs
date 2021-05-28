using System;

namespace BusinessRulesEngine
{
    public class BusinessRulesEngine
    {
        static void Main(string[] args)
        {
            Payment payment = new ImplementPayment();
            payment.PaymentForBook(".NET book");
        }
    }

    public interface Payment
    {
        public void Physicalproduct(string product);
        public void PaymentForBook(string bookType);
        public void PaymentForPhysicalproduct();
        public void PaymentForActivateMemberShip(string userName);
        public void UpgradeToMemberShip(string userName);
        public void VideoLearningToSki();

    }

    public interface IPhysicalproduct
    {
        public void Physicalproduct();
    }

    public interface IPaymentForBook
    {
        public void PaymentForBook(string book);
    }

    public interface IPaymentForMemberShip
    {
        public void PaymentForMemberShip();
    }

    public interface IPaymenttoaUpgradeMemberShip
    {
        public void PaymenttoaUpgradeMemberShip();
    }

    public interface IPaymentForVideoLearningSKI
    {
        public void PaymentForVideoLearningSKI();
    }


    //public class ClassPhysicalproduct : Physicalproduct
    //{
    //    public void Physicalproduct()
    //    {
    //        Generatepackingslipforshipping();
    //    }

    //    private void Generatepackingslipforshipping()
    //    {
    //        Console.WriteLine("Generatepackingslipforshipping");
    //    }
    //}

    public class ImplementPayment : Payment
    {
        public void PaymentForActivateMemberShip()
        {
            ActivateMembership();
        }

        public void Physicalproduct(string product)
        {
            Generatepackingslipforshipping(product);
        }
        public void PaymentForBook(string bookType)
        {
            DuplicatepackingslipforRoyaltyDepartment(bookType);
        }

        public void PaymentForPhysicalproduct()
        {
            //Generate Packing sllip for shipping
        }

      

        public void UpgradeToMemberShip()
        {
            UpgradeMembership();
        }

        public void VideoLearningToSki()
        {
            throw new NotImplementedException();
        }

        private void Generatepackingslipforshipping(string product)
        {
            Console.WriteLine("Generatepackingslipforshipping" + product);
        }

        private void DuplicatepackingslipforRoyaltyDepartment(string bookType)
        {
            Console.WriteLine("DuplicatepackingslipforRoyaltyDepartment" + bookType);
        }

        private void ActivateMembership()
        {
            Console.WriteLine("ActivateMembership");
            EmailUserAbourmemebership("", "");
        }

        private void UpgradeMembership()
        {
            Console.WriteLine("UpgradeMembership");
        }

        private void EmailUserAbourmemebership(string userName, string activationType)
        {
            if (activationType == "membership")
            {
                Console.WriteLine("membership sucessful" + userName);
            }
            if(activationType == "Upgrade")
            {
                Console.WriteLine("UpgradeSucessfull" + userName);
            }
        }

        public void PaymentForActivateMemberShip(string userName)
        {
            throw new NotImplementedException();
        }

        public void UpgradeToMemberShip(string userName)
        {
            throw new NotImplementedException();
        }
    }


}
