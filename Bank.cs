using System;
using System.Collections.Generic;
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

        public List<string> compair(){
            List<string> recon=new List<string>();
            if(AlarmScore>VaultScore&&AlarmScore>SecurityGuardScore){
                recon.Add("Alarm");
                if(VaultScore>SecurityGuardScore){
                    recon.Add("Security Guard");
                }
                else{
                    recon.Add("Vault");
                }
            }
            else if (VaultScore>SecurityGuardScore){
                recon.Add("vault");
                if(AlarmScore>SecurityGuardScore){
                    recon.Add("Security Guard");
                }else{recon.Add("Alarm");}
            }else{
                recon.Add("Security Guard");
                if(VaultScore>AlarmScore){
                    recon.Add("Alaram");
                }else{recon.Add("Vault");}
            }
            return recon;
        }
    }
}
