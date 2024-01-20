using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_classes
{
    public class SimpleInterest
    {
        public decimal PrincipalAmount { get; set; }
        public decimal YearOfInvestment { get; set; }
        private decimal interestPercentage; 

        public decimal InterestPercentage
        {
            get { return interestPercentage; }
            set {
                if (value <= 0)
                {
                    string msg = $"Invalies Percentage{value}. It is less then 0";
                    throw new Exception(msg);

                }
                if (value > 40)
                {
                    string msg = $"Invalies Percentage{value}. It is graterthen 40";
                    throw new Exception(msg);

                }

                interestPercentage = value; }

        }

        private decimal simpleInterest;
        public decimal SimpleInterestAmountNotAerrow
        { 
            get { return simpleInterest; }
        }

        //using aerrow key function
        public decimal SimpleInterestAmount => simpleInterest;
        public void CalculateSimpleInterest()
        {
            simpleInterest = PrincipalAmount * YearOfInvestment * InterestPercentage / 100;
        }
    }
}
