using System;

namespace BusinessRulesEngine
{
    public interface IPaymentForMemberShip
    {
        public void PaymentForActivateMemberShip(string user);
    }

    public interface IPaymentForUpgradeMemberShip
    {
        public void PaymentForUpgradeMemberShip(string user);
    }
    public class PaymentForMemberShiporUpgrade : IPaymentForMemberShip, IPaymentForUpgradeMemberShip
    {
        private const string ACTIVATIONTYPE = "MEMBERSHIP";
        private const string UPGRADEMEMEBRSHIP = "UPGRADEMEMEBRSHIP";

        public void PaymentForActivateMemberShip(string user)
        {
            ActivateMembership(user);
        }

        public void PaymentForUpgradeMemberShip(string user)
        {
            UpgradeMembership(user);
        }

        private void ActivateMembership(string user)
        {
            Console.WriteLine("ActivateMembership");
            EmailUserAbourmemebership(user, ACTIVATIONTYPE);
        }
        private void UpgradeMembership(string user)
        {
            Console.WriteLine("UpgradeMembership");
            EmailUserAbourmemebership(user, UPGRADEMEMEBRSHIP);
        }
        private void EmailUserAbourmemebership(string userName, string activationType)
        {
            if (activationType == "MEMBERSHIP")
            {
                Console.WriteLine("MEMBERSHIP sucessful for user " + userName);
            }
            if (activationType == "UPGRADEMEMEBRSHIP")
            {
                Console.WriteLine("Upgrade sucessful for user " + userName);
            }
        }
    }

}
