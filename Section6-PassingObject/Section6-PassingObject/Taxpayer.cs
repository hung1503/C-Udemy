using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6_PassingObject
{
    internal class Taxpayer
    {
        private int socialSecurity;
        private double yearlyIncome;
        private double taxOwed;

        public Taxpayer(int socialSecurity, double yearlyIncome)
        {
            this.socialSecurity = socialSecurity;
            this.yearlyIncome = yearlyIncome;
            TaxCalculate();
        }

        public int SocialSecurity
        {
            get
            {
                return socialSecurity;
            }
            set
            {
                socialSecurity = value;
            }
        }

        public double YearlyIncome
        {
            get
            {
                return yearlyIncome;
            }
            set
            {
                yearlyIncome = value;
            }
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }

        private void TaxCalculate()
        {
            if (yearlyIncome < 30000)
            {
                taxOwed = yearlyIncome * .15;
            }
            else
            {
                taxOwed = yearlyIncome * .28;
            }
        }
    }
}
