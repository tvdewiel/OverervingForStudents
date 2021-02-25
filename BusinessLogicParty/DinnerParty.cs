using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty
{
    public class DinnerParty : Party
    {
        public double CostOfBeveragesPerPerson;
        public bool HealtyOption;

        public DinnerParty(int numberOfPeople,bool healtyOption,bool fancyDecorations) : base(fancyDecorations,numberOfPeople)
        {
            HealtyOption = healtyOption;
            SetHealtyOption(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
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
