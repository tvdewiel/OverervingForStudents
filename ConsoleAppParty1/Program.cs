using BusinessLogicParty1;
using System;
using System.Collections.Generic;

namespace ConsoleAppParty1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            List<DinnerParty> parties = new List<DinnerParty>();
            DinnerParty dp1 = new DinnerParty(5, true, true);
            DinnerParty dp2 = new DinnerParty(15, true, true);
            DinnerParty dp3 = new DinnerParty(10, true, false);
            parties.Add(dp1); parties.Add(dp2); parties.Add(dp3);
            foreach (DinnerParty p in parties)
            {
                Console.WriteLine($"{p},healty:{p.CalculateCost(true)},not healty:{p.CalculateCost(false)}");
            }
            //dp1.NumberOfPeople = 15;
            //foreach (DinnerParty p in parties)
            //{
            //    Console.WriteLine($"{p},healty:{p.CalculateCost(true)},not healty:{p.CalculateCost(false)}");
            //}
            List<BirthdayParty> bparties = new List<BirthdayParty>();
            BirthdayParty bp1 = new BirthdayParty("hip hip", 4, false);
            BirthdayParty bp2 = new BirthdayParty("hip hip few", 4, true);
            BirthdayParty bp3 = new BirthdayParty("hip hip many", 14, false);
            BirthdayParty bp4 = new BirthdayParty("hip hip me", 1, true);
            bparties.Add(bp1); bparties.Add(bp2); bparties.Add(bp3); bparties.Add(bp4);
            foreach (BirthdayParty p in bparties)
            {
                Console.WriteLine($"{p},{p.CalculateCost()}");
            }
        }
    }
}
