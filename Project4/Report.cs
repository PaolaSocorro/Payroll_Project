/*  Program:  Report Class   
    Author:   Qianqun Xu   
    Class:	  CISP 41   
    Date:	     
    Description: Handles reports program
 
    I certify that the code below is my own work.
	
	Exception(s): N/A

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project4
{
    class Report
    {

        protected string nameString;
        protected decimal wagesDecimal, socialSecurityTaxDecimal, fedIncomeTaxDecimal, stateIncomeTaxDecimal;

        public string Name
        {
            get { return nameString; }
            set { nameString = value; }
        }
        public decimal Wages
        {
            get { return wagesDecimal; }
            set { wagesDecimal = value; }
        }
        public decimal SocialSecurityTax
        {
            get { return socialSecurityTaxDecimal; }
            set { socialSecurityTaxDecimal = value; }
        }
        public decimal FedIncomeTax
        {
            get { return fedIncomeTaxDecimal; }
            set { fedIncomeTaxDecimal = value; }
        }
        public decimal StateIncomeTax
        {
            get { return stateIncomeTaxDecimal; }
            set { stateIncomeTaxDecimal = value; }
        }


        public Report(string nameString, decimal wagesDecimal, decimal socialSecurityTaxDecimal,decimal fedIncomeTaxDecimal, decimal stateIncomeTaxDecimal)
        {
            Name = nameString; Wages = wagesDecimal;
            SocialSecurityTax = socialSecurityTaxDecimal; 
            FedIncomeTax = fedIncomeTaxDecimal; 
            StateIncomeTax = stateIncomeTaxDecimal; 
            printReport();
        }

        public virtual void printReport()
        {

        }



    }
}
