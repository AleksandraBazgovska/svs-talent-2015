namespace CSharpProgrammingBasicsTransactionApp
{
    partial class frmMain
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
            this.Transsaction = new System.Windows.Forms.GroupBox();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblEndDate_To = new System.Windows.Forms.Label();
            this.lblStartDate_To = new System.Windows.Forms.Label();
            this.lblInterest_To = new System.Windows.Forms.Label();
            this.lblPeriod_To = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblLimit_To = new System.Windows.Forms.Label();
            this.lblLimitCurrency_To = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblBalance_To = new System.Windows.Forms.Label();
            this.lblCurrency_To = new System.Windows.Forms.Label();
            this.lblNumber_To = new System.Windows.Forms.Label();
            this.lblID_To = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Transsaction.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transsaction
            // 
            this.Transsaction.Controls.Add(this.btnMakeTransaction);
            this.Transsaction.Controls.Add(this.groupBox6);
            this.Transsaction.Controls.Add(this.btnCreateTransactionAccount);
            this.Transsaction.Controls.Add(this.btnCreateDepositAccount);
            this.Transsaction.Controls.Add(this.groupBox3);
            this.Transsaction.Controls.Add(this.groupBox1);
            this.Transsaction.Location = new System.Drawing.Point(12, 12);
            this.Transsaction.Name = "Transsaction";
            this.Transsaction.Size = new System.Drawing.Size(796, 410);
            this.Transsaction.TabIndex = 2;
            this.Transsaction.TabStop = false;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(582, 90);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(175, 26);
            this.btnMakeTransaction.TabIndex = 13;
            this.btnMakeTransaction.Text = "Transfer transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(399, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 244);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Second Account Details";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblEndDate_To);
            this.groupBox7.Controls.Add(this.lblStartDate_To);
            this.groupBox7.Controls.Add(this.lblInterest_To);
            this.groupBox7.Controls.Add(this.lblPeriod_To);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Location = new System.Drawing.Point(183, 111);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(204, 125);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Deposit Account Properties";
            // 
            // lblEndDate_To
            // 
            this.lblEndDate_To.AutoSize = true;
            this.lblEndDate_To.Location = new System.Drawing.Point(94, 101);
            this.lblEndDate_To.Name = "lblEndDate_To";
            this.lblEndDate_To.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate_To.TabIndex = 27;
            // 
            // lblStartDate_To
            // 
            this.lblStartDate_To.AutoSize = true;
            this.lblStartDate_To.Location = new System.Drawing.Point(94, 76);
            this.lblStartDate_To.Name = "lblStartDate_To";
            this.lblStartDate_To.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate_To.TabIndex = 26;
            // 
            // lblInterest_To
            // 
            this.lblInterest_To.AutoSize = true;
            this.lblInterest_To.Location = new System.Drawing.Point(94, 49);
            this.lblInterest_To.Name = "lblInterest_To";
            this.lblInterest_To.Size = new System.Drawing.Size(0, 13);
            this.lblInterest_To.TabIndex = 25;
            // 
            // lblPeriod_To
            // 
            this.lblPeriod_To.AutoSize = true;
            this.lblPeriod_To.Location = new System.Drawing.Point(94, 25);
            this.lblPeriod_To.Name = "lblPeriod_To";
            this.lblPeriod_To.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod_To.TabIndex = 24;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "End Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Start Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Interest";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Period";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblLimit_To);
            this.groupBox8.Controls.Add(this.lblLimitCurrency_To);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Location = new System.Drawing.Point(183, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(204, 72);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Transaction Account Properties";
            // 
            // lblLimit_To
            // 
            this.lblLimit_To.AutoSize = true;
            this.lblLimit_To.Location = new System.Drawing.Point(94, 49);
            this.lblLimit_To.Name = "lblLimit_To";
            this.lblLimit_To.Size = new System.Drawing.Size(0, 13);
            this.lblLimit_To.TabIndex = 25;
            // 
            // lblLimitCurrency_To
            // 
            this.lblLimitCurrency_To.AutoSize = true;
            this.lblLimitCurrency_To.Location = new System.Drawing.Point(94, 25);
            this.lblLimitCurrency_To.Name = "lblLimitCurrency_To";
            this.lblLimitCurrency_To.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency_To.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 19;
            this.label27.Text = "Limit";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "Limit Currency";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblBalance_To);
            this.groupBox9.Controls.Add(this.lblCurrency_To);
            this.groupBox9.Controls.Add(this.lblNumber_To);
            this.groupBox9.Controls.Add(this.lblID_To);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Location = new System.Drawing.Point(6, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(171, 211);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Default Characteristics";
            // 
            // lblBalance_To
            // 
            this.lblBalance_To.AutoSize = true;
            this.lblBalance_To.Location = new System.Drawing.Point(94, 101);
            this.lblBalance_To.Name = "lblBalance_To";
            this.lblBalance_To.Size = new System.Drawing.Size(0, 13);
            this.lblBalance_To.TabIndex = 27;
            // 
            // lblCurrency_To
            // 
            this.lblCurrency_To.AutoSize = true;
            this.lblCurrency_To.Location = new System.Drawing.Point(94, 76);
            this.lblCurrency_To.Name = "lblCurrency_To";
            this.lblCurrency_To.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency_To.TabIndex = 26;
            // 
            // lblNumber_To
            // 
            this.lblNumber_To.AutoSize = true;
            this.lblNumber_To.Location = new System.Drawing.Point(94, 49);
            this.lblNumber_To.Name = "lblNumber_To";
            this.lblNumber_To.Size = new System.Drawing.Size(0, 13);
            this.lblNumber_To.TabIndex = 25;
            // 
            // lblID_To
            // 
            this.lblID_To.AutoSize = true;
            this.lblID_To.Location = new System.Drawing.Point(94, 25);
            this.lblID_To.Name = "lblID_To";
            this.lblID_To.Size = new System.Drawing.Size(0, 13);
            this.lblID_To.TabIndex = 24;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(11, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 23;
            this.label33.Text = "Balance";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 77);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 13);
            this.label34.TabIndex = 21;
            this.label34.Text = "Currency";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 49);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 19;
            this.label35.Text = "Number";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(11, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(18, 13);
            this.label36.TabIndex = 17;
            this.label36.Text = "ID";
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(582, 19);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(175, 27);
            this.btnCreateTransactionAccount.TabIndex = 10;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click_1);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(582, 56);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(175, 28);
            this.btnCreateDepositAccount.TabIndex = 11;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtLimit);
            this.groupBox3.Controls.Add(this.txtCurrency);
            this.groupBox3.Location = new System.Drawing.Point(0, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 141);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Account Characteristics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Limit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Limit Currency";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(96, 59);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(104, 20);
            this.txtLimit.TabIndex = 6;
            this.txtLimit.Text = "10000";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(96, 23);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(104, 20);
            this.txtCurrency.TabIndex = 5;
            this.txtCurrency.Text = "MKD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPercent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(248, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Account Characteristics";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.comboBox2.Location = new System.Drawing.Point(177, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(177, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(77, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(60, 49);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interest";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(60, 25);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 244);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First Account Details";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblEndDate);
            this.groupBox5.Controls.Add(this.lblStartdate);
            this.groupBox5.Controls.Add(this.lblInterest);
            this.groupBox5.Controls.Add(this.lblPeriod);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(185, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 125);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Deposit Account Properties";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(94, 101);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 27;
            // 
            // lblStartdate
            // 
            this.lblStartdate.AutoSize = true;
            this.lblStartdate.Location = new System.Drawing.Point(94, 76);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(0, 13);
            this.lblStartdate.TabIndex = 26;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(94, 49);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(0, 13);
            this.lblInterest.TabIndex = 25;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(94, 25);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "End Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Start Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Interest";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Period";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLimit);
            this.groupBox4.Controls.Add(this.lblLimitCurrency);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(185, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 72);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Account Properties";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(94, 49);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(0, 13);
            this.lblLimit.TabIndex = 25;
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(94, 25);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Limit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Limit Currency";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblBalance);
            this.groupBox10.Controls.Add(this.lblCurrency);
            this.groupBox10.Controls.Add(this.lblNumber);
            this.groupBox10.Controls.Add(this.lblID);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Location = new System.Drawing.Point(8, 25);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(171, 213);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Default Characteristics";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(94, 101);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 27;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(94, 76);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 26;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(94, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(94, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Currency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Transsaction);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Transsaction.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Transsaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblEndDate_To;
        private System.Windows.Forms.Label lblStartDate_To;
        private System.Windows.Forms.Label lblInterest_To;
        private System.Windows.Forms.Label lblPeriod_To;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblLimit_To;
        private System.Windows.Forms.Label lblLimitCurrency_To;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblBalance_To;
        private System.Windows.Forms.Label lblCurrency_To;
        private System.Windows.Forms.Label lblNumber_To;
        private System.Windows.Forms.Label lblID_To;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartdate;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMakeTransaction;
    }
}

