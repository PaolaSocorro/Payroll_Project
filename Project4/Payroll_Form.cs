using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project4
{
    public partial class Payroll_Form : StandardForm
    {
        //CODE by Paola. Arrays for employee. Index position below. 
        //0-id,1-first name, 2-lastname, 3-department, 4-position, 5- salary rate, 6-medical, 7-dental, 8-lifeinsurance, 9-401k, 10-FSA.
        
        //string[] record = new string[EMPLOYEE_NUM]; //Place employee line of data here. 
        const int EMPLOYEE_NUM = 20;
        int[] idNumber = new int[EMPLOYEE_NUM];
        string[] employeeRecord = new string[EMPLOYEE_NUM];

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] fileNames = { "jan.dat", "feb.dat", "mar.dat", "apr.dat", "may.dat", "jun.dat", "jul.dat", "aug.dat", "sep.dat", "oct.dat", "nov.dat", "dec.dat" };
        string fileToProcess;
        
        public Payroll_Form()
        {
            InitializeComponent();
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Loads the months array into the combobox.
        //
        private void Payroll_Form_Load(object sender, EventArgs e)
        {
            //Loads the months array into the combobox.
            for (int counter = 0; counter < months.Length; counter++)
            {
                monthsComboBox.Items.Add(months[counter]);
            }

            //setup StreamReader
            StreamReader masterReader = new StreamReader("master.dat");
            int countInt = 0;
            

            while (masterReader.Peek() != -1)
            {
                string recordString = masterReader.ReadLine();
                //string [] splitString = recordString.Split(' ');
                string[] splitString = recordString.Split(new char[] { ' ' }, 2);
                idNumber[countInt] = int.Parse(splitString[0]);
                employeeRecord[countInt] = splitString[1];
                Console.WriteLine("Id array: " + idNumber[countInt]);
                Console.WriteLine("info: " + employeeRecord[countInt]);
                countInt++;
                
            }
            masterReader.Close();
                    
        }
        //
        //displays file to be processed to the user. Assigns selected index to variable. 
        //
        private void monthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            processingTextBox.Text = fileNames[monthsComboBox.SelectedIndex];
            fileToProcess = fileNames[monthsComboBox.SelectedIndex];
            Console.WriteLine("To process: " + fileNames[monthsComboBox.SelectedIndex].ToString());
        }

        private void processButton_Click(object sender, EventArgs e)
        {

        }

        private void four01kCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (four01kCheckBox.Checked)
            {
                fourkTextBox.Enabled = true;
            }
            else
            {
                fourkTextBox.Enabled = false;
            }
        }

        

       

        

        
        






        //CODE by Paola. 

     



    }
}
