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
    }
  }
}
