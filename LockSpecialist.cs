using System;
namespace BankHeist{
    public class LockSpecialist:IRobber{
        public string Name { get; set; }
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}
        public void PerformSkill(Bank bank){
            bank.VaultScore-=SkillLevel;
            System.Console.WriteLine($"{Name} is Unlocking the vault. decreased security {SkillLevel} poins.");
            if(bank.AlarmScore<=0){
                System.Console.WriteLine($"{Name} has unlocked the vault.");
            }
        }
    }
}