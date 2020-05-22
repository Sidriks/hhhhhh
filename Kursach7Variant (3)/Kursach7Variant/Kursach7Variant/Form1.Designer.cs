namespace Kursach7Variant
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientGeneralTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.debtTextBox = new System.Windows.Forms.TextBox();
            this.labelDebt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentStampCheckBox = new System.Windows.Forms.CheckBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelWorkType = new System.Windows.Forms.Label();
            this.workTypeComboBox = new System.Windows.Forms.ComboBox();
            this.patientAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.patientMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.patientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.registrationPatientGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchDebtComboBox = new System.Windows.Forms.ComboBox();
            this.searchDebtButton = new System.Windows.Forms.Button();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.searchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.patientSearchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patietnSearchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchPaymentStamp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patientSearchDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientWorkCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPaymentStamp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patientDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.patientGeneralTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationPatientGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileActionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileActionsToolStripMenuItem
            // 
            this.fileActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToToolStripMenuItem,
            this.readFromToolStripMenuItem});
            this.fileActionsToolStripMenuItem.Name = "fileActionsToolStripMenuItem";
            this.fileActionsToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.fileActionsToolStripMenuItem.Text = "File Actions";
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToToolStripMenuItem.Text = "Save to";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // readFromToolStripMenuItem
            // 
            this.readFromToolStripMenuItem.Name = "readFromToolStripMenuItem";
            this.readFromToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readFromToolStripMenuItem.Text = "Read from";
            this.readFromToolStripMenuItem.Click += new System.EventHandler(this.readFromToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientGeneralTabControl
            // 
            this.patientGeneralTabControl.Controls.Add(this.tabPage1);
            this.patientGeneralTabControl.Controls.Add(this.tabPage2);
            this.patientGeneralTabControl.Location = new System.Drawing.Point(12, 31);
            this.patientGeneralTabControl.Name = "patientGeneralTabControl";
            this.patientGeneralTabControl.SelectedIndex = 0;
            this.patientGeneralTabControl.Size = new System.Drawing.Size(1117, 585);
            this.patientGeneralTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deletePatientButton);
            this.tabPage1.Controls.Add(this.addPatientButton);
            this.tabPage1.Controls.Add(this.debtTextBox);
            this.tabPage1.Controls.Add(this.labelDebt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.paymentStampCheckBox);
            this.tabPage1.Controls.Add(this.costTextBox);
            this.tabPage1.Controls.Add(this.labelCost);
            this.tabPage1.Controls.Add(this.labelWorkType);
            this.tabPage1.Controls.Add(this.workTypeComboBox);
            this.tabPage1.Controls.Add(this.patientAccountNumberTextBox);
            this.tabPage1.Controls.Add(this.labelAccountNumber);
            this.tabPage1.Controls.Add(this.patientMiddleNameTextBox);
            this.tabPage1.Controls.Add(this.labelMiddleName);
            this.tabPage1.Controls.Add(this.patientLastNameTextBox);
            this.tabPage1.Controls.Add(this.labelLastName);
            this.tabPage1.Controls.Add(this.patientTextBox);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.registrationPatientGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Location = new System.Drawing.Point(840, 462);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(123, 65);
            this.deletePatientButton.TabIndex = 18;
            this.deletePatientButton.Text = "Delete patients if debt = 0";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(642, 462);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(123, 65);
            this.addPatientButton.TabIndex = 17;
            this.addPatientButton.Text = "Add patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // debtTextBox
            // 
            this.debtTextBox.Location = new System.Drawing.Point(629, 405);
            this.debtTextBox.Name = "debtTextBox";
            this.debtTextBox.Size = new System.Drawing.Size(59, 22);
            this.debtTextBox.TabIndex = 16;
            // 
            // labelDebt
            // 
            this.labelDebt.AutoSize = true;
            this.labelDebt.Location = new System.Drawing.Point(577, 408);
            this.labelDebt.Name = "labelDebt";
            this.labelDebt.Size = new System.Drawing.Size(38, 17);
            this.labelDebt.TabIndex = 15;
            this.labelDebt.Text = "Debt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payment Stamp";
            // 
            // paymentStampCheckBox
            // 
            this.paymentStampCheckBox.AutoSize = true;
            this.paymentStampCheckBox.Location = new System.Drawing.Point(404, 483);
            this.paymentStampCheckBox.Name = "paymentStampCheckBox";
            this.paymentStampCheckBox.Size = new System.Drawing.Size(18, 17);
            this.paymentStampCheckBox.TabIndex = 13;
            this.paymentStampCheckBox.UseVisualStyleBackColor = true;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(365, 440);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(153, 22);
            this.costTextBox.TabIndex = 12;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(276, 443);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(73, 17);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Work Cost";
            // 
            // labelWorkType
            // 
            this.labelWorkType.AutoSize = true;
            this.labelWorkType.Location = new System.Drawing.Point(261, 405);
            this.labelWorkType.Name = "labelWorkType";
            this.labelWorkType.Size = new System.Drawing.Size(77, 17);
            this.labelWorkType.TabIndex = 10;
            this.labelWorkType.Text = "Work Type";
            // 
            // workTypeComboBox
            // 
            this.workTypeComboBox.FormattingEnabled = true;
            this.workTypeComboBox.Items.AddRange(new object[] {
            "Протезирование",
            "Пломбирование",
            "Имплантация"});
            this.workTypeComboBox.Location = new System.Drawing.Point(344, 402);
            this.workTypeComboBox.Name = "workTypeComboBox";
            this.workTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.workTypeComboBox.TabIndex = 9;
            // 
            // patientAccountNumberTextBox
            // 
            this.patientAccountNumberTextBox.Location = new System.Drawing.Point(125, 483);
            this.patientAccountNumberTextBox.Name = "patientAccountNumberTextBox";
            this.patientAccountNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patientAccountNumberTextBox.TabIndex = 8;
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(6, 486);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(113, 17);
            this.labelAccountNumber.TabIndex = 7;
            this.labelAccountNumber.Text = "Account Number";
            // 
            // patientMiddleNameTextBox
            // 
            this.patientMiddleNameTextBox.Location = new System.Drawing.Point(101, 455);
            this.patientMiddleNameTextBox.Name = "patientMiddleNameTextBox";
            this.patientMiddleNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.patientMiddleNameTextBox.TabIndex = 6;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(6, 458);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(90, 17);
            this.labelMiddleName.TabIndex = 5;
            this.labelMiddleName.Text = "Middle Name";
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.Location = new System.Drawing.Point(101, 427);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.patientLastNameTextBox.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 430);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(101, 402);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(100, 22);
            this.patientTextBox.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 402);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // registrationPatientGridView
            // 
            this.registrationPatientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.registrationPatientGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.registrationPatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationPatientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientLastName,
            this.PatientMiddleName,
            this.patientAccountNumber,
            this.patientWorkType,
            this.patientWorkCost,
            this.patientPaymentStamp,
            this.patientDebt});
            this.registrationPatientGridView.Location = new System.Drawing.Point(3, 6);
            this.registrationPatientGridView.Name = "registrationPatientGridView";
            this.registrationPatientGridView.RowHeadersWidth = 51;
            this.registrationPatientGridView.RowTemplate.Height = 24;
            this.registrationPatientGridView.Size = new System.Drawing.Size(1096, 371);
            this.registrationPatientGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchDebtComboBox);
            this.tabPage2.Controls.Add(this.searchDebtButton);
            this.tabPage2.Controls.Add(this.searchPatientButton);
            this.tabPage2.Controls.Add(this.searchLastNameTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.searchGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchDebtComboBox
            // 
            this.searchDebtComboBox.FormattingEnabled = true;
            this.searchDebtComboBox.Items.AddRange(new object[] {
            "Протезирование",
            "Пломбирование",
            "Имплантация"});
            this.searchDebtComboBox.Location = new System.Drawing.Point(708, 415);
            this.searchDebtComboBox.Name = "searchDebtComboBox";
            this.searchDebtComboBox.Size = new System.Drawing.Size(163, 24);
            this.searchDebtComboBox.TabIndex = 6;
            // 
            // searchDebtButton
            // 
            this.searchDebtButton.Location = new System.Drawing.Point(591, 402);
            this.searchDebtButton.Name = "searchDebtButton";
            this.searchDebtButton.Size = new System.Drawing.Size(98, 49);
            this.searchDebtButton.TabIndex = 5;
            this.searchDebtButton.Text = "Search Debt Patients";
            this.searchDebtButton.UseVisualStyleBackColor = true;
            this.searchDebtButton.Click += new System.EventHandler(this.searchDebtButton_Click);
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(155, 440);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(92, 55);
            this.searchPatientButton.TabIndex = 4;
            this.searchPatientButton.Text = "Search";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // searchLastNameTextBox
            // 
            this.searchLastNameTextBox.Location = new System.Drawing.Point(193, 412);
            this.searchLastNameTextBox.Name = "searchLastNameTextBox";
            this.searchLastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchLastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Search Last Name";
            // 
            // searchGridView
            // 
            this.searchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientSearchID,
            this.patietnSearchName,
            this.patientSearchLastName,
            this.patientSearchMiddleName,
            this.patientSearchAccountNumber,
            this.patientSearchWorkType,
            this.patientSearchCost,
            this.patientSearchPaymentStamp,
            this.patientSearchDebt});
            this.searchGridView.Location = new System.Drawing.Point(3, 6);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowHeadersWidth = 51;
            this.searchGridView.RowTemplate.Height = 24;
            this.searchGridView.Size = new System.Drawing.Size(1096, 371);
            this.searchGridView.TabIndex = 1;
            // 
            // patientSearchID
            // 
            this.patientSearchID.Frozen = true;
            this.patientSearchID.HeaderText = "Patient Number";
            this.patientSearchID.MinimumWidth = 6;
            this.patientSearchID.Name = "patientSearchID";
            this.patientSearchID.ReadOnly = true;
            this.patientSearchID.Width = 124;
            // 
            // patietnSearchName
            // 
            this.patietnSearchName.Frozen = true;
            this.patietnSearchName.HeaderText = "Patient Name";
            this.patietnSearchName.MinimumWidth = 6;
            this.patietnSearchName.Name = "patietnSearchName";
            this.patietnSearchName.ReadOnly = true;
            this.patietnSearchName.Width = 112;
            // 
            // patientSearchLastName
            // 
            this.patientSearchLastName.Frozen = true;
            this.patientSearchLastName.HeaderText = "Patient Last Name";
            this.patientSearchLastName.MinimumWidth = 6;
            this.patientSearchLastName.Name = "patientSearchLastName";
            this.patientSearchLastName.ReadOnly = true;
            this.patientSearchLastName.Width = 107;
            // 
            // patientSearchMiddleName
            // 
            this.patientSearchMiddleName.Frozen = true;
            this.patientSearchMiddleName.HeaderText = "Patient Middle Name";
            this.patientSearchMiddleName.MinimumWidth = 6;
            this.patientSearchMiddleName.Name = "patientSearchMiddleName";
            this.patientSearchMiddleName.ReadOnly = true;
            this.patientSearchMiddleName.Width = 119;
            // 
            // patientSearchAccountNumber
            // 
            this.patientSearchAccountNumber.Frozen = true;
            this.patientSearchAccountNumber.HeaderText = "Account Number";
            this.patientSearchAccountNumber.MinimumWidth = 6;
            this.patientSearchAccountNumber.Name = "patientSearchAccountNumber";
            this.patientSearchAccountNumber.ReadOnly = true;
            this.patientSearchAccountNumber.Width = 130;
            // 
            // patientSearchWorkType
            // 
            this.patientSearchWorkType.Frozen = true;
            this.patientSearchWorkType.HeaderText = "Work Type";
            this.patientSearchWorkType.MinimumWidth = 6;
            this.patientSearchWorkType.Name = "patientSearchWorkType";
            this.patientSearchWorkType.ReadOnly = true;
            this.patientSearchWorkType.Width = 98;
            // 
            // patientSearchCost
            // 
            this.patientSearchCost.Frozen = true;
            this.patientSearchCost.HeaderText = "Cost";
            this.patientSearchCost.MinimumWidth = 6;
            this.patientSearchCost.Name = "patientSearchCost";
            this.patientSearchCost.ReadOnly = true;
            this.patientSearchCost.Width = 65;
            // 
            // patientSearchPaymentStamp
            // 
            this.patientSearchPaymentStamp.Frozen = true;
            this.patientSearchPaymentStamp.HeaderText = "Payment Stamp";
            this.patientSearchPaymentStamp.MinimumWidth = 6;
            this.patientSearchPaymentStamp.Name = "patientSearchPaymentStamp";
            this.patientSearchPaymentStamp.ReadOnly = true;
            this.patientSearchPaymentStamp.Width = 102;
            // 
            // patientSearchDebt
            // 
            this.patientSearchDebt.Frozen = true;
            this.patientSearchDebt.HeaderText = "Debt";
            this.patientSearchDebt.MinimumWidth = 6;
            this.patientSearchDebt.Name = "patientSearchDebt";
            this.patientSearchDebt.ReadOnly = true;
            this.patientSearchDebt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientSearchDebt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patientSearchDebt.Width = 44;
            // 
            // PatientID
            // 
            this.PatientID.Frozen = true;
            this.PatientID.HeaderText = "Patient Number";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 124;
            // 
            // PatientName
            // 
            this.PatientName.Frozen = true;
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 112;
            // 
            // PatientLastName
            // 
            this.PatientLastName.Frozen = true;
            this.PatientLastName.HeaderText = "Patient Last Name";
            this.PatientLastName.MinimumWidth = 6;
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.ReadOnly = true;
            this.PatientLastName.Width = 107;
            // 
            // PatientMiddleName
            // 
            this.PatientMiddleName.Frozen = true;
            this.PatientMiddleName.HeaderText = "Patient Middle Name";
            this.PatientMiddleName.MinimumWidth = 6;
            this.PatientMiddleName.Name = "PatientMiddleName";
            this.PatientMiddleName.ReadOnly = true;
            this.PatientMiddleName.Width = 119;
            // 
            // patientAccountNumber
            // 
            this.patientAccountNumber.Frozen = true;
            this.patientAccountNumber.HeaderText = "Account Number";
            this.patientAccountNumber.MinimumWidth = 6;
            this.patientAccountNumber.Name = "patientAccountNumber";
            this.patientAccountNumber.ReadOnly = true;
            this.patientAccountNumber.Width = 130;
            // 
            // patientWorkType
            // 
            this.patientWorkType.Frozen = true;
            this.patientWorkType.HeaderText = "Work Type";
            this.patientWorkType.MinimumWidth = 6;
            this.patientWorkType.Name = "patientWorkType";
            this.patientWorkType.ReadOnly = true;
            this.patientWorkType.Width = 98;
            // 
            // patientWorkCost
            // 
            this.patientWorkCost.Frozen = true;
            this.patientWorkCost.HeaderText = "Cost";
            this.patientWorkCost.MinimumWidth = 6;
            this.patientWorkCost.Name = "patientWorkCost";
            this.patientWorkCost.ReadOnly = true;
            this.patientWorkCost.Width = 65;
            // 
            // patientPaymentStamp
            // 
            this.patientPaymentStamp.Frozen = true;
            this.patientPaymentStamp.HeaderText = "Payment Stamp";
            this.patientPaymentStamp.MinimumWidth = 6;
            this.patientPaymentStamp.Name = "patientPaymentStamp";
            this.patientPaymentStamp.ReadOnly = true;
            this.patientPaymentStamp.Width = 102;
            // 
            // patientDebt
            // 
            this.patientDebt.Frozen = true;
            this.patientDebt.HeaderText = "Debt";
            this.patientDebt.MinimumWidth = 6;
            this.patientDebt.Name = "patientDebt";
            this.patientDebt.ReadOnly = true;
            this.patientDebt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDebt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patientDebt.Width = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 619);
            this.Controls.Add(this.patientGeneralTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.patientGeneralTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationPatientGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl patientGeneralTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView registrationPatientGridView;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patietnSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patientSearchPaymentStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSearchDebt;
        private System.Windows.Forms.Label labelWorkType;
        private System.Windows.Forms.ComboBox workTypeComboBox;
        private System.Windows.Forms.TextBox patientAccountNumberTextBox;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.TextBox patientMiddleNameTextBox;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox patientLastNameTextBox;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox patientTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.TextBox debtTextBox;
        private System.Windows.Forms.Label labelDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox paymentStampCheckBox;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.TextBox searchLastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchDebtComboBox;
        private System.Windows.Forms.Button searchDebtButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientWorkCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patientPaymentStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDebt;
    }
}

