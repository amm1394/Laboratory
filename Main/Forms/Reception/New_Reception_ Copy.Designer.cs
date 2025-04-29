namespace RASF.Main.Forms.Reception
{
    partial class New_Reception_Copy
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
        private void  InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout grdPartsMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCompaniesReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Reception));
            Janus.Windows.GridEX.GridEXLayout grdCompanisInvoice_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.companiesBaseList1 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.companiesBaseList2 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.txtReferred = new RASF.General.Controls.TextBox();
            this.label1 = new RASF.General.Controls.Label();
            this.txtLetterNo = new RASF.General.Controls.TextBox();
            this.label2 = new RASF.General.Controls.Label();
            this.DatePickerLetterDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label3 = new RASF.General.Controls.Label();
            this.txtMobileNo = new RASF.General.Controls.TextBox();
            this.label6 = new RASF.General.Controls.Label();
            this.dropDownSampleSendingTypeCode = new RASF.General.Controls.DropDown();
            this.labSampleSendingTypeCode = new RASF.General.Controls.Label();
            this.dropDownUserID = new RASF.General.Controls.DropDown();
            this.labUserID = new RASF.General.Controls.Label();
            this.drpExecuters = new RASF.General.Controls.DropDown();
            this.label4 = new RASF.General.Controls.Label();
            this.drpOffices = new RASF.General.Controls.DropDown();
            this.label5 = new RASF.General.Controls.Label();
            this.txtDescription = new RASF.General.Controls.TextBox();
            this.labDestination = new RASF.General.Controls.Label();
            this.dropDownimmediate = new RASF.General.Controls.DropDown();
            this.labimmediate = new RASF.General.Controls.Label();
            this.dropDownTestForThePresence = new RASF.General.Controls.DropDown();
            this.labTestForThePresence = new RASF.General.Controls.Label();
            this.chksabtsamane = new System.Windows.Forms.CheckBox();
            this.chkStepByStep = new System.Windows.Forms.CheckBox();
            this.chkGhateyat = new System.Windows.Forms.CheckBox();
            this.txtContractNo = new RASF.General.Controls.TextBox();
            this.LabContractNum = new RASF.General.Controls.Label();
            this.DatePickerReceptionDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.labReceptionDate = new RASF.General.Controls.Label();
            this.chkInsPic = new System.Windows.Forms.CheckBox();
            this.chkPersian = new System.Windows.Forms.CheckBox();
            this.DatePickertxtDelivery = new FarsiLibrary.Win.Controls.FADatePicker();
            this.labDelivery = new RASF.General.Controls.Label();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.partsMasterList1 = new RASF.General.Lists.PartsMasterList(this.components);
            this.tabLab = new RASF.General.Controls.TabControl();
            this.userList1 = new RASF.General.Lists.UserList(this.components);
            this.sampleSendingTypeList1 = new RASF.General.Lists.SampleSendingTypeList(this.components);
            this.reportSendingTypeList1 = new RASF.General.Lists.ReportSendingTypeList(this.components);
            this.yes_NoList1 = new RASF.General.Lists.Yes_NoList(this.components);
            this.contractsBaseList1 = new RASF.General.Lists.ContractsBaseList(this.components);
            this.mainTestList1 = new RASF.General.Lists.MainTestList(this.components);
            this.masterTestList1 = new RASF.General.Lists.MasterTestList(this.components);
            this.labList1 = new RASF.General.Lists.LaboratoryList(this.components);
            this.masterteststatusList_Main1 = new RASF.General.Lists.MasterTestStatusList_Main(this.components);
            this.pnlPrice = new RASF.General.Controls.Panel();
            this.lblPrice = new RASF.General.Controls.Label();
            this.partsTestMasterList1 = new RASF.General.Lists.PartsTestMasterList(this.components);
            this.partsTestDetailList1 = new RASF.General.Lists.PartsTestDetailList(this.components);
            this.report = new Stimulsoft.Report.StiReport();
            this.editRecieptionList1 = new RASF.General.Lists.EditRecieptionList(this.components);
            this.companiesActivityTypeList1 = new RASF.General.Lists.CompaniesActivityTypeList(this.components);
            this.usersGroupList1 = new RASF.General.Lists.UsersGroupList(this.components);
            this.usersGroupList2 = new RASF.General.Lists.UsersGroupList(this.components);
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.dlgSelectPic = new System.Windows.Forms.OpenFileDialog();
            this.DefinitionOfContract = new Janus.Windows.UI.Tab.UITabPage();
            this.pnlDefinitionOfContract = new RASF.General.Controls.Panel();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.letter_Scan1 = new RASF.Main.Controls.Letter_Scan();
            this.yes_NoForDestructList1 = new RASF.General.Lists.Yes_NoForDestructList(this.components);
            this.new_ReceiptList1 = new RASF.General.Lists.New_ReceiptList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.realTimeSource2 = new DevExpress.Data.RealTimeSource();
            this.dlgSelectPic2 = new System.Windows.Forms.OpenFileDialog();
            this.receiptStudentList1 = new RASF.General.Lists.ReceiptStudentList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new RASF.General.Controls.Panel();
            this.panel8 = new RASF.General.Controls.Panel();
            this.panel9 = new RASF.General.Controls.Panel();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.chkPost = new RASF.General.Controls.CheckBox();
            this.chkFax = new RASF.General.Controls.CheckBox();
            this.chkEmail = new RASF.General.Controls.CheckBox();
            this.panel10 = new RASF.General.Controls.Panel();
            this.TabPgSample = new Janus.Windows.UI.Tab.UITabPage();
            this.grpParts = new RASF.General.Controls.GroupBox();
            this.grdPartsMaster = new RASF.General.Controls.Grid();
            this.TabPgGeneral = new Janus.Windows.UI.Tab.UITabPage();
            this.TabPgCompanies = new Janus.Windows.UI.Tab.UITabPage();
            this.panel1 = new RASF.General.Controls.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxReport = new RASF.General.Controls.GroupBox();
            this.grdCompaniesReport = new RASF.General.Controls.Grid();
            this.groupBoxInvoice = new RASF.General.Controls.GroupBox();
            this.grdCompanisInvoice = new RASF.General.Controls.Grid();
            this.AllTab = new RASF.General.Controls.TabControl();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).BeginInit();
            this.pnlPrice.SuspendLayout();
            this.DefinitionOfContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.TabPgSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).BeginInit();
            this.grpParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            this.TabPgGeneral.SuspendLayout();
            this.TabPgCompanies.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).BeginInit();
            this.groupBoxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaniesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            this.groupBoxInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).BeginInit();
            this.AllTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 589);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Size = new System.Drawing.Size(1276, 564);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Text = "به روز رسانی شرکت";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AllTab);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabLab);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1274, 542);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtReferred
            // 
            this.txtReferred.Location = new System.Drawing.Point(10, 9);
            this.txtReferred.Name = "txtReferred";
            this.txtReferred.Size = new System.Drawing.Size(149, 21);
            this.txtReferred.TabIndex = 3;
            this.txtReferred.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtReferred.TextChanged += new System.EventHandler(this.txtReferred_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "مراجعه کننده :";
            // 
            // txtLetterNo
            // 
            this.txtLetterNo.Enabled = false;
            this.txtLetterNo.Location = new System.Drawing.Point(8, 41);
            this.txtLetterNo.Name = "txtLetterNo";
            this.txtLetterNo.Size = new System.Drawing.Size(149, 21);
            this.txtLetterNo.TabIndex = 3;
            this.txtLetterNo.Text = "ندارد";
            this.txtLetterNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره نامه :";
            // 
            // DatePickerLetterDate
            // 
            this.DatePickerLetterDate.IsNull = false;
            this.DatePickerLetterDate.Location = new System.Drawing.Point(20, 74);
            this.DatePickerLetterDate.Name = "DatePickerLetterDate";
            this.DatePickerLetterDate.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.DatePickerLetterDate.Size = new System.Drawing.Size(146, 20);
            this.DatePickerLetterDate.TabIndex = 7;
            this.DatePickerLetterDate.SelectedDateTimeChanged += new System.EventHandler(this.DatePickerLetterDate_SelectedDateTimeChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاریخ نامه :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(-6, 100);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMobileNo.Size = new System.Drawing.Size(181, 21);
            this.txtMobileNo.TabIndex = 7;
            this.txtMobileNo.Text = "09";
            this.txtMobileNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "شماره موبایل:";
            // 
            // dropDownSampleSendingTypeCode
            // 
            this.dropDownSampleSendingTypeCode.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.dropDownSampleSendingTypeCode.Location = new System.Drawing.Point(1, 128);
            this.dropDownSampleSendingTypeCode.Name = "dropDownSampleSendingTypeCode";
            this.dropDownSampleSendingTypeCode.Size = new System.Drawing.Size(152, 21);
            this.dropDownSampleSendingTypeCode.TabIndex = 4;
            this.dropDownSampleSendingTypeCode.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // labSampleSendingTypeCode
            // 
            this.labSampleSendingTypeCode.AutoSize = true;
            this.labSampleSendingTypeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSampleSendingTypeCode.Location = new System.Drawing.Point(159, 130);
            this.labSampleSendingTypeCode.Name = "labSampleSendingTypeCode";
            this.labSampleSendingTypeCode.Size = new System.Drawing.Size(95, 17);
            this.labSampleSendingTypeCode.TabIndex = 2;
            this.labSampleSendingTypeCode.Text = "نحوه ارسال نمونه :";
            // 
            // dropDownUserID
            // 
            this.dropDownUserID.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.dropDownUserID.Location = new System.Drawing.Point(24, 9);
            this.dropDownUserID.Name = "dropDownUserID";
            this.dropDownUserID.Size = new System.Drawing.Size(147, 21);
            this.dropDownUserID.TabIndex = 3;
            this.dropDownUserID.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // labUserID
            // 
            this.labUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserID.Location = new System.Drawing.Point(168, 8);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(85, 26);
            this.labUserID.TabIndex = 2;
            this.labUserID.Text = "مسئول پذیرش :";
            // 
            // drpExecuters
            // 
            this.drpExecuters.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpExecuters.Location = new System.Drawing.Point(26, 44);
            this.drpExecuters.Name = "drpExecuters";
            this.drpExecuters.Size = new System.Drawing.Size(145, 21);
            this.drpExecuters.TabIndex = 5;
            this.drpExecuters.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "مسئول اجرایی : ";
            // 
            // drpOffices
            // 
            this.drpOffices.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpOffices.Location = new System.Drawing.Point(5, 79);
            this.drpOffices.Name = "drpOffices";
            this.drpOffices.Size = new System.Drawing.Size(152, 21);
            this.drpOffices.TabIndex = 6;
            this.drpOffices.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "محل ارسال نمونه :";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Location = new System.Drawing.Point(0, 89);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 150);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labDestination
            // 
            this.labDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDestination.Location = new System.Drawing.Point(167, 3);
            this.labDestination.Name = "labDestination";
            this.labDestination.Size = new System.Drawing.Size(61, 26);
            this.labDestination.TabIndex = 4;
            this.labDestination.Text = "توضیحات : ";
            // 
            // dropDownimmediate
            // 
            this.dropDownimmediate.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.dropDownimmediate.DisplayMember = "YesNo";
            this.dropDownimmediate.Location = new System.Drawing.Point(6, 13);
            this.dropDownimmediate.Name = "dropDownimmediate";
            this.dropDownimmediate.Size = new System.Drawing.Size(147, 21);
            this.dropDownimmediate.TabIndex = 5;
            this.dropDownimmediate.ValueMember = "Code";
            this.dropDownimmediate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // labimmediate
            // 
            this.labimmediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labimmediate.Location = new System.Drawing.Point(158, 16);
            this.labimmediate.Name = "labimmediate";
            this.labimmediate.Size = new System.Drawing.Size(99, 26);
            this.labimmediate.TabIndex = 4;
            this.labimmediate.Text = "فوری بودن آزمون:";
            // 
            // dropDownTestForThePresence
            // 
            this.dropDownTestForThePresence.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.dropDownTestForThePresence.Location = new System.Drawing.Point(6, 40);
            this.dropDownTestForThePresence.Name = "dropDownTestForThePresence";
            this.dropDownTestForThePresence.Size = new System.Drawing.Size(147, 21);
            this.dropDownTestForThePresence.TabIndex = 5;
            this.dropDownTestForThePresence.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.dropDownTestForThePresence.SelectedValueChanged += new System.EventHandler(this.dropDownTestForThePresence_SelectedValueChanged);
            // 
            // labTestForThePresence
            // 
            this.labTestForThePresence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestForThePresence.Location = new System.Drawing.Point(161, 44);
            this.labTestForThePresence.Name = "labTestForThePresence";
            this.labTestForThePresence.Size = new System.Drawing.Size(96, 26);
            this.labTestForThePresence.TabIndex = 4;
            this.labTestForThePresence.Text = "تست در حضور:";
            // 
            // chksabtsamane
            // 
            this.chksabtsamane.AutoSize = true;
            this.chksabtsamane.Location = new System.Drawing.Point(167, 71);
            this.chksabtsamane.Name = "chksabtsamane";
            this.chksabtsamane.Size = new System.Drawing.Size(90, 17);
            this.chksabtsamane.TabIndex = 3;
            this.chksabtsamane.Text = "ثبت در سامانه";
            this.chksabtsamane.UseVisualStyleBackColor = true;
            // 
            // chkStepByStep
            // 
            this.chkStepByStep.AutoSize = true;
            this.chkStepByStep.Location = new System.Drawing.Point(86, 117);
            this.chkStepByStep.Name = "chkStepByStep";
            this.chkStepByStep.Size = new System.Drawing.Size(171, 17);
            this.chkStepByStep.TabIndex = 2;
            this.chkStepByStep.Text = "آزمون مرحله به مرحله می باشد";
            this.chkStepByStep.UseVisualStyleBackColor = true;
            // 
            // chkGhateyat
            // 
            this.chkGhateyat.AutoSize = true;
            this.chkGhateyat.Location = new System.Drawing.Point(175, 94);
            this.chkGhateyat.Name = "chkGhateyat";
            this.chkGhateyat.Size = new System.Drawing.Size(82, 17);
            this.chkGhateyat.TabIndex = 1;
            this.chkGhateyat.Text = "عدم قطعیت";
            this.chkGhateyat.UseVisualStyleBackColor = true;
            // 
            // txtContractNo
            // 
            this.txtContractNo.Enabled = false;
            this.txtContractNo.Location = new System.Drawing.Point(18, 16);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(149, 21);
            this.txtContractNo.TabIndex = 1;
            this.txtContractNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // LabContractNum
            // 
            this.LabContractNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabContractNum.Location = new System.Drawing.Point(169, 18);
            this.LabContractNum.Name = "LabContractNum";
            this.LabContractNum.Size = new System.Drawing.Size(78, 26);
            this.LabContractNum.TabIndex = 0;
            this.LabContractNum.Text = "شماره قرارداد:";
            // 
            // DatePickerReceptionDate
            // 
            this.DatePickerReceptionDate.IsNull = false;
            this.DatePickerReceptionDate.Location = new System.Drawing.Point(21, 44);
            this.DatePickerReceptionDate.Name = "DatePickerReceptionDate";
            this.DatePickerReceptionDate.SelectedDateTime = new System.DateTime(2014, 3, 15, 0, 0, 0, 0);
            this.DatePickerReceptionDate.Size = new System.Drawing.Size(145, 20);
            this.DatePickerReceptionDate.TabIndex = 9;
            // 
            // labReceptionDate
            // 
            this.labReceptionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReceptionDate.Location = new System.Drawing.Point(172, 44);
            this.labReceptionDate.Name = "labReceptionDate";
            this.labReceptionDate.Size = new System.Drawing.Size(78, 26);
            this.labReceptionDate.TabIndex = 2;
            this.labReceptionDate.Text = "تاریخ دریافت :";
            // 
            // chkInsPic
            // 
            this.chkInsPic.AutoSize = true;
            this.chkInsPic.Location = new System.Drawing.Point(151, 142);
            this.chkInsPic.Name = "chkInsPic";
            this.chkInsPic.Size = new System.Drawing.Size(105, 17);
            this.chkInsPic.TabIndex = 10;
            this.chkInsPic.Text = "درج عکس پذیرش";
            this.chkInsPic.UseVisualStyleBackColor = true;
            // 
            // chkPersian
            // 
            this.chkPersian.AutoSize = true;
            this.chkPersian.Location = new System.Drawing.Point(163, 119);
            this.chkPersian.Name = "chkPersian";
            this.chkPersian.Size = new System.Drawing.Size(93, 17);
            this.chkPersian.TabIndex = 9;
            this.chkPersian.Text = "گزارش فارسی";
            this.chkPersian.UseVisualStyleBackColor = true;
            // 
            // DatePickertxtDelivery
            // 
            this.DatePickertxtDelivery.IsNull = false;
            this.DatePickertxtDelivery.Location = new System.Drawing.Point(19, 70);
            this.DatePickertxtDelivery.Name = "DatePickertxtDelivery";
            this.DatePickertxtDelivery.SelectedDateTime = new System.DateTime(2017, 3, 5, 9, 24, 54, 0);
            this.DatePickertxtDelivery.Size = new System.Drawing.Size(145, 20);
            this.DatePickertxtDelivery.TabIndex = 8;
            this.DatePickertxtDelivery.Leave += new System.EventHandler(this.DatePickertxtDelivery_Leave);
            // 
            // labDelivery
            // 
            this.labDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDelivery.Location = new System.Drawing.Point(167, 70);
            this.labDelivery.Name = "labDelivery";
            this.labDelivery.Size = new System.Drawing.Size(78, 26);
            this.labDelivery.TabIndex = 4;
            this.labDelivery.Text = "تاریخ تحویل :";
            // 
            // chkEnglish
            // 
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(151, 96);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(105, 17);
            this.chkEnglish.TabIndex = 0;
            this.chkEnglish.Text = "گزارش انگلیسی ";
            this.chkEnglish.UseVisualStyleBackColor = true;
            this.chkEnglish.CheckedChanged += new System.EventHandler(this.chkEnglish_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy,
            this.mnuPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 48);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(102, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Enabled = false;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(102, 22);
            this.mnuPaste.Text = "Pase";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // tabLab
            // 
            this.tabLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLab.Enabled = false;
            this.tabLab.Location = new System.Drawing.Point(0, 0);
            this.tabLab.Name = "tabLab";
            this.tabLab.Size = new System.Drawing.Size(1274, 277);
            this.tabLab.TabIndex = 0;
            this.tabLab.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.lblPrice);
            this.pnlPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrice.Location = new System.Drawing.Point(0, 0);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(1276, 25);
            this.pnlPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(1126, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "قیمت کل 0 ریال";
            // 
            // report
            // 
            this.report.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.report.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.report.ReportAlias = "Report";
            this.report.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.report.ReportName = "Report";
            this.report.ReportSource = null;
            this.report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.report.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.report.UseProgressInThread = false;
            // 
            // dlgSelectPic
            // 
            this.dlgSelectPic.DefaultExt = "*.jpg";
            this.dlgSelectPic.Filter = "\"ImageFiles (.jpg)|*.jpg";
            this.dlgSelectPic.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // DefinitionOfContract
            // 
            this.DefinitionOfContract.Controls.Add(this.pnlDefinitionOfContract);
            this.DefinitionOfContract.Location = new System.Drawing.Point(1, 21);
            this.DefinitionOfContract.Name = "DefinitionOfContract";
            this.DefinitionOfContract.Size = new System.Drawing.Size(1148, 222);
            this.DefinitionOfContract.TabStop = true;
            this.DefinitionOfContract.Text = "توضیحات قرارداد";
            // 
            // pnlDefinitionOfContract
            // 
            this.pnlDefinitionOfContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDefinitionOfContract.Location = new System.Drawing.Point(0, 0);
            this.pnlDefinitionOfContract.Name = "pnlDefinitionOfContract";
            this.pnlDefinitionOfContract.Size = new System.Drawing.Size(1148, 222);
            this.pnlDefinitionOfContract.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1276, 564);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.tabControl1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.splitContainer1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1274, 542);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "اطلاعات پذیرش";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.letter_Scan1);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1274, 542);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "مکاتبات";
            // 
            // letter_Scan1
            // 
            this.letter_Scan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan1.Document = null;
            this.letter_Scan1.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan1.Name = "letter_Scan1";
            this.letter_Scan1.Size = new System.Drawing.Size(1274, 542);
            this.letter_Scan1.TabIndex = 1;
            // 
            // Report2
            // 
            this.Report2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Report2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Report2.ReportAlias = "Report";
            this.Report2.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.Report2.ReportName = "Report";
            this.Report2.ReportSource = null;
            this.Report2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Report2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Report2.UseProgressInThread = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            this.realTimeSource1.UseWeakEventHandler = true;
            // 
            // realTimeSource2
            // 
            this.realTimeSource2.DisplayableProperties = null;
            this.realTimeSource2.UseWeakEventHandler = true;
            // 
            // dlgSelectPic2
            // 
            this.dlgSelectPic2.DefaultExt = "*.jpg";
            this.dlgSelectPic2.Filter = "\"ImageFiles (.jpg)|*.jpg";
            this.dlgSelectPic2.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1272, 239);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chkInsPic);
            this.panel6.Controls.Add(this.DatePickerReceptionDate);
            this.panel6.Controls.Add(this.chkPersian);
            this.panel6.Controls.Add(this.txtContractNo);
            this.panel6.Controls.Add(this.chkEnglish);
            this.panel6.Controls.Add(this.DatePickertxtDelivery);
            this.panel6.Controls.Add(this.labReceptionDate);
            this.panel6.Controls.Add(this.labDelivery);
            this.panel6.Controls.Add(this.LabContractNum);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1012, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 239);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chkStepByStep);
            this.panel7.Controls.Add(this.chksabtsamane);
            this.panel7.Controls.Add(this.chkGhateyat);
            this.panel7.Controls.Add(this.dropDownTestForThePresence);
            this.panel7.Controls.Add(this.dropDownimmediate);
            this.panel7.Controls.Add(this.labTestForThePresence);
            this.panel7.Controls.Add(this.labimmediate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(752, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 239);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.drpOffices);
            this.panel8.Controls.Add(this.drpExecuters);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.dropDownUserID);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.labUserID);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(492, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(260, 239);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dropDownSampleSendingTypeCode);
            this.panel9.Controls.Add(this.txtMobileNo);
            this.panel9.Controls.Add(this.labSampleSendingTypeCode);
            this.panel9.Controls.Add(this.DatePickerLetterDate);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.txtLetterNo);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtReferred);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(232, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(260, 239);
            this.panel9.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPost);
            this.groupBox1.Controls.Add(this.chkFax);
            this.groupBox1.Controls.Add(this.chkEmail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.Text = "نحوه ارسال گزارش";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chkPost
            // 
            this.chkPost.Location = new System.Drawing.Point(24, 19);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(45, 23);
            this.chkPost.TabIndex = 2;
            this.chkPost.Text = "پست";
            this.chkPost.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chkFax
            // 
            this.chkFax.Location = new System.Drawing.Point(123, 16);
            this.chkFax.Name = "chkFax";
            this.chkFax.Size = new System.Drawing.Size(45, 23);
            this.chkFax.TabIndex = 1;
            this.chkFax.Text = "فکس";
            this.chkFax.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chkEmail
            // 
            this.chkEmail.Location = new System.Drawing.Point(197, 17);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(45, 23);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "ایمیل";
            this.chkEmail.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtDescription);
            this.panel10.Controls.Add(this.labDestination);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(232, 239);
            this.panel10.TabIndex = 9;
            // 
            // TabPgSample
            // 
            this.TabPgSample.Controls.Add(this.grpParts);
            this.TabPgSample.Location = new System.Drawing.Point(1, 21);
            this.TabPgSample.Name = "TabPgSample";
            this.TabPgSample.Size = new System.Drawing.Size(1272, 239);
            this.TabPgSample.TabStop = true;
            this.TabPgSample.Text = "اطلاعات نمونه";
            // 
            // grpParts
            // 
            this.grpParts.Controls.Add(this.grdPartsMaster);
            this.grpParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpParts.Location = new System.Drawing.Point(0, 0);
            this.grpParts.Name = "grpParts";
            this.grpParts.Size = new System.Drawing.Size(1272, 239);
            this.grpParts.TabIndex = 1;
            this.grpParts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPartsMaster
            // 
            this.grdPartsMaster.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPartsMaster.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPartsMaster.AlowRetrieveStructure = false;
            this.grdPartsMaster.AlternatingColors = true;
            this.grdPartsMaster.BuiltInTextsData = resources.GetString("grdPartsMaster.BuiltInTextsData");
            this.grdPartsMaster.ContextMenuStrip = this.contextMenuStrip1;
            this.grdPartsMaster.DataSource = this.partsMasterList1;
            this.grdPartsMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            this.grdPartsMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPartsMaster.GroupByBoxVisible = false;
            this.grdPartsMaster.Location = new System.Drawing.Point(3, 8);
            this.grdPartsMaster.Name = "grdPartsMaster";
            this.grdPartsMaster.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndStayInCurrentCell;
            this.grdPartsMaster.Size = new System.Drawing.Size(1266, 228);
            this.grdPartsMaster.TabIndex = 0;
            this.grdPartsMaster.TabStop = false;
            this.grdPartsMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPartsMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdPartsMaster.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdPartsMaster_FormattingRow);
            this.grdPartsMaster.RecordAdded += new System.EventHandler(this.grdPartsMaster_RecordAdded);
            this.grdPartsMaster.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdPartsMaster_ColumnButtonClick);
            this.grdPartsMaster.SelectionChanged += new System.EventHandler(this.grdPartsMaster_SelectionChanged);
            // 
            // TabPgGeneral
            // 
            this.TabPgGeneral.Controls.Add(this.panel5);
            this.TabPgGeneral.Location = new System.Drawing.Point(1, 21);
            this.TabPgGeneral.Name = "TabPgGeneral";
            this.TabPgGeneral.Size = new System.Drawing.Size(1272, 239);
            this.TabPgGeneral.TabStop = true;
            this.TabPgGeneral.Text = "اطلاعات عمومی";
            // 
            // TabPgCompanies
            // 
            this.TabPgCompanies.Controls.Add(this.panel1);
            this.TabPgCompanies.Location = new System.Drawing.Point(1, 21);
            this.TabPgCompanies.Name = "TabPgCompanies";
            this.TabPgCompanies.Size = new System.Drawing.Size(1272, 239);
            this.TabPgCompanies.TabStop = true;
            this.TabPgCompanies.Text = "اطلاعات شرکت";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1272, 239);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxInvoice);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBoxReport);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1272, 239);
            this.splitContainer2.SplitterDistance = 582;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.grdCompaniesReport);
            this.groupBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReport.Location = new System.Drawing.Point(0, 0);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(686, 239);
            this.groupBoxReport.TabIndex = 2;
            this.groupBoxReport.Text = "نام شرکت جهت صدور گزارش";
            this.groupBoxReport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompaniesReport
            // 
            this.grdCompaniesReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompaniesReport.AlowRetrieveStructure = false;
            this.grdCompaniesReport.AlternatingColors = true;
            this.grdCompaniesReport.BuiltInTextsData = resources.GetString("grdCompaniesReport.BuiltInTextsData");
            this.grdCompaniesReport.DataSource = this.companiesBaseList2;
            this.grdCompaniesReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompaniesReport_DesignTimeLayout.LayoutString = resources.GetString("grdCompaniesReport_DesignTimeLayout.LayoutString");
            this.grdCompaniesReport.DesignTimeLayout = grdCompaniesReport_DesignTimeLayout;
            this.grdCompaniesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompaniesReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompaniesReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompaniesReport.GroupByBoxVisible = false;
            this.grdCompaniesReport.Location = new System.Drawing.Point(3, 17);
            this.grdCompaniesReport.Name = "grdCompaniesReport";
            this.grdCompaniesReport.Size = new System.Drawing.Size(680, 219);
            this.grdCompaniesReport.TabIndex = 1;
            this.grdCompaniesReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompaniesReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompaniesReport.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCompaniesReport_FormattingRow);
            this.grdCompaniesReport.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCompaniesReport_ColumnButtonClick);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.grdCompanisInvoice);
            this.groupBoxInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInvoice.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(582, 239);
            this.groupBoxInvoice.TabIndex = 1;
            this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب";
            this.groupBoxInvoice.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanisInvoice
            // 
            this.grdCompanisInvoice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompanisInvoice.AlowRetrieveStructure = false;
            this.grdCompanisInvoice.AlternatingColors = true;
            this.grdCompanisInvoice.BuiltInTextsData = resources.GetString("grdCompanisInvoice.BuiltInTextsData");
            this.grdCompanisInvoice.DataSource = this.companiesBaseList1;
            this.grdCompanisInvoice.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanisInvoice_DesignTimeLayout.LayoutString = resources.GetString("grdCompanisInvoice_DesignTimeLayout.LayoutString");
            this.grdCompanisInvoice.DesignTimeLayout = grdCompanisInvoice_DesignTimeLayout;
            this.grdCompanisInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanisInvoice.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanisInvoice.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanisInvoice.GroupByBoxVisible = false;
            this.grdCompanisInvoice.Location = new System.Drawing.Point(3, 17);
            this.grdCompanisInvoice.Name = "grdCompanisInvoice";
            this.grdCompanisInvoice.Size = new System.Drawing.Size(576, 219);
            this.grdCompanisInvoice.TabIndex = 0;
            this.grdCompanisInvoice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanisInvoice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanisInvoice.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCompanisInvoice_FormattingRow);
            this.grdCompanisInvoice.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCompanisInvoice_ColumnButtonClick);
            // 
            // AllTab
            // 
            this.AllTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTab.Location = new System.Drawing.Point(0, 0);
            this.AllTab.Name = "AllTab";
            this.AllTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllTab.Size = new System.Drawing.Size(1274, 261);
            this.AllTab.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text;
            this.AllTab.TabIndex = 0;
            this.AllTab.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.TabPgCompanies,
            this.TabPgGeneral,
            this.TabPgSample});
            this.AllTab.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            this.AllTab.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.AllTab_SelectedTabChanged);
            // 
            // New_Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 619);
            this.Controls.Add(this.pnlPrice);
            this.Name = "New_Reception";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Reception_FormClosing);
            this.Load += new System.EventHandler(this.Reception_Load);
            this.Controls.SetChildIndex(this.pnlPrice, 0);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).EndInit();
            this.pnlPrice.ResumeLayout(false);
            this.DefinitionOfContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.TabPgSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).EndInit();
            this.grpParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            this.TabPgGeneral.ResumeLayout(false);
            this.TabPgCompanies.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).EndInit();
            this.groupBoxReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaniesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            this.groupBoxInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).EndInit();
            this.AllTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Lists.MainTestList mainTestList1;
        private General.Lists.MasterTestList masterTestList1;
        private General.Lists.LaboratoryList labList1;
        private General.Lists.CompaniesBaseList companiesBaseList1;
        private General.Lists.CompaniesBaseList companiesBaseList2;
        private General.Lists.Yes_NoList yes_NoList1;
        private General.Controls.Panel pnlPrice;
        private General.Controls.Label lblPrice;
        private General.Lists.UserList userList1;
        private General.Lists.SampleSendingTypeList sampleSendingTypeList1;
        private General.Lists.ReportSendingTypeList reportSendingTypeList1;
        private General.Lists.EditRecieptionList editRecieptionList1;
        protected General.Lists.ContractsBaseList contractsBaseList1;
        protected General.Lists.PartsMasterList partsMasterList1;
        protected General.Lists.MasterTestStatusList_Main masterteststatusList_Main1;
        protected General.Lists.PartsTestMasterList partsTestMasterList1;
        protected General.Lists.PartsTestDetailList partsTestDetailList1;
        private General.Lists.CompaniesActivityTypeList companiesActivityTypeList1;
        public General.Controls.TabControl tabLab;
        private General.Lists.UsersGroupList usersGroupList1;
        private General.Lists.UsersGroupList usersGroupList2;
        private General.Lists.CompaniesAgencyListList companiesAgencyListList1;
        private System.Windows.Forms.OpenFileDialog dlgSelectPic;
        private Janus.Windows.UI.Tab.UITabPage DefinitionOfContract;
        private General.Controls.Panel pnlDefinitionOfContract;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Stimulsoft.Report.StiReport report;
        private General.Lists.Yes_NoForDestructList yes_NoForDestructList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private General.Lists.New_ReceiptList new_ReceiptList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        protected General.Controls.TextBox txtReferred;
        protected General.Controls.Label label1;
        protected General.Controls.TextBox txtLetterNo;
        protected General.Controls.Label label2;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerLetterDate;
        protected General.Controls.Label label3;
        protected General.Controls.TextBox txtMobileNo;
        protected General.Controls.Label label6;
        protected General.Controls.DropDown dropDownSampleSendingTypeCode;
        private General.Controls.Label labSampleSendingTypeCode;
        protected General.Controls.DropDown dropDownUserID;
        private General.Controls.Label labUserID;
        protected General.Controls.DropDown drpExecuters;
        private General.Controls.Label label4;
        protected General.Controls.DropDown drpOffices;
        private General.Controls.Label label5;
        protected General.Controls.TextBox txtDescription;
        protected General.Controls.Label labDestination;
        protected General.Controls.DropDown dropDownimmediate;
        private General.Controls.Label labimmediate;
        protected General.Controls.DropDown dropDownTestForThePresence;
        private General.Controls.Label labTestForThePresence;
        protected System.Windows.Forms.CheckBox chkStepByStep;
        protected System.Windows.Forms.CheckBox chkGhateyat;
        protected General.Controls.TextBox txtContractNo;
        private General.Controls.Label LabContractNum;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerReceptionDate;
        private General.Controls.Label labReceptionDate;
        protected System.Windows.Forms.CheckBox chkInsPic;
        protected System.Windows.Forms.CheckBox chkPersian;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickertxtDelivery;
        private General.Controls.Label labDelivery;
        protected System.Windows.Forms.CheckBox chkEnglish;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private DevExpress.Data.RealTimeSource realTimeSource2;
        private Controls.Letter_Scan letter_Scan1;
        protected System.Windows.Forms.CheckBox chksabtsamane;
        private System.Windows.Forms.OpenFileDialog dlgSelectPic2;
        private Stimulsoft.Report.StiReport Report2;
        private General.Lists.ReceiptStudentList receiptStudentList1;
        protected General.Controls.TabControl AllTab;
        private Janus.Windows.UI.Tab.UITabPage TabPgCompanies;
        private General.Controls.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        protected General.Controls.GroupBox groupBoxInvoice;
        private General.Controls.Grid grdCompanisInvoice;
        protected General.Controls.GroupBox groupBoxReport;
        private General.Controls.Grid grdCompaniesReport;
        private Janus.Windows.UI.Tab.UITabPage TabPgGeneral;
        private System.Windows.Forms.Panel panel5;
        private General.Controls.Panel panel10;
        private General.Controls.Panel panel9;
        private General.Controls.Panel panel8;
        private General.Controls.GroupBox groupBox1;
        protected General.Controls.CheckBox chkPost;
        protected General.Controls.CheckBox chkFax;
        protected General.Controls.CheckBox chkEmail;
        private General.Controls.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Janus.Windows.UI.Tab.UITabPage TabPgSample;
        private General.Controls.GroupBox grpParts;
        protected General.Controls.Grid grdPartsMaster;
       // private Lable.Letter_Scan letter_Scan1;
    }
}
