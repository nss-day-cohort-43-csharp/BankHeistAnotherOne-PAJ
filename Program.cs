using System;
using System.Collections.Generic;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker();
            Joe.Name = "Joe";
            Hacker Thomas = new Hacker();
            Thomas.Name = "Thomas";
            Muscle Frank = new Muscle();
            Frank.Name = "Frank";
            Muscle Greg = new Muscle();
            Greg.Name = "Greg";
            LockSpecialist Jonny = new LockSpecialist();
            Jonny.Name = "Jonny";
            LockSpecialist Sarah = new LockSpecialist();
            Sarah.Name = "Sarah ManHanderson";


            List<IRobber> rolodex = new List<IRobber>
      {Joe, Thomas, Frank, Greg, Jonny, Sarah
      };
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
            Random random=new Random();
            Bank bank= new Bank(random.Next(50000,1000001), random.Next(101), random.Next(101),random.Next(101));
        }
    }
}
