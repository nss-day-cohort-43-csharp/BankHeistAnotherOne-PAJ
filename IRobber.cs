using System;

namespace BankHeist
{
    public interface IRobber
    {
        string Name { get; }
        int SkillLevel { get; }
        int PercentageCut { get; }
        void PerformSkill(Bank bank);
    }
}