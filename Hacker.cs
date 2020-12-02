using System;
namespace BankHeist
{
  public class Hacker : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.AlarmScore -= SkillLevel;
      System.Console.WriteLine($"{Name} is hacking the alarm system. decreased security {SkillLevel} poins.");
      if (bank.AlarmScore <= 0)
      {
        System.Console.WriteLine($"{Name} has disabled the alarms.");
      }
    }
    public string getSpec()
    {
      return "Hacker";
    }
  }
}