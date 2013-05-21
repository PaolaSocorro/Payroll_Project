using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project4
{
    public partial class Payroll_Form : Form
    {
      

        public Payroll_Form()
        {
            InitializeComponent();
        }

        private void MedicalcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MedicaltextBox.Visible = MedicalcheckBox.Checked;
        }

        private void LIcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LItextBox.Visible = LIcheckBox.Checked;
        }

        private void PlancheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PlantextBox.Visible = PlancheckBox.Checked;
        }

        private void FSAcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FSAtextBox.Visible = FSAcheckBox.Checked;
        }





    }
}
