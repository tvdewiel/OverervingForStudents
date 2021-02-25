using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty1
{
    public class DinnerParty 
    {
        const int CostOfFoodPerPerson = 25;
        public float CostOfDecorations=0;
        private bool _fancyDecorations;
        private int _numberOfPeople;
        public int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecorations);
            }
        }
        public double CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople,bool healtyOption,bool fancyDecorations) 
        {
            _fancyDecorations = fancyDecorations;
            _numberOfPeople = numberOfPeople;
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
        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            _fancyDecorations = fancyDecorations;
            if (fancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15) + 50;
            }
            else
            {
                CostOfDecorations = (float)((NumberOfPeople * 7.5) + 30);
            }
        }
        public double CalculateCost(bool healtyOption)
        {
            double TotalCost = CostOfDecorations + ((CostOfBeveragesPerPerson+CostOfFoodPerPerson) * NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                TotalCost += 100;
            }
            if (healtyOption)
                return TotalCost * 0.95;
            else
                return TotalCost;
        }
        public override string ToString()
        {
            return $"[Dinner]CostBeverage:{CostOfBeveragesPerPerson},People:{NumberOfPeople},Fancy:{_fancyDecorations},DecorationCost:{CostOfDecorations},FoodCost:{CostOfFoodPerPerson}]";
        }
    }
}
