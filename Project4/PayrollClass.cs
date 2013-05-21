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
        protected const decimal SOCIAL_SECURITY_TAX = .10M;
        protected const decimal FEDERAL_INCOME_TAX = .15M;
        protected const decimal STATE_INCOME_TAX = .5M;

        //VOLUNTARY FROM MASTER FILE
        protected decimal dentalBenefits;
        protected decimal medicalBenefits;
        protected decimal lifeInsurance;
        protected decimal savings401K;
        protected decimal flexibleSpendingAcc;
        protected decimal salaryRate; // rate per hour for hourly employees.
        protected decimal salary; //Just to be used for salaried employees.

        // FROM MONTHLY DATA FILE
        protected decimal hoursWorked;

        //GROSS AND NET PAY
        protected decimal grossPayDecimal;
        protected decimal netPayDecimal;


        public virtual decimal grossPay(decimal rate, decimal hours)
        {
            grossPayDecimal = rate * hours;
            return grossPayDecimal;
        }

        //TO BE CALCULATED BEFORE TAXES.
        public decimal deductionPay(decimal dental, decimal medical, decimal lifeInsurance, decimal save401K, decimal fsa)
        {
            netPayDecimal = netPayDecimal - (dental + medical + lifeInsurance + save401K + fsa);
            return netPayDecimal;
        }

        //TO BE CALCULATED AFTER deductionPay()
        public decimal mandatoryTaxDeductions()
        {
            netPayDecimal = netPayDecimal * (SOCIAL_SECURITY_TAX + FEDERAL_INCOME_TAX + STATE_INCOME_TAX);
            return netPayDecimal;
        }

    }
}
