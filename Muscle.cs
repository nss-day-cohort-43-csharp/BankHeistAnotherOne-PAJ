using System;
namespace BankHeist{
    public class Muscle:IRobber{
        public string Name { get; set; }
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}
        public void PerformSkill(Bank bank){
            bank.SecurityGuardScore-=SkillLevel;
            System.Console.WriteLine($"{Name} is attacking the guards. decreased security {SkillLevel} poins.");
            if(bank.AlarmScore<=0){
                System.Console.WriteLine($"{Name} has knocked out the guards.");
            }
        }
    }
}