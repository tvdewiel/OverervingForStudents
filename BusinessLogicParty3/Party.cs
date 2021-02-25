using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty3
{
    public abstract class Party
    {
        const int CostOfFoodPerPerson = 25;
        public double CostOfDecorations = 0;
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
                CalculateCostOfDecorations();
            }
        }
        public void SetFancyOption(bool fancy = true)
        {
            _fancyDecorations = fancy;
            CalculateCostOfDecorations();
        }
        protected void CalculateCostOfDecorations()
        {
            if (_fancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15) + 50;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5) + 30;
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
