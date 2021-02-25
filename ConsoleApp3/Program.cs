using BusinessLogicParty3;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Party> parties = new List<Party>();
            DinnerParty dp1 = new DinnerParty(5, false, false);
            DinnerParty dp2 = new DinnerParty(15, true, true);
            DinnerParty dp3 = new DinnerParty(10, true, false);
            Console.WriteLine($"{dp1},kost:{dp1.CalculateCost()}");
            dp1.SetFancyOption();
            Console.WriteLine($"{dp1},kost:{dp1.CalculateCost()}");
            Console.WriteLine("------");
            //Console.WriteLine($"{dp1},cost:{dp1.CalculateCost()},healty:{dp1.CalculateCost(true)},not healty:{dp1.CalculateCost(false)}");
            //Console.WriteLine($"{dp2},cost:{dp2.CalculateCost()},healty:{dp2.CalculateCost(true)},not healty:{dp2.CalculateCost(false)}");
            //Console.WriteLine($"{dp3},cost:{dp3.CalculateCost()},healty:{dp3.CalculateCost(true)},not healty:{dp3.CalculateCost(false)}");
            parties.Add(dp1); parties.Add(dp2); parties.Add(dp3);
            BirthdayParty bp1 = new BirthdayParty("hip hip", 4, false);
            BirthdayParty bp2 = new BirthdayParty("hip hip few", 4, true);
            BirthdayParty bp3 = new BirthdayParty("hip hip many", 14, false);
            BirthdayParty bp4 = new BirthdayParty("hip hip me", 1, true);
            parties.Add(bp1); parties.Add(bp2); parties.Add(bp3); parties.Add(bp4);
            foreach (Party p in parties)
            {
                Console.WriteLine($"{p},{p.CalculateCost()}");
            }
        }
    }
}
