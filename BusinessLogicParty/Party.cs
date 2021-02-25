using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty
{
    public abstract class Party
    {
        const int CostOfFoodPerPerson = 25;
        public float CostOfDecorations = 10;
        private bool _fancyDecorations;
        private int _numberOfPeople;

        public Party(bool fancyDecorations, int numberOfPeople)
        {
            _fancyDecorations = fancyDecorations;
            _numberOfPeople = numberOfPeople;
        }

        public virtual int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set { 
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecorations);
            }
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
                CostOfDecorations = (NumberOfPeople * 10) + 30;
            }
        }
        public virtual double CalculateCost()
        {
            double TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            if (NumberOfPeople>12)
            {
                TotalCost += 100;
            }
            return TotalCost;
        }
        public override string ToString()
        {
            return $"(Party)[People:{NumberOfPeople},Fancy:{_fancyDecorations},DecorationCost:{CostOfDecorations},FoodCost:{CostOfFoodPerPerson}]";
        }
    }
}
