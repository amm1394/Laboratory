namespace RASF.Main.Forms.Reception
{
    partial class New_Reciption_EditForAgency
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
            Janus.Windows.GridEX.GridEXLayout grdPartsMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Reciption_EditForAgency));
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SampleSendingType sampleSendingType1 = new RASF.General.Data.SampleSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SampleSendingType sampleSendingType2 = new RASF.General.Data.SampleSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.USER user1 = new RASF.General.Data.USER();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.USER user2 = new RASF.General.Data.USER();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType1 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType2 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem7 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType3 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem8 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType4 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem9 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType5 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem10 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.ReportSendingType reportSendingType6 = new RASF.General.Data.ReportSendingType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem11 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.Yes_No yes_No1 = new RASF.General.Data.Yes_No();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem12 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.Yes_No yes_No2 = new RASF.General.Data.Yes_No();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem13 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem14 = new Janus.Windows.EditControls.UIComboBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLab
            // 
            this.tabLab.Size = new System.Drawing.Size(1216, 265);
            // 
            // AllTab
            // 
            this.AllTab.Size = new System.Drawing.Size(1216, 248);
            this.AllTab.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.AllTab_SelectedTabChanged);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Size = new System.Drawing.Size(555, 226);
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Size = new System.Drawing.Size(655, 226);
            // 
            // grdPartsMaster
            // 
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            // 
            // DatePickerLetterDate
            // 
            this.DatePickerLetterDate.SelectedDateTime = new System.DateTime(2014, 4, 21, 12, 5, 28, 709);
            // 
            // dropDownSampleSendingTypeCode
            // 
            this.dropDownSampleSendingTypeCode.DisplayMember = "Name";
            sampleSendingType1.Code = new System.Guid("34d852fd-e1c6-4d19-99e1-c486de27e462");
            sampleSendingType1.Name = "حضوری";
            sampleSendingType1.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem1.DataRow = sampleSendingType1;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "حضوری";
            uiComboBoxItem1.Value = new System.Guid("34d852fd-e1c6-4d19-99e1-c486de27e462");
            sampleSendingType2.Code = new System.Guid("80c580c2-8075-47c7-ab55-d9b39f9635b7");
            sampleSendingType2.Name = "پست";
            sampleSendingType2.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem2.DataRow = sampleSendingType2;
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "پست";
            uiComboBoxItem2.Value = new System.Guid("80c580c2-8075-47c7-ab55-d9b39f9635b7");
            this.dropDownSampleSendingTypeCode.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
            this.dropDownSampleSendingTypeCode.SelectedIndex = 0;
            this.dropDownSampleSendingTypeCode.Text = "حضوری";
            this.dropDownSampleSendingTypeCode.ValueMember = "Code";
            // 
            // dropDownUserID
            // 
            this.dropDownUserID.DisplayMember = "UserName";
            user1.RowState = RASF.General.Enums.RowState.Original;
            user1.UserId = new System.Guid("db95a451-1371-4218-8201-ad1a42609067");
            user1.UserName = "AliReza Mazaheri";
            uiComboBoxItem3.DataRow = user1;
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "AliReza Mazaheri";
            uiComboBoxItem3.Value = new System.Guid("db95a451-1371-4218-8201-ad1a42609067");
            user2.RowState = RASF.General.Enums.RowState.Original;
            user2.UserId = new System.Guid("8485a03d-1d3e-43f7-9326-a57f7556086d");
            user2.UserName = "Kolsum Nabavi";
            uiComboBoxItem4.DataRow = user2;
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "Kolsum Nabavi";
            uiComboBoxItem4.Value = new System.Guid("8485a03d-1d3e-43f7-9326-a57f7556086d");
            this.dropDownUserID.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem3,
            uiComboBoxItem4});
            this.dropDownUserID.SelectedIndex = 0;
            this.dropDownUserID.Text = "AliReza Mazaheri";
            this.dropDownUserID.ValueMember = "UserId";
            // 
            // dropDownReportSendingTypeCode
            // 
            reportSendingType1.Code = new System.Guid("f8f75dd7-f06d-4f12-8aa9-0091c60a031e");
            reportSendingType1.Name = "فکس";
            reportSendingType1.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem5.DataRow = reportSendingType1;
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "فکس";
            uiComboBoxItem5.Value = new System.Guid("f8f75dd7-f06d-4f12-8aa9-0091c60a031e");
            reportSendingType2.Code = new System.Guid("61a47cc2-07d7-4583-bde4-20a8da94c531");
            reportSendingType2.Name = "دفتر نمایندگی";
            reportSendingType2.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem6.DataRow = reportSendingType2;
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "دفتر نمایندگی";
            uiComboBoxItem6.Value = new System.Guid("61a47cc2-07d7-4583-bde4-20a8da94c531");
            reportSendingType3.Code = new System.Guid("ce9edacc-4f12-46a6-ad5a-31dc2056cd6e");
            reportSendingType3.Name = "ایمیل";
            reportSendingType3.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem7.DataRow = reportSendingType3;
            uiComboBoxItem7.FormatStyle.Alpha = 0;
            uiComboBoxItem7.IsSeparator = false;
            uiComboBoxItem7.Text = "ایمیل";
            uiComboBoxItem7.Value = new System.Guid("ce9edacc-4f12-46a6-ad5a-31dc2056cd6e");
            reportSendingType4.Code = new System.Guid("51904596-a148-45e3-a347-7561a0a99156");
            reportSendingType4.Name = "ارسال با پیک";
            reportSendingType4.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem8.DataRow = reportSendingType4;
            uiComboBoxItem8.FormatStyle.Alpha = 0;
            uiComboBoxItem8.IsSeparator = false;
            uiComboBoxItem8.Text = "ارسال با پیک";
            uiComboBoxItem8.Value = new System.Guid("51904596-a148-45e3-a347-7561a0a99156");
            reportSendingType5.Code = new System.Guid("a5c45ddd-ac0e-4f5e-b986-c7d8854512b8");
            reportSendingType5.Name = "حضوری";
            reportSendingType5.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem9.DataRow = reportSendingType5;
            uiComboBoxItem9.FormatStyle.Alpha = 0;
            uiComboBoxItem9.IsSeparator = false;
            uiComboBoxItem9.Text = "حضوری";
            uiComboBoxItem9.Value = new System.Guid("a5c45ddd-ac0e-4f5e-b986-c7d8854512b8");
            reportSendingType6.Code = new System.Guid("c8836f6c-9b3d-4caf-9e65-d943f08ae838");
            reportSendingType6.Name = "پست";
            reportSendingType6.RowState = RASF.General.Enums.RowState.Original;
            uiComboBoxItem10.DataRow = reportSendingType6;
            uiComboBoxItem10.FormatStyle.Alpha = 0;
            uiComboBoxItem10.IsSeparator = false;
            uiComboBoxItem10.Text = "پست";
            uiComboBoxItem10.Value = new System.Guid("c8836f6c-9b3d-4caf-9e65-d943f08ae838");
            this.dropDownReportSendingTypeCode.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem5,
            uiComboBoxItem6,
            uiComboBoxItem7,
            uiComboBoxItem8,
            uiComboBoxItem9,
            uiComboBoxItem10});
            this.dropDownReportSendingTypeCode.SelectedIndex = 0;
            this.dropDownReportSendingTypeCode.Text = "فکس";
            // 
            // dropDownimmediate
            // 
            yes_No1.Code = ((byte)(0));
            yes_No1.RowState = RASF.General.Enums.RowState.Original;
            yes_No1.YesNo = "خیر";
            uiComboBoxItem11.DataRow = yes_No1;
            uiComboBoxItem11.FormatStyle.Alpha = 0;
            uiComboBoxItem11.IsSeparator = false;
            uiComboBoxItem11.Text = "خیر";
            uiComboBoxItem11.Value = ((byte)(0));
            yes_No2.Code = ((byte)(1));
            yes_No2.RowState = RASF.General.Enums.RowState.Original;
            yes_No2.YesNo = "بله";
            uiComboBoxItem12.DataRow = yes_No2;
            uiComboBoxItem12.FormatStyle.Alpha = 0;
            uiComboBoxItem12.IsSeparator = false;
            uiComboBoxItem12.Text = "بله";
            uiComboBoxItem12.Value = ((byte)(1));
            this.dropDownimmediate.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem11,
            uiComboBoxItem12});
            this.dropDownimmediate.SelectedIndex = 0;
            this.dropDownimmediate.Text = "خیر";
            // 
            // dropDownTestForThePresence
            // 
            this.dropDownTestForThePresence.DisplayMember = "YesNo";
            uiComboBoxItem13.DataRow = yes_No1;
            uiComboBoxItem13.FormatStyle.Alpha = 0;
            uiComboBoxItem13.IsSeparator = false;
            uiComboBoxItem13.Text = "خیر";
            uiComboBoxItem13.Value = ((byte)(0));
            uiComboBoxItem14.DataRow = yes_No2;
            uiComboBoxItem14.FormatStyle.Alpha = 0;
            uiComboBoxItem14.IsSeparator = false;
            uiComboBoxItem14.Text = "بله";
            uiComboBoxItem14.Value = ((byte)(1));
            this.dropDownTestForThePresence.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem13,
            uiComboBoxItem14});
            this.dropDownTestForThePresence.SelectedIndex = 0;
            this.dropDownTestForThePresence.Text = "خیر";
            this.dropDownTestForThePresence.ValueMember = "Code";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Text = "جدید";
            // 
            // DatePickerReceptionDate
            // 
            this.DatePickerReceptionDate.SelectedDateTime = new System.DateTime(2014, 4, 21, 12, 5, 28, 708);
            // 
            // DatePickertxtDelivery
            // 
            this.DatePickertxtDelivery.Enabled = false;
            this.DatePickertxtDelivery.SelectedDateTime = new System.DateTime(2014, 4, 22, 12, 5, 28, 709);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 564);
            this.pnlButton.Size = new System.Drawing.Size(1218, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(1218, 539);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1013, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1096, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1158, 0);
            // 
            // New_Reciption_EditForAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 594);
            this.Name = "New_Reciption_EditForAgency";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "New_Reciption_Edit";
            this.Load += new System.EventHandler(this.New_Reciption_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}