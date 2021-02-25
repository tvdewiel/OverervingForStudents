using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicParty3
{
    public class BirthdayParty : Party
    {
        public int CakeSize;
        private string _cakeWriting = "";

        public BirthdayParty(string cakeWriting, int numberOfPeople,bool fancyDecorations) : base(fancyDecorations,numberOfPeople)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations();
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
                    //throw new Exception("max length");
                    if (maxLength > _cakeWriting.Length)
                    {
                        maxLength = _cakeWriting.Length;
                    }
                    CakeWriting = _cakeWriting.Substring(0, maxLength);
                }
                else _cakeWriting = value;
            }
        }
        public override int NumberOfPeople {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                CakeWriting = _cakeWriting;
            }
            }
        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4) CakeSize = 20; else CakeSize = 40;
        }
        private int lengthWriting(string s)
        {
            string[] x = s.Split(' ');
            return string.Concat(x).Length;
        }
        public override double CalculateCost()
        {
            double CakeCost;
            if (CakeSize == 20)
            {
                CakeCost = 40 + lengthWriting(CakeWriting) * 0.25;
            }
            else
            {
                CakeCost = 75 + lengthWriting(CakeWriting) * 0.25;
            }
            return base.CalculateCost()+CakeCost;
        }
        public override string ToString()
        {
            return base.ToString() + $"[Birthday]Cakesize:{CakeSize},Cakewriting:{CakeWriting}";
        }
    }
}
