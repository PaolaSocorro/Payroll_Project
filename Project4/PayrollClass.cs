/*  Program:     Payroll Project 4
    Author:      Paola Socorro (for this PayrollClass)
    Class:	     CISP 41
    Date:	     May 18 2013
    Description: This Class is will calculate payroll for salaried employees and hourly employees.

    I certify that the code below is my own work.
	
	Exception(s): N/A

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4
{
    class PayrollClass
    {
        //MANDATORY
        public const decimal SOCIAL_SECURITY_TAX = .10M;
        public const decimal FEDERAL_INCOME_TAX = .15M;
        public const decimal STATE_INCOME_TAX = .05M;

        


        //GROSS AND NET PAY
        protected decimal grossPayDecimal;
        protected decimal netPayDecimal;
        protected decimal deductedTaxes;

        public PayrollClass()
        {

        }


        public decimal grossPay(decimal rate, decimal hours)
        {
            grossPayDecimal = rate * hours;
            return grossPayDecimal;
        }

        public decimal grossPaySalary(decimal salary)
        {
            grossPayDecimal = salary;
            return grossPayDecimal;
        }

        //TO BE CALCULATED BEFORE TAXES.
        public decimal deductionPay(decimal benefitsMedDen, decimal lifeInsurance, decimal save401K, decimal fsa)
        {
            netPayDecimal = grossPayDecimal - (benefitsMedDen+ lifeInsurance + save401K + fsa);
            return netPayDecimal;
        }

        //TO BE CALCULATED AFTER deductionPay()
        public decimal mandatoryTaxDeductions()
        {
            deductedTaxes= netPayDecimal * (SOCIAL_SECURITY_TAX + FEDERAL_INCOME_TAX + STATE_INCOME_TAX);
            return deductedTaxes;
        }

        public decimal netPayCalc()
        {
            netPayDecimal = netPayDecimal - deductedTaxes;
            return netPayDecimal;
        }

        //Stop contribution of 401k to  15,000
        public decimal stop401k(decimal contribution401k)
        {
            return contribution401k;
        }

    }
}
