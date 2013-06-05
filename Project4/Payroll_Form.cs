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
        //CODE by Paola.

        PayrollClass aPayroll = new PayrollClass();

        const int MAXIMUM_EMPLOYEEINT =20;

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] monthlyData = { "Jan_Transactions", "Feb_Transactions", "Mar_Transactions", "Apr_Transactions", "May_Transactions", "Jun_Transactions", "Jul_Transactions", "Aug_Transactions", "Sep_Transactions", "Oct_Transactions", "Nov_Transactions", "Dec_Transactions" };
        string[] isMonthProcess = { "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no" };
        int countMonth = 0;
        string monthToProcess;
        string[] employeeIdArray= new string[MAXIMUM_EMPLOYEEINT];
        decimal[] eNetPay = new decimal[MAXIMUM_EMPLOYEEINT];
        decimal[] eGrossPay = new decimal[MAXIMUM_EMPLOYEEINT];
        decimal[] eDeductedTax = new decimal[MAXIMUM_EMPLOYEEINT];

        

        string idNumber = "8008";
        string nameLastname;
        string departmentString;
        string positionString;
        decimal rateDec;
        decimal monthlySalaryDec; //just for salary employees
        decimal benefitsDec; //medical and dental benefits both into one.
        decimal lifeInsur;
        decimal savings401K; // not to be confused with FSA
        decimal fsa;

        decimal hoursWorked;



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
            // TODO: This line of code loads data into the 'project4dataDataSet1.Dec_Transactions' table. You can move, or remove it, as needed.
            this.dec_TransactionsTableAdapter.Fill(this.project4dataDataSet.Dec_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Nov_Transactions' table. You can move, or remove it, as needed.
            this.nov_TransactionsTableAdapter.Fill(this.project4dataDataSet.Nov_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Oct_Transactions' table. You can move, or remove it, as needed.
            this.oct_TransactionsTableAdapter.Fill(this.project4dataDataSet.Oct_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Sep_Transactions' table. You can move, or remove it, as needed.
            this.sep_TransactionsTableAdapter.Fill(this.project4dataDataSet.Sep_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Aug_Transactions' table. You can move, or remove it, as needed.
            this.aug_TransactionsTableAdapter.Fill(this.project4dataDataSet.Aug_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Jul_Transactions' table. You can move, or remove it, as needed.
            this.jul_TransactionsTableAdapter.Fill(this.project4dataDataSet.Jul_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Jun_Transactions' table. You can move, or remove it, as needed.
            this.jun_TransactionsTableAdapter.Fill(this.project4dataDataSet.Jun_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.May_Transactions' table. You can move, or remove it, as needed.
            this.may_TransactionsTableAdapter.Fill(this.project4dataDataSet.May_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Apr_Transactions' table. You can move, or remove it, as needed.
            this.apr_TransactionsTableAdapter.Fill(this.project4dataDataSet.Apr_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Mar_Transactions' table. You can move, or remove it, as needed.
            this.mar_TransactionsTableAdapter.Fill(this.project4dataDataSet.Mar_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet1.Feb_Transactions' table. You can move, or remove it, as needed.
            this.feb_TransactionsTableAdapter.Fill(this.project4dataDataSet.Feb_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet.Master_Transactions' table. You can move, or remove it, as needed.
            this.master_TransactionsTableAdapter.Fill(this.project4dataDataSet.Master_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet.Master_Transactions' table. You can move, or remove it, as needed.
            this.master_TransactionsTableAdapter.Fill(this.project4dataDataSet.Master_Transactions);

            this.jan_TransactionsTableAdapter.Fill(this.project4dataDataSet.Jan_Transactions);
            //
            //FILL employeeIdArray at runtime. 
            //
            populateIdArray();
            Console.WriteLine("array filled");
            for (int i = 0; i < months.Length; i++)
            {
                monthsComboBox.Items.Add(months[i]);
            }
            
        }
        //
        //DISPLAYS file to be processed to the user. Assigns selected index to variable. 
        //
        private void monthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            processingTextBox.Text = monthlyData[monthsComboBox.SelectedIndex];
            monthToProcess = monthlyData[monthsComboBox.SelectedIndex];
            //Console.WriteLine("To process: " + monthlyData[monthsComboBox.SelectedIndex].ToString());
        }
        //
        //READ DATA FROM MASTER TABLE.
        //Places each row of data into variables. 
        //
        private void populateIdArray()
        {
            int counter =0;
            foreach (DataRow row in project4dataDataSet.Master_Transactions.Rows)
            {
                string idNum = row["EmployeeID"].ToString();
                idNum = idNum.Replace(" ", null);//removing spaces in string
                employeeIdArray[counter] = idNum;
                counter++;
            }
        }
        //
        //Reads employee information from Master_transactions.
        //Places data in apropriate variables.
        //
        private void dataRowReaderMaster()
        {
            foreach (DataRow row in project4dataDataSet.Master_Transactions.Rows)
            { 
                string idNum = row["EmployeeID"].ToString();
                idNum = idNum.Replace(" ", null);//removing spaces in string
                if (idNum == idNumber)
                {
                    nameLastname = row["Employee Name"].ToString();
                    departmentString = row["Department"].ToString();
                    positionString = row["Position"].ToString();
                    positionString = positionString.Replace(" ", null);//removing spaces in string
                    rateDec = decimal.Parse(row["Salary Rate"].ToString());
                    benefitsDec = decimal.Parse(row["Medical"].ToString());
                    lifeInsur = decimal.Parse(row["Life Insurance"].ToString());
                    savings401K = decimal.Parse(row["401k"].ToString());
                    fsa = decimal.Parse(row["FSA"].ToString());
                }
            }
            
            //
            //Compares position to check if its Manager or Engineer.
            //Manger is used, due to error in database values for one employee. Cindy Red.
            //
            if (positionString == "Manager" || positionString == "Engineer" || positionString == "Manger")
            {
                monthlySalaryDec = rateDec;
                rateDec = 0;
               // Console.WriteLine("done" + monthlySalaryDec.ToString() + " set");
            }

        }

        private void dataRowReaderMonth()
        {

            //processingTextBox.Text = monthlyData[monthsComboBox.SelectedIndex];
            //monthToProcess = monthlyData[monthsComboBox.SelectedIndex];

            int counter =0;
            //int monthCounter = 0;
            string tName; // name of the stable.
            //string month = monthlyData[counter];
            int tableCount= monthsComboBox.SelectedIndex;
            
            foreach (DataTable table in project4dataDataSet.Tables)
            {
                if (table.TableName.ToString() == monthlyData[tableCount])
                {
                    tName = table.TableName;
                    Console.WriteLine(monthlyData[tableCount].ToString() + "\n");
                    foreach (DataRow row in table.Rows)
                    {
                        idNumber = row["EmployeeID"].ToString();
                        idNumber = idNumber.Replace(" ", null);//removing spaces in string
                        hoursWorked = decimal.Parse(row["WorkedHours"].ToString());
                        dataRowReaderMaster();
                        calcEmployeePay(counter);
                        //Console.WriteLine("Data Read for month of "+ months[counter].ToString());
                        Console.WriteLine("One Employee done: " + nameLastname.ToString() + " id: " + idNumber.ToString() + " hours worked: " + hoursWorked.ToString());
                        counter++;

                    }
                    isMonthProcess[tableCount] = "yes";
                }
                
            }
    
            
        }

        private void calcEmployeePay(int step)
        {
            if (positionString == "Manager" || positionString == "Engineer" || positionString == "Manger")
            {
                
                eGrossPay[step] = aPayroll.grossPaySalary(monthlySalaryDec);

            }
            else
            {
                eGrossPay[step] = aPayroll.grossPay(rateDec, hoursWorked);
            
            }
            aPayroll.deductionPay(benefitsDec, lifeInsur, savings401K, fsa);
            eDeductedTax[step] = aPayroll.mandatoryTaxDeductions();
            eNetPay[step] = aPayroll.netPayCalc();
            //Console.WriteLine("inside calcEmployeePay");
        }
        
        private void processButton_Click(object sender, EventArgs e)
        {
            //dataRowReaderMaster();
            //dataRowReaderMonth();
            try
            {
                dataRowReaderMonth();
                Console.WriteLine("done");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please Select a Month to Process.","No Month Selected",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
            }
    
        }

        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm myTestForm = new TestForm();
            myTestForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Box myAboutForm = new About_Box();
            myAboutForm.ShowDialog();
        }

        private void w2ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_2Report aW_2 = new W_2Report("Joe", 20000.0m, 380.0m, 120.0m, 50.0m);

        }

        private void monthlyPayStubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaystubReport aPSReport = new PaystubReport("Joe", 3000.0m, 100.0m, 80.0m,20.0m, 2800m);

        }

        


        //CODE by Paola. 

    }
}
