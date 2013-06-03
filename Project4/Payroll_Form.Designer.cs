namespace Project4
{
    partial class Payroll_Form
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
            System.Windows.Forms.Label employee_NameLabel1;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label salary_RateLabel;
            System.Windows.Forms.Label medicalLabel;
            System.Windows.Forms.Label life_InsuranceLabel;
            System.Windows.Forms.Label _401KLabel;
            System.Windows.Forms.Label fSALabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITbutton = new System.Windows.Forms.Button();
            this.monthsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employee_NameComboBox = new System.Windows.Forms.ComboBox();
            this.master_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project4dataDataSet = new Project4.project4dataDataSet();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salary_RateTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.life_InsuranceTextBox = new System.Windows.Forms.TextBox();
            this._401KTextBox = new System.Windows.Forms.TextBox();
            this.fSATextBox = new System.Windows.Forms.TextBox();
            this.masterTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project4dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTransactionsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.masterTransactionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.masterTransactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.update401kButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checksButton = new System.Windows.Forms.Button();
            this.master_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Master_TransactionsTableAdapter();
            this.tableAdapterManager = new Project4.project4dataDataSetTableAdapters.TableAdapterManager();
            this.masterTransactionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.jan_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jan_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Jan_TransactionsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.project4dataDataSet1 = new Project4.project4dataDataSet();
            this.febTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feb_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Feb_TransactionsTableAdapter();
            this.marTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mar_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Mar_TransactionsTableAdapter();
            this.aprTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apr_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Apr_TransactionsTableAdapter();
            this.mayTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.may_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.May_TransactionsTableAdapter();
            this.junTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jun_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Jun_TransactionsTableAdapter();
            this.julTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jul_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Jul_TransactionsTableAdapter();
            this.augTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aug_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Aug_TransactionsTableAdapter();
            this.sepTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sep_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Sep_TransactionsTableAdapter();
            this.octTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oct_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Oct_TransactionsTableAdapter();
            this.novTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nov_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Nov_TransactionsTableAdapter();
            this.decTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dec_TransactionsTableAdapter = new Project4.project4dataDataSetTableAdapters.Dec_TransactionsTableAdapter();
            employeeIDLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            employee_NameLabel1 = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            salary_RateLabel = new System.Windows.Forms.Label();
            medicalLabel = new System.Windows.Forms.Label();
            life_InsuranceLabel = new System.Windows.Forms.Label();
            _401KLabel = new System.Windows.Forms.Label();
            fSALabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jan_TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.julTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.augTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(10, 62);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 22;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(10, 88);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 24;
            departmentLabel.Text = "Department:";
            // 
            // employee_NameLabel1
            // 
            employee_NameLabel1.AutoSize = true;
            employee_NameLabel1.Location = new System.Drawing.Point(10, 35);
            employee_NameLabel1.Name = "employee_NameLabel1";
            employee_NameLabel1.Size = new System.Drawing.Size(87, 13);
            employee_NameLabel1.TabIndex = 38;
            employee_NameLabel1.Text = "Employee Name:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(10, 114);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 26;
            positionLabel.Text = "Position:";
            // 
            // salary_RateLabel
            // 
            salary_RateLabel.AutoSize = true;
            salary_RateLabel.Location = new System.Drawing.Point(10, 140);
            salary_RateLabel.Name = "salary_RateLabel";
            salary_RateLabel.Size = new System.Drawing.Size(65, 13);
            salary_RateLabel.TabIndex = 28;
            salary_RateLabel.Text = "Salary Rate:";
            // 
            // medicalLabel
            // 
            medicalLabel.AutoSize = true;
            medicalLabel.Location = new System.Drawing.Point(10, 166);
            medicalLabel.Name = "medicalLabel";
            medicalLabel.Size = new System.Drawing.Size(47, 13);
            medicalLabel.TabIndex = 30;
            medicalLabel.Text = "Medical:";
            // 
            // life_InsuranceLabel
            // 
            life_InsuranceLabel.AutoSize = true;
            life_InsuranceLabel.Location = new System.Drawing.Point(10, 192);
            life_InsuranceLabel.Name = "life_InsuranceLabel";
            life_InsuranceLabel.Size = new System.Drawing.Size(77, 13);
            life_InsuranceLabel.TabIndex = 32;
            life_InsuranceLabel.Text = "Life Insurance:";
            // 
            // _401KLabel
            // 
            _401KLabel.AutoSize = true;
            _401KLabel.Location = new System.Drawing.Point(10, 218);
            _401KLabel.Name = "_401KLabel";
            _401KLabel.Size = new System.Drawing.Size(35, 13);
            _401KLabel.TabIndex = 34;
            _401KLabel.Text = "401K:";
            // 
            // fSALabel
            // 
            fSALabel.AutoSize = true;
            fSALabel.Location = new System.Drawing.Point(10, 244);
            fSALabel.Name = "fSALabel";
            fSALabel.Size = new System.Drawing.Size(30, 13);
            fSALabel.TabIndex = 36;
            fSALabel.Text = "FSA:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.eXITToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.EXITbutton_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.createChecksToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.addToolStripMenuItem1.Text = "&Add Employee";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteToolStripMenuItem.Text = "&Remove Employee";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.calculateToolStripMenuItem.Text = "&Process";
            // 
            // createChecksToolStripMenuItem
            // 
            this.createChecksToolStripMenuItem.Name = "createChecksToolStripMenuItem";
            this.createChecksToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createChecksToolStripMenuItem.Text = "&Create Checks";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.testFormToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // testFormToolStripMenuItem
            // 
            this.testFormToolStripMenuItem.Name = "testFormToolStripMenuItem";
            this.testFormToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.testFormToolStripMenuItem.Text = "Test Form";
            this.testFormToolStripMenuItem.Click += new System.EventHandler(this.testFormToolStripMenuItem_Click);
            // 
            // EXITbutton
            // 
            this.EXITbutton.Location = new System.Drawing.Point(101, 16);
            this.EXITbutton.Name = "EXITbutton";
            this.EXITbutton.Size = new System.Drawing.Size(75, 27);
            this.EXITbutton.TabIndex = 10;
            this.EXITbutton.Text = "E&xit";
            this.EXITbutton.UseVisualStyleBackColor = true;
            this.EXITbutton.Click += new System.EventHandler(this.EXITbutton_Click);
            // 
            // monthsComboBox
            // 
            this.monthsComboBox.FormattingEnabled = true;
            this.monthsComboBox.Location = new System.Drawing.Point(36, 35);
            this.monthsComboBox.Name = "monthsComboBox";
            this.monthsComboBox.Size = new System.Drawing.Size(130, 21);
            this.monthsComboBox.TabIndex = 11;
            this.monthsComboBox.SelectedIndexChanged += new System.EventHandler(this.monthsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Month to process:";
            // 
            // processingTextBox
            // 
            this.processingTextBox.Location = new System.Drawing.Point(36, 88);
            this.processingTextBox.Name = "processingTextBox";
            this.processingTextBox.ReadOnly = true;
            this.processingTextBox.Size = new System.Drawing.Size(129, 20);
            this.processingTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "File to Process:";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(20, 16);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 27);
            this.processButton.TabIndex = 10;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(employeeIDLabel);
            this.groupBox1.Controls.Add(this.employee_NameComboBox);
            this.groupBox1.Controls.Add(this.employeeIDTextBox);
            this.groupBox1.Controls.Add(departmentLabel);
            this.groupBox1.Controls.Add(employee_NameLabel1);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(positionLabel);
            this.groupBox1.Controls.Add(this.positionTextBox);
            this.groupBox1.Controls.Add(salary_RateLabel);
            this.groupBox1.Controls.Add(this.salary_RateTextBox);
            this.groupBox1.Controls.Add(medicalLabel);
            this.groupBox1.Controls.Add(this.medicalTextBox);
            this.groupBox1.Controls.Add(life_InsuranceLabel);
            this.groupBox1.Controls.Add(this.life_InsuranceTextBox);
            this.groupBox1.Controls.Add(_401KLabel);
            this.groupBox1.Controls.Add(this._401KTextBox);
            this.groupBox1.Controls.Add(fSALabel);
            this.groupBox1.Controls.Add(this.fSATextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 337);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // employee_NameComboBox
            // 
            this.employee_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Employee Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.employee_NameComboBox.DataSource = this.master_TransactionsBindingSource;
            this.employee_NameComboBox.DisplayMember = "Employee Name";
            this.employee_NameComboBox.FormattingEnabled = true;
            this.employee_NameComboBox.Location = new System.Drawing.Point(103, 32);
            this.employee_NameComboBox.Name = "employee_NameComboBox";
            this.employee_NameComboBox.Size = new System.Drawing.Size(151, 21);
            this.employee_NameComboBox.TabIndex = 39;
            // 
            // master_TransactionsBindingSource
            // 
            this.master_TransactionsBindingSource.DataMember = "Master_Transactions";
            this.master_TransactionsBindingSource.DataSource = this.project4dataDataSet;
            // 
            // project4dataDataSet
            // 
            this.project4dataDataSet.DataSetName = "project4dataDataSet";
            this.project4dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(103, 59);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(151, 20);
            this.employeeIDTextBox.TabIndex = 23;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(103, 85);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(151, 20);
            this.departmentTextBox.TabIndex = 25;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(103, 111);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(151, 20);
            this.positionTextBox.TabIndex = 27;
            // 
            // salary_RateTextBox
            // 
            this.salary_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Salary Rate", true));
            this.salary_RateTextBox.Location = new System.Drawing.Point(103, 137);
            this.salary_RateTextBox.Name = "salary_RateTextBox";
            this.salary_RateTextBox.Size = new System.Drawing.Size(151, 20);
            this.salary_RateTextBox.TabIndex = 29;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Medical", true));
            this.medicalTextBox.Location = new System.Drawing.Point(103, 163);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(151, 20);
            this.medicalTextBox.TabIndex = 31;
            // 
            // life_InsuranceTextBox
            // 
            this.life_InsuranceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "Life Insurance", true));
            this.life_InsuranceTextBox.Location = new System.Drawing.Point(103, 189);
            this.life_InsuranceTextBox.Name = "life_InsuranceTextBox";
            this.life_InsuranceTextBox.Size = new System.Drawing.Size(151, 20);
            this.life_InsuranceTextBox.TabIndex = 33;
            // 
            // _401KTextBox
            // 
            this._401KTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "401K", true));
            this._401KTextBox.Location = new System.Drawing.Point(103, 215);
            this._401KTextBox.Name = "_401KTextBox";
            this._401KTextBox.Size = new System.Drawing.Size(151, 20);
            this._401KTextBox.TabIndex = 35;
            // 
            // fSATextBox
            // 
            this.fSATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_TransactionsBindingSource, "FSA", true));
            this.fSATextBox.Location = new System.Drawing.Point(103, 241);
            this.fSATextBox.Name = "fSATextBox";
            this.fSATextBox.Size = new System.Drawing.Size(151, 20);
            this.fSATextBox.TabIndex = 37;
            // 
            // masterTransactionsBindingSource
            // 
            this.masterTransactionsBindingSource.DataMember = "Master_Transactions";
            this.masterTransactionsBindingSource.DataSource = this.project4dataDataSetBindingSource;
            // 
            // project4dataDataSetBindingSource
            // 
            this.project4dataDataSetBindingSource.DataSource = this.project4dataDataSet;
            this.project4dataDataSetBindingSource.Position = 0;
            // 
            // masterTransactionsBindingSource4
            // 
            this.masterTransactionsBindingSource4.DataMember = "Master_Transactions";
            this.masterTransactionsBindingSource4.DataSource = this.project4dataDataSetBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.processingTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.monthsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(281, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 123);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Month Selection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.processButton);
            this.groupBox3.Controls.Add(this.EXITbutton);
            this.groupBox3.Location = new System.Drawing.Point(282, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 53);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // masterTransactionsBindingSource2
            // 
            this.masterTransactionsBindingSource2.DataMember = "Master_Transactions";
            this.masterTransactionsBindingSource2.DataSource = this.project4dataDataSetBindingSource;
            // 
            // masterTransactionsBindingSource1
            // 
            this.masterTransactionsBindingSource1.DataMember = "Master_Transactions";
            this.masterTransactionsBindingSource1.DataSource = this.project4dataDataSetBindingSource;
            // 
            // update401kButton
            // 
            this.update401kButton.Location = new System.Drawing.Point(73, 16);
            this.update401kButton.Name = "update401kButton";
            this.update401kButton.Size = new System.Drawing.Size(96, 27);
            this.update401kButton.TabIndex = 10;
            this.update401kButton.Text = "&Update 401K";
            this.update401kButton.UseVisualStyleBackColor = true;
            this.update401kButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.update401kButton);
            this.groupBox4.Location = new System.Drawing.Point(17, 447);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 53);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // reportComboBox
            // 
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Location = new System.Drawing.Point(29, 48);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(130, 21);
            this.reportComboBox.TabIndex = 11;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.monthsComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Select Report Type:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportButton);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.reportComboBox);
            this.groupBox5.Location = new System.Drawing.Point(281, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 133);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reports";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(44, 88);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(96, 27);
            this.reportButton.TabIndex = 10;
            this.reportButton.Text = "&Create Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checksButton);
            this.groupBox6.Location = new System.Drawing.Point(281, 377);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(191, 64);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employee Checks";
            // 
            // checksButton
            // 
            this.checksButton.Location = new System.Drawing.Point(44, 24);
            this.checksButton.Name = "checksButton";
            this.checksButton.Size = new System.Drawing.Size(96, 27);
            this.checksButton.TabIndex = 10;
            this.checksButton.Text = "&Create Checks";
            this.checksButton.UseVisualStyleBackColor = true;
            this.checksButton.Click += new System.EventHandler(this.processButton_Click);
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
            this.tableAdapterManager.Jan_TransactionsTableAdapter = null;
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
            // masterTransactionsBindingSource3
            // 
            this.masterTransactionsBindingSource3.DataMember = "Master_Transactions";
            this.masterTransactionsBindingSource3.DataSource = this.project4dataDataSetBindingSource;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.decTransactionsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // project4dataDataSet1
            // 
            this.project4dataDataSet1.DataSetName = "project4dataDataSet";
            this.project4dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // febTransactionsBindingSource
            // 
            this.febTransactionsBindingSource.DataMember = "Feb_Transactions";
            this.febTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // feb_TransactionsTableAdapter
            // 
            this.feb_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // marTransactionsBindingSource
            // 
            this.marTransactionsBindingSource.DataMember = "Mar_Transactions";
            this.marTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // mar_TransactionsTableAdapter
            // 
            this.mar_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // aprTransactionsBindingSource
            // 
            this.aprTransactionsBindingSource.DataMember = "Apr_Transactions";
            this.aprTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // apr_TransactionsTableAdapter
            // 
            this.apr_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // mayTransactionsBindingSource
            // 
            this.mayTransactionsBindingSource.DataMember = "May_Transactions";
            this.mayTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // may_TransactionsTableAdapter
            // 
            this.may_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // junTransactionsBindingSource
            // 
            this.junTransactionsBindingSource.DataMember = "Jun_Transactions";
            this.junTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // jun_TransactionsTableAdapter
            // 
            this.jun_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // julTransactionsBindingSource
            // 
            this.julTransactionsBindingSource.DataMember = "Jul_Transactions";
            this.julTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // jul_TransactionsTableAdapter
            // 
            this.jul_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // augTransactionsBindingSource
            // 
            this.augTransactionsBindingSource.DataMember = "Aug_Transactions";
            this.augTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // aug_TransactionsTableAdapter
            // 
            this.aug_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // sepTransactionsBindingSource
            // 
            this.sepTransactionsBindingSource.DataMember = "Sep_Transactions";
            this.sepTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // sep_TransactionsTableAdapter
            // 
            this.sep_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // octTransactionsBindingSource
            // 
            this.octTransactionsBindingSource.DataMember = "Oct_Transactions";
            this.octTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // oct_TransactionsTableAdapter
            // 
            this.oct_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // novTransactionsBindingSource
            // 
            this.novTransactionsBindingSource.DataMember = "Nov_Transactions";
            this.novTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // nov_TransactionsTableAdapter
            // 
            this.nov_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // decTransactionsBindingSource
            // 
            this.decTransactionsBindingSource.DataMember = "Dec_Transactions";
            this.decTransactionsBindingSource.DataSource = this.project4dataDataSet1;
            // 
            // dec_TransactionsTableAdapter
            // 
            this.dec_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // Payroll_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 527);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payroll_Form";
            this.Text = "Payroll Form";
            this.Load += new System.EventHandler(this.Payroll_Form_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterTransactionsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jan_TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project4dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.julTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.augTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button EXITbutton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ComboBox monthsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox processingTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update401kButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem createChecksToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button checksButton;
        private System.Windows.Forms.BindingSource project4dataDataSetBindingSource;
        private project4dataDataSet project4dataDataSet;
        private System.Windows.Forms.BindingSource masterTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Master_TransactionsTableAdapter master_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource master_TransactionsBindingSource;
        private System.Windows.Forms.BindingSource masterTransactionsBindingSource1;
        private System.Windows.Forms.BindingSource masterTransactionsBindingSource2;
        private project4dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource masterTransactionsBindingSource4;
        private System.Windows.Forms.BindingSource masterTransactionsBindingSource3;
        private System.Windows.Forms.ToolStripMenuItem testFormToolStripMenuItem;
        private System.Windows.Forms.ComboBox employee_NameComboBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox salary_RateTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.TextBox life_InsuranceTextBox;
        private System.Windows.Forms.TextBox _401KTextBox;
        private System.Windows.Forms.TextBox fSATextBox;
        private System.Windows.Forms.BindingSource jan_TransactionsBindingSource;
        private project4dataDataSetTableAdapters.Jan_TransactionsTableAdapter jan_TransactionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private project4dataDataSet project4dataDataSet1;
        private System.Windows.Forms.BindingSource febTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Feb_TransactionsTableAdapter feb_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource marTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Mar_TransactionsTableAdapter mar_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource aprTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Apr_TransactionsTableAdapter apr_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource mayTransactionsBindingSource;
        private project4dataDataSetTableAdapters.May_TransactionsTableAdapter may_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource junTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Jun_TransactionsTableAdapter jun_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource julTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Jul_TransactionsTableAdapter jul_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource augTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Aug_TransactionsTableAdapter aug_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource sepTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Sep_TransactionsTableAdapter sep_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource octTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Oct_TransactionsTableAdapter oct_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource novTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Nov_TransactionsTableAdapter nov_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource decTransactionsBindingSource;
        private project4dataDataSetTableAdapters.Dec_TransactionsTableAdapter dec_TransactionsTableAdapter;
    }
}

