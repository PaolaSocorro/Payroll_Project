/*  Program:  Derived W-2:Report Class   
    Author:   Qianqun Xu   
    Class:	  CISP 41   
    Date:	     
    Description: Handles reports for W-2  in derived classess. 

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
    class W_2Report:Report
    {

        public W_2Report(string nameString, decimal wagesDecimal, decimal socialSecurityTaxDecimal,decimal fedIncomeTaxDecimal, decimal stateIncomeTaxDecimal)
            :
            base(nameString, wagesDecimal, socialSecurityTaxDecimal, fedIncomeTaxDecimal, stateIncomeTaxDecimal)
        {
        }


        public override void printReport()
        {

            PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog(); 
            PaperSize paperSize = new PaperSize("DataOrder", 810, 470); 
            PrintDocument Report = new PrintDocument(); 
            Report.DefaultPageSettings.PaperSize = paperSize; 
            PrintPreviewDialog1.Document = Report;
            Report.PrintPage += new PrintPageEventHandler(Report_PrintPage); 
            PrintPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D; 
            PrintPreviewDialog1.ShowDialog();
        }

        public	void	Report_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs  e)
        {

            //draw  a  form

            float  hozPosFloat  =  15.0f; float  verPosFoat  =  15.0f; float  leftbianJu  =  15; float  topbianJu  = 15;
            float  tableWidth  = 780;
            float  tableHeight  = 393;


            Pen line  = new  Pen(Color.Black,  1.0f);
            Pen wideLine  = new  Pen(Color.Black,  2.0f);


            //Draw  a  Rectangle,  the  frame  of  the  form


            e.Graphics.DrawRectangle(wideLine,	leftbianJu,	topbianJu,	tableWidth, tableHeight);





            //Draw  horizontal  lines  inside  the  table
            e.Graphics.DrawLine(line, leftbianJu, topbianJu + 30, leftbianJu + tableWidth, topbianJu  + 30);
            e.Graphics.DrawLine(line, leftbianJu, topbianJu + 60, leftbianJu + tableWidth, topbianJu  + 60);
            e.Graphics.DrawLine(line, leftbianJu, topbianJu + 150, leftbianJu + tableWidth, topbianJu  + 150);
            e.Graphics.DrawLine(line, leftbianJu, topbianJu + 180, leftbianJu + tableWidth, topbianJu  + 180);
            e.Graphics.DrawLine(line, leftbianJu, topbianJu + 320, leftbianJu + tableWidth, topbianJu  + 320);
            e.Graphics.DrawLine(line,   leftbianJu   +  400,   topbianJu   +  90,   leftbianJu   +
            tableWidth,  topbianJu  + 90);
            e.Graphics.DrawLine(line,   leftbianJu   +  400,   topbianJu   +  120,   leftbianJu   +
            tableWidth,  topbianJu  + 120);
            e.Graphics.DrawLine(line,   leftbianJu   +  400,   topbianJu   +  210,   leftbianJu   +
            tableWidth,  topbianJu  + 210);
            e.Graphics.DrawLine(line,   leftbianJu   +  400,   topbianJu   +  240,   leftbianJu   +
            tableWidth,  topbianJu  + 240);


            //Draw  vertical  lines  inside  the  table
            e.Graphics.DrawLine(line,   leftbianJu   +  140,   topbianJu,   leftbianJu   +   140, topbianJu  + 30);
            e.Graphics.DrawLine(line,   leftbianJu   +  280,   topbianJu,   leftbianJu   +   280, topbianJu  + 30);
            e.Graphics.DrawLine(line,  leftbianJu  + 400,  topbianJu  + 30,  leftbianJu  +  400,

            topbianJu  + 320);
            e.Graphics.DrawLine(line,  leftbianJu  + 590,  topbianJu  + 30,  leftbianJu  +  590, topbianJu  + 320);
            e.Graphics.DrawLine(line, leftbianJu + 210, topbianJu + 320, leftbianJu + 210, topbianJu  + tableHeight);
            e.Graphics.DrawLine(line, leftbianJu + 320, topbianJu + 320, leftbianJu + 320, topbianJu  + tableHeight);
            e.Graphics.DrawLine(line, leftbianJu + 430, topbianJu + 320, leftbianJu + 430, topbianJu  + tableHeight);


            //W-2,  2013
            e.Graphics.DrawString("Form", new Font("Microsoft YaHei", 6, FontStyle.Bold), Brushes.Black,  hozPosFloat,  verPosFoat  + 414);
            e.Graphics.DrawString("	W-2",	new	Font("Microsoft	YaHei",	15, FontStyle.Bold),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 400);
            e.Graphics.DrawString("2013",	new	Font("Kozuka	Mincho	Pro	B",	15, FontStyle.Bold),
            Brushes.Black,  hozPosFloat  + 350,  verPosFoat  + 400);
            e.Graphics.DrawString("Department   of   the   Treasury",   new   Font("Arial",   9, FontStyle.Regular),
            Brushes.Black,  hozPosFloat  + 600,  verPosFoat  + 400);


            //Fill  the  form  with  instructions
            e.Graphics.DrawString("	Control	number",	new	Font("Arial",	7, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 1);
            e.Graphics.DrawString("  Employer identification  Number",  new Font("Arial",  7, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 31);
            e.Graphics.DrawString("	Employer's	name,	address	and 	ZIP	code",	new
            Font("Arial",  7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 61);
            e.Graphics.DrawString("  Employee's  social  security number", new  Font("Arial",
            7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 151);
            e.Graphics.DrawString("	Employee's	name",	new	Font("Arial",	7, FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 181);
            e.Graphics.DrawString("  Wages, tips,  other compensation\t\tFederal income  tax withheld",  new  Font("Arial",  7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat  + 400,  verPosFoat  + 31);
            e.Graphics.DrawString("    Social    security    wages\t\t\tSocial    secutiry    tax withheld",  new  Font("Arial",  7,  FontStyle.Regular),

            Brushes.Black,  hozPosFloat  + 400,  verPosFoat  + 61);
            e.Graphics.DrawString("  Medicare  wages  and tips\t\t\tMedicare  tax  withheld", new  Font("Arial",  7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat  + 400,  verPosFoat  + 91);
            e.Graphics.DrawString("    Social    security    tips\t\t\tAllocated    tips",    new
            Font("Arial",  7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat  + 400,  verPosFoat  + 121);
            e.Graphics.DrawString("  State	Employer's  state  ID  number\t	State wages\t\t	State  income  tax",  new  Font("Arial",  7,  FontStyle.Regular),
            Brushes.Black,  hozPosFloat,  verPosFoat  + 321);


            //Fill  the  blank  with  data
            e.Graphics.DrawString(Name,  new  Font("Arial",  10,  FontStyle.Bold), Brushes.Black,  hozPosFloat  + 10,  verPosFoat  + 201); e.Graphics.DrawString(Wages.ToString()  + "\n\n"  + Wages.ToString()  +  "\n\n"  +
            Wages.ToString(),
            new  Font("Arial",   9,  FontStyle.Bold),Brushes.Black,  hozPosFloat   +  520, verPosFoat  + 44);
            e.Graphics.DrawString(FedIncomeTax.ToString()	+	"\n\n"	+ SocialSecurityTax.ToString(),
            new  Font("Arial",  9,  FontStyle.Bold),  Brushes.Black,  hozPosFloat  +  720, verPosFoat  + 44);
            e.Graphics.DrawString(Wages.ToString()	+	"\t\t	" 	+ StateIncomeTax.ToString(),
            new  Font("Arial",  9,  FontStyle.Bold),  Brushes.Black,  hozPosFloat  +  250, verPosFoat  + 335);

            }

        
        


    }
}
