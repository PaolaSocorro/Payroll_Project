/*  Program:  Paystub Report Class   
    Author:   Qianqun Xu   
    Class:	  CISP 41   
    Date:	     
    Description: Handles reports pay stubs in derived classess. 

    I certify that the code below is my own work.
	
	Exception(s): N/A

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.ComponentModel;


namespace Project4
{
    class PaystubReport
    {
        private string nameString;
        private int monthInterger;
        private decimal grossPayDecimal, socialSecurityTaxDecimal, fedIncomeTaxDecimal, stateIncomeTaxDecimal, netPayDecimal;

        public string Name
        {
            get { return nameString; }
            set { nameString = value; }
        }
        public int Month
        {
            get { return monthInterger; }
            set { monthInterger = value; }
        }
        public decimal GrossPay
        {
            get { return grossPayDecimal; }
            set { grossPayDecimal = value; }
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
        public decimal NetPay
        {
            get { return netPayDecimal; }
            set { netPayDecimal = value; }
        }


        public PaystubReport(string nameString, decimal grossPayDecimal, decimal socialSecurityTaxDecimal,decimal fedIncomeTaxDecimal, decimal stateIncomeTaxDecimal, decimal netPayDecimal)
        {

            Name = nameString;
            GrossPay = grossPayDecimal;
            SocialSecurityTax = socialSecurityTaxDecimal; 
            FedIncomeTax = fedIncomeTaxDecimal; 
            StateIncomeTax = stateIncomeTaxDecimal;
            NetPay = netPayDecimal;
            printReport();
        }

        public void printReport()
        {

            PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
            PaperSize paperSize = new PaperSize("DataOrder", 470, 660);
            PrintDocument Report = new PrintDocument(); 
            Report.DefaultPageSettings.PaperSize = paperSize; 
            PrintPreviewDialog1.Document = Report;
            Report.PrintPage += new PrintPageEventHandler(Report_PrintPage); 
            PrintPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D; 
            PrintPreviewDialog1.ShowDialog();
        }

        public	void	Report_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs  e)
        {

            float  hozPosFloat  =  15.0f; 
            float  verPosFoat  =  15.0f; 
            float  leftbianJu  =  5;
            float  topbianJu  = 5;


            Pen line  = new  Pen(Color.Black,  1.0f);

        
            //Draw  frame  and  blue  patches
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu,  461,  50);
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu  + 100,  461,20);


            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 122,  460,  60); 
            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 122,  460,  100); 
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu  + 225,  461,20);


            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 247,  460,  60);
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu  + 309,  461,20);


            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 331,  460,  100);
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu  + 434,  461,20);


            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 456,  460,  100);
            e.Graphics.FillRectangle(Brushes.DarkBlue,  leftbianJu,  topbianJu  + 560,  461,20);


            e.Graphics.DrawRectangle(line,  leftbianJu,  topbianJu  + 581,  460,  50);

            //Paystubs,  2013,Fill  the  form  with  instructions
            e.Graphics.DrawString("Pay    Stubs",    new    Font("Kozuka    Mincho    Pro    B",    9, FontStyle.Bold),
            Brushes.White,  hozPosFloat  + 200,  verPosFoat  + 20);
            e.Graphics.DrawString("Summary",	new	Font("Kozuka	Mincho	Pro	B",	6, FontStyle.Bold),
            Brushes.White,  hozPosFloat,  112);

            e.Graphics.DrawString("Name\t\t\t\t\t\tAddress",  new  Font("Kozuka  Mincho  Pro    B",  7,  FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  131);
            e.Graphics.DrawString("Employee	ID\t\tSSN\t\tDate	from\tDate	to",	new
            Font("Kozuka  Mincho  Pro  B",  7,  FontStyle.Bold), Brushes.Black,  hozPosFloat,  192);
            e.Graphics.DrawString("Gross    Pay",    new    Font("Kozuka    Mincho    Pro    B",    6, FontStyle.Bold),
            Brushes.White,  hozPosFloat,  237);
            e.Graphics.DrawString("Amount",	new	Font("Kozuka	Mincho	Pro	B",	7, FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  256);
            e.Graphics.DrawString("Taxes",	new	Font("Kozuka	Mincho	Pro	B",	6, FontStyle.Bold),
            Brushes.White,  hozPosFloat,  321);
            e.Graphics.DrawString("Type\t\t\t\t\tAmount", new Font("Kozuka Mincho Pro B",
            7,  FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  345);
            e.Graphics.DrawString("Social	Security	Tax",	new	Font("Arial",	6, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  368);
            e.Graphics.DrawString("Fed	Income	Tax",	new	Font("Arial",	6, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  388);
            e.Graphics.DrawString("State	Income	Tax",	new	Font("Arial",	6, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  408);
            e.Graphics.DrawString("Deduction",    new    Font("Kozuka    Mincho    Pro    B",    6, FontStyle.Regular),
            Brushes.White,  hozPosFloat,  446);
            e.Graphics.DrawString("Type\t\t\t\t\tAmount", new Font("Kozuka Mincho Pro B",
            7,  FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  468);
            e.Graphics.DrawString("Net	Pay",	new	Font("Kozuka	Mincho	Pro	B",	6, FontStyle.Bold),
            Brushes.White,  hozPosFloat,  572);
            e.Graphics.DrawString("Amount",	new	Font("Kozuka	Mincho	Pro	B",	7, FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  592);


            //Fill  the  blank  with  data
            e.Graphics.DrawString(nameString,  new  Font("Arial",  8,  FontStyle.Regular), Brushes.Black,  hozPosFloat,  150);

            e.Graphics.DrawString(grossPayDecimal.ToString(),new Font("Arial", 7, FontStyle.Regular), Brushes.Black, hozPosFloat, 280);

            e.Graphics.DrawString(socialSecurityTaxDecimal.ToString()  ,new Font("Arial", 6, FontStyle.Regular), Brushes.Black, hozPosFloat + 200,368);


            e.Graphics.DrawString(fedIncomeTaxDecimal.ToString(),new Font("Arial", 6, FontStyle.Regular), Brushes.Black, hozPosFloat + 200,388);


            e.Graphics.DrawString(stateIncomeTaxDecimal.ToString(),new Font("Arial", 6, FontStyle.Regular), Brushes.Black, hozPosFloat + 200,408);


            e.Graphics.DrawString(netPayDecimal.ToString(),new Font("Arial", 7, FontStyle.Regular), Brushes.Black, hozPosFloat, 605);
            }

    }
}
