namespace Project4
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label salary_RateLabel;
            System.Windows.Forms.Label medicalLabel;
            System.Windows.Forms.Label life_InsuranceLabel;
            System.Windows.Forms.Label _401KLabel;
            System.Windows.Forms.Label fSALabel;
            System.Windows.Forms.Label employee_NameLabel1;
            System.Windows.Forms.Label employeeIDLabel1;
            System.Windows.Forms.Label workedHoursLabel;
            this.project4dataDataSet = new Project4.project4dataDataSet();
            this.master_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Master_TransactionsTableAdapter();
            this.tableAdapterManager = new Project4.project4dataDataSetTableAdapters.TableAdapterManager();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salary_RateTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.life_InsuranceTextBox = new System.Windows.Forms.TextBox();
            this._401KTextBox = new System.Windows.Forms.TextBox();
            this.fSATextBox = new System.Windows.Forms.TextBox();
            this.employee_NameComboBox = new System.Windows.Forms.ComboBox();
            this.jan_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jan_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Jan_TransactionsTableAdapter();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.workedHoursTextBox = new System.Windows.Forms.TextBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            salary_RateLabel = new System.Windows.Forms.Label();
            medicalLabel = new System.Windows.Forms.Label();
            life_InsuranceLabel = new System.Windows.Forms.Label();
            _401KLabel = new System.Windows.Forms.Label();
            fSALabel = new System.Windows.Forms.Label();
            employee_NameLabel1 = new System.Windows.Forms.Label();
            employeeIDLabel1 = new System.Windows.Forms.Label();
            workedHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jan_TransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(15, 161);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 3;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(15, 187);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 7;
            departmentLabel.Text = "Department:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(15, 213);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 9;
            positionLabel.Text = "Position:";
            // 
            // salary_RateLabel
            // 
            salary_RateLabel.AutoSize = true;
            salary_RateLabel.Location = new System.Drawing.Point(15, 239);
            salary_RateLabel.Name = "salary_RateLabel";
            salary_RateLabel.Size = new System.Drawing.Size(65, 13);
            salary_RateLabel.TabIndex = 11;
            salary_RateLabel.Text = "Salary Rate:";
            // 
            // medicalLabel
            // 
            medicalLabel.AutoSize = true;
            medicalLabel.Location = new System.Drawing.Point(15, 265);
            medicalLabel.Name = "medicalLabel";
            medicalLabel.Size = new System.Drawing.Size(47, 13);
            medicalLabel.TabIndex = 13;
            medicalLabel.Text = "Medical:";
            // 
            // life_InsuranceLabel
            // 
            life_InsuranceLabel.AutoSize = true;
            life_InsuranceLabel.Location = new System.Drawing.Point(15, 291);
            life_InsuranceLabel.Name = "life_InsuranceLabel";
            life_InsuranceLabel.Size = new System.Drawing.Size(77, 13);
            life_InsuranceLabel.TabIndex = 15;
            life_InsuranceLabel.Text = "Life Insurance:";
            // 
            // _401KLabel
            // 
            _401KLabel.AutoSize = true;
            _401KLabel.Location = new System.Drawing.Point(15, 317);
            _401KLabel.Name = "_401KLabel";
            _401KLabel.Size = new System.Drawing.Size(35, 13);
            _401KLabel.TabIndex = 17;
            _401KLabel.Text = "401K:";
            // 
            // fSALabel
            // 
            fSALabel.AutoSize = true;
            fSALabel.Location = new System.Drawing.Point(15, 343);
            fSALabel.Name = "fSALabel";
            fSALabel.Size = new System.Drawing.Size(30, 13);
            fSALabel.TabIndex = 19;
            fSALabel.Text = "FSA:";
            // 
            // employee_NameLabel1
            // 
            employee_NameLabel1.AutoSize = true;
            employee_NameLabel1.Location = new System.Drawing.Point(15, 134);
            employee_NameLabel1.Name = "employee_NameLabel1";
            employee_NameLabel1.Size = new System.Drawing.Size(87, 13);
            employee_NameLabel1.TabIndex = 20;
            employee_NameLabel1.Text = "Employee Name:";
            // 
            // employeeIDLabel1
            // 
            employeeIDLabel1.AutoSize = true;
            employeeIDLabel1.Location = new System.Drawing.Point(276, 131);
            employeeIDLabel1.Name = "employeeIDLabel1";
            employeeIDLabel1.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel1.TabIndex = 21;
            employeeIDLabel1.Text = "Employee ID:";
            // 
            // workedHoursLabel
            // 
            workedHoursLabel.AutoSize = true;
            workedHoursLabel.Location = new System.Drawing.Point(276, 158);
            workedHoursLabel.Name = "workedHoursLabel";
            workedHoursLabel.Size = new System.Drawing.Size(79, 13);
            workedHoursLabel.TabIndex = 23;
            workedHoursLabel.Text = "Worked Hours:";
            // 
            // project4dataDataSet
            // 
            this.project4dataDataSet.DataSetName = "project4dataDataSet";
            this.project4dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // master_TransactionsBindingSource
            // 
            this.master_TransactionsBindingSource.DataMember = "Master_Transactions";
            this.master_TransactionsBindingSource.DataSource = this.project4dataDataSet;
            // 
            // master_TransactionsTableAdapter
            // 
            this.master_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Apr_TransactionsTableAdapter = null;
            this.tableAdapterManager.Aug_TransactionsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dec_TransactionsTableAdapter = null;
            this.tableAdapterManager.Feb_TransactionsTableAdapter = null;
            this.tableAdapterManager.Jan_TransactionsTableAdapter = this.jan_TransactionsTableAdapter;
            this.tableAdapterManager.Jul_TransactionsTableAdapter = null;
            this.tableAdapterManager.Jun_TransactionsTableAdapter = null;
            this.tableAdapterManager.Mar_TransactionsTableAdapter = null;
            this.tableAdapterManager.Master_TransactionsTableAdapter = this.master_TransactionsTableAdapter;
            this.tableAdapterManager.May_TransactionsTableAdapter = null;
            this.tableAdapterManager.Nov_TransactionsTableAdapter = null;
            this.tableAdapterManager.Oct_TransactionsTableAdapter = null;
            this.tableAdapterManager.Sep_TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project4.project4dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(108, 158);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(108, 184);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(121, 20);
            this.departmentTextBox.TabIndex = 8;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(108, 210);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(121, 20);
            this.positionTextBox.TabIndex = 10;
            // 
            // salary_RateTextBox
            // 
            this.salary_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Salary Rate", true));
            this.salary_RateTextBox.Location = new System.Drawing.Point(108, 236);
            this.salary_RateTextBox.Name = "salary_RateTextBox";
            this.salary_RateTextBox.Size = new System.Drawing.Size(121, 20);
            this.salary_RateTextBox.TabIndex = 12;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Medical", true));
            this.medicalTextBox.Location = new System.Drawing.Point(108, 262);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(121, 20);
            this.medicalTextBox.TabIndex = 14;
            // 
            // life_InsuranceTextBox
            // 
            this.life_InsuranceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Life Insurance", true));
            this.life_InsuranceTextBox.Location = new System.Drawing.Point(108, 288);
            this.life_InsuranceTextBox.Name = "life_InsuranceTextBox";
            this.life_InsuranceTextBox.Size = new System.Drawing.Size(121, 20);
            this.life_InsuranceTextBox.TabIndex = 16;
            // 
            // _401KTextBox
            // 
            this._401KTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "401K", true));
            this._401KTextBox.Location = new System.Drawing.Point(108, 314);
            this._401KTextBox.Name = "_401KTextBox";
            this._401KTextBox.Size = new System.Drawing.Size(121, 20);
            this._401KTextBox.TabIndex = 18;
            // 
            // fSATextBox
            // 
            this.fSATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "FSA", true));
            this.fSATextBox.Location = new System.Drawing.Point(108, 340);
            this.fSATextBox.Name = "fSATextBox";
            this.fSATextBox.Size = new System.Drawing.Size(121, 20);
            this.fSATextBox.TabIndex = 20;
            // 
            // employee_NameComboBox
            // 
            this.employee_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Employee Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.employee_NameComboBox.DataSource = this.master_TransactionsBindingSource;
            this.employee_NameComboBox.DisplayMember = "Employee Name";
            this.employee_NameComboBox.FormattingEnabled = true;
            this.employee_NameComboBox.Location = new System.Drawing.Point(108, 131);
            this.employee_NameComboBox.Name = "employee_NameComboBox";
            this.employee_NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.employee_NameComboBox.TabIndex = 21;
            // 
            // jan_TransactionsBindingSource
            // 
            this.jan_TransactionsBindingSource.DataMember = "Jan_Transactions";
            this.jan_TransactionsBindingSource.DataSource = this.project4dataDataSet;
            // 
            // jan_TransactionsTableAdapter
            // 
            this.jan_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jan_TransactionsBindingSource, "EmployeeID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.employeeIDComboBox.DataSource = this.jan_TransactionsBindingSource;
            this.employeeIDComboBox.DisplayMember = "EmployeeID";
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(361, 128);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeIDComboBox.TabIndex = 22;
            // 
            // workedHoursTextBox
            // 
            this.workedHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jan_TransactionsBindingSource, "WorkedHours", true));
            this.workedHoursTextBox.Location = new System.Drawing.Point(361, 155);
            this.workedHoursTextBox.Name = "workedHoursTextBox";
            this.workedHoursTextBox.Size = new System.Drawing.Size(121, 20);
            this.workedHoursTextBox.TabIndex = 24;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 462);
            this.Controls.Add(employeeIDLabel1);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(workedHoursLabel);
            this.Controls.Add(this.workedHoursTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employee_NameComboBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(employee_NameLabel1);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(salary_RateLabel);
            this.Controls.Add(this.salary_RateTextBox);
            this.Controls.Add(medicalLabel);
            this.Controls.Add(this.medicalTextBox);
            this.Controls.Add(life_InsuranceLabel);
            this.Controls.Add(this.life_InsuranceTextBox);
            this.Controls.Add(_401KLabel);
            this.Controls.Add(this._401KTextBox);
            this.Controls.Add(fSALabel);
            this.Controls.Add(this.fSATextBox);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Controls.SetChildIndex(this.fSATextBox, 0);
            this.Controls.SetChildIndex(fSALabel, 0);
            this.Controls.SetChildIndex(this._401KTextBox, 0);
            this.Controls.SetChildIndex(_401KLabel, 0);
            this.Controls.SetChildIndex(this.life_InsuranceTextBox, 0);
            this.Controls.SetChildIndex(life_InsuranceLabel, 0);
            this.Controls.SetChildIndex(this.medicalTextBox, 0);
            this.Controls.SetChildIndex(medicalLabel, 0);
            this.Controls.SetChildIndex(this.salary_RateTextBox, 0);
            this.Controls.SetChildIndex(salary_RateLabel, 0);
            this.Controls.SetChildIndex(this.positionTextBox, 0);
            this.Controls.SetChildIndex(positionLabel, 0);
            this.Controls.SetChildIndex(this.departmentTextBox, 0);
            this.Controls.SetChildIndex(employee_NameLabel1, 0);
            this.Controls.SetChildIndex(departmentLabel, 0);
            this.Controls.SetChildIndex(this.employeeIDTextBox, 0);
            this.Controls.SetChildIndex(this.employee_NameComboBox, 0);
            this.Controls.SetChildIndex(employeeIDLabel, 0);
            this.Controls.SetChildIndex(this.workedHoursTextBox, 0);
            this.Controls.SetChildIndex(workedHoursLabel, 0);
            this.Controls.SetChildIndex(this.employeeIDComboBox, 0);
            this.Controls.SetChildIndex(employeeIDLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jan_TransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private project4dataDataSet project4dataDataSet;
        private System.Windows.Forms.BindingSource master_TransactionsBindingSource;
        private project4dataDataSetTableAdapters.Master_TransactionsTableAdapter master_TransactionsTableAdapter;
        private project4dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox salary_RateTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.TextBox life_InsuranceTextBox;
        private System.Windows.Forms.TextBox _401KTextBox;
        private System.Windows.Forms.TextBox fSATextBox;
        private System.Windows.Forms.ComboBox employee_NameComboBox;
        private System.Windows.Forms.BindingSource jan_TransactionsBindingSource;
        private project4dataDataSetTableAdapters.Jan_TransactionsTableAdapter jan_TransactionsTableAdapter;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.TextBox workedHoursTextBox;

    }
}