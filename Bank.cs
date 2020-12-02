using System;

namespace BankHeist
{
    public class Bank
    {
        public Bank(int cash, int alarm, int vault, int guard){
            CashOnHand=cash;
            AlarmScore=alarm;
            VaultScore=vault;
            SecurityGuardScore=guard;
        }
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure()
        {
            if (AlarmScore + VaultScore + SecurityGuardScore <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
