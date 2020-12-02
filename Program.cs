using System;
using System.Collections.Generic;
using System.Linq;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker();
            Joe.Name = "Joe";
            Joe.SkillLevel = 76;
            Joe.PercentageCut = 40;
            Hacker Thomas = new Hacker();
            Thomas.Name = "Thomas";
            Thomas.SkillLevel = 69;
            Thomas.PercentageCut = 20;
            Muscle Frank = new Muscle();
            Frank.Name = "Frank";
            Frank.SkillLevel = 49;
            Frank.PercentageCut = 15;
            Muscle Greg = new Muscle();
            Greg.Name = "Greg";
            Greg.SkillLevel = 75;
            Greg.PercentageCut = 40;
            LockSpecialist Jonny = new LockSpecialist();
            Jonny.Name = "Jonny";
            Jonny.SkillLevel = 49;
            Jonny.PercentageCut = 15;
            LockSpecialist Sarah = new LockSpecialist();
            Sarah.Name = "Sarah ManHanderson";
            Sarah.SkillLevel = 70;
            Sarah.PercentageCut = 35;



            List<IRobber> rolodex = new List<IRobber>
            {
                Joe, Thomas, Frank, Greg, Jonny, Sarah
            };

            List<IRobber> crew = new List<IRobber> { };

            void printRolodox(List<IRobber> crew)
            {
                foreach (IRobber recruit in rolodex)
                {
                    if (!crew.Exists(x => x.Name == recruit.Name) && crew.Sum(x => x.PercentageCut) + recruit.PercentageCut <= 100)
                    {
                        Console.WriteLine($"Enter {rolodex.IndexOf(recruit)} for -- {recruit.Name} -- Specialty: {recruit.getSpec()} -- Skill Level: {recruit.SkillLevel} -- Percentage Cut: {recruit.PercentageCut}");
                    }
                }

            }
            void printCrew()
            {
                Console.WriteLine("Here's your crew.");
                foreach (IRobber recruit in crew)
                {
                    Console.WriteLine($"{recruit.Name} -- Specialty: {recruit.getSpec()} -- Skill Level: {recruit.SkillLevel} -- Percentage Cut: {recruit.PercentageCut}");
                }
            }

            // This is the naming and creation of new crew members in the rolodex - hirable members
            while (true)
            {
                Console.WriteLine($"Current Operatives: {rolodex.Count}");
                Console.Write("What's the new operative's name: ");
                string name = Console.ReadLine();
                if (name.Equals(""))
                {
                    break;
                }
                Console.WriteLine("");
                Console.Write($"{name}'s specialty is(Hacker,Muscle,LockSpecialist): ");
                string speciality = Console.ReadLine();
                Console.WriteLine("");
                while (true)
                {
                    Console.Write($"This {speciality}'s skill level between 1 and 100: ");
                    string tempSkill = Console.ReadLine();
                    int skLvl;
                    if (Int32.TryParse(tempSkill, out skLvl))
                    {
                        if (speciality.Equals("Hacker"))
                        {
                            rolodex.Add(new Hacker()
                            {
                                Name = name,
                                SkillLevel = skLvl
                            });
                        }
                        else if (speciality.Equals("Muscle"))
                        {
                            rolodex.Add(new Muscle()
                            {
                                Name = name,
                                SkillLevel = skLvl
                            });
                        }
                        else if (speciality.Equals("LockSpecialist"))
                        {
                            rolodex.Add(new LockSpecialist()
                            {
                                Name = name,
                                SkillLevel = skLvl
                            });
                        }
                        break;
                    }


                }

            }
            Random random = new Random();
            Bank bank = new Bank(random.Next(50000, 1000001), random.Next(101), random.Next(101), random.Next(101));
            List<string> recon = bank.compair();
            System.Console.WriteLine($"The most secure system is {recon[0]}");
            System.Console.WriteLine($"The least secure system is {recon[1]}");

            //   This will be the while loop for creating a crew.
            while (true)
            {
                printRolodox(crew);
                Console.WriteLine("");
                Console.WriteLine("Who would you like to recruit to your crew?");
                try
                {
                    string input = Console.ReadLine();
                    if (input == "") { break; }
                    int userChoice = Int32.Parse(input);
                    crew.Add(rolodex[userChoice]);
                }
                catch
                {
                    Console.WriteLine("Did you enter a whole number?");
                }
            }
            printCrew();
            foreach(IRobber robber in crew){
                robber.PerformSkill(bank);
            }
            if(!bank.IsSecure()){
                System.Console.WriteLine("The bank is still secure. Heist failed");
            }else{
                System.Console.WriteLine("WE DID IT!!! Heist successful");
                double totalPayout=0;
                System.Console.WriteLine(bank.CashOnHand);
                foreach(IRobber member in crew){
                    double memberPay=bank.CashOnHand*(member.PercentageCut/100.00);
                    System.Console.WriteLine($"{member.PercentageCut}");
                    System.Console.WriteLine($"{member.Name} is payed ${memberPay}");
                    totalPayout+=memberPay;
                }
                double myPay=bank.CashOnHand-totalPayout;
                System.Console.WriteLine($"I earned a total of ${myPay}");
                }
        }
    }
}
