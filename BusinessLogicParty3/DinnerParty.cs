using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty3
{
    public class DinnerParty : Party
    {
        public double CostOfBeveragesPerPerson;
        public bool HealtyOption;

        public DinnerParty(int numberOfPeople,bool healtyOption,bool fancyDecorations) : base(fancyDecorations,numberOfPeople)
        {
            HealtyOption = healtyOption;
            SetHealtyOption(healtyOption);
            CalculateCostOfDecorations();
        }

        public void SetHealtyOption(bool healtyOption)
        {
            if (healtyOption)
                CostOfBeveragesPerPerson = 5;
            else
                CostOfBeveragesPerPerson = 20;
        }
        public override double CalculateCost()
        {
            Console.Write("*");
            double TotalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);
            if (HealtyOption)
                return TotalCost * 0.95;
            else
                return TotalCost;
        }
        public override string ToString()
        {
            return base.ToString()+$"[Dinner]CostBeverage:{CostOfBeveragesPerPerson},Healty:{HealtyOption}";
        }
    }
}
