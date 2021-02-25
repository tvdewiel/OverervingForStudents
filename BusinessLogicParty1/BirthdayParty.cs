using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty1
{
    public class BirthdayParty 
    {
        public int CakeSize;
        private string _cakeWriting = "";
        const int CostOfFoodPerPerson = 25;
        public float CostOfDecorations = 10;
        private bool _fancyDecorations;
        private int _numberOfPeople;

        public BirthdayParty(string cakeWriting, int numberOfPeople,bool fancyDecorations) 
        {
            _fancyDecorations = fancyDecorations;
            _numberOfPeople = numberOfPeople;
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        public string CakeWriting
        {
            get { return _cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 20) maxLength = 16; else maxLength = 40;
                if (value.Length > maxLength)
                {
                    if (maxLength > _cakeWriting.Length)
                    {
                        maxLength = _cakeWriting.Length;
                    }
                    CakeWriting = _cakeWriting.Substring(0, maxLength);
                }
                else _cakeWriting = value;
            }
        }
        public int NumberOfPeople {
            get { return _numberOfPeople; }
            set
            {
                NumberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecorations);
                CalculateCakeSize();
                CakeWriting = _cakeWriting;
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
        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4) CakeSize = 20; else CakeSize = 40;
        }
        public double CalculateCost()
        {
            double TotalCost = CostOfDecorations + (CostOfFoodPerPerson* NumberOfPeople);
            double CakeCost;
            if (CakeSize == 20)
            {
                CakeCost = 40 + CakeWriting.Length * 0.25;
            }
            else
            {
                CakeCost = 75 + CakeWriting.Length * 0.25;
            }
            if(NumberOfPeople > 12)
            {
                TotalCost += 100;
            }
            return TotalCost+CakeCost;
        }
        public override string ToString()
        {
            return base.ToString() + $"[Birthday]Cakesize:{CakeSize},Cakewriting:{CakeWriting}";
        }
    }
}
