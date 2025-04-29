namespace RASF.Main.Forms.Secretariat
{
    partial class EditSendLetters
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType1 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType2 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType3 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType4 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType5 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType6 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem7 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType7 = new RASF.General.Data.SendType();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem8 = new Janus.Windows.EditControls.UIComboBoxItem();
            RASF.General.Data.SendType sendType8 = new RASF.General.Data.SendType();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // drpSendType
            // 
            //this.drpSendType.DataSource = this.sendTypeList1;
            //this.drpSendType.DisplayMember = "SendTypeName";
            sendType1.ActingGroupCode = 0;
            sendType1.ActingGroupName = null;
            sendType1.GroupingCode = 0;
            sendType1.GroupingNme = null;
            sendType1.RowState = RASF.General.Enums.RowState.Original;
            sendType1.SendTypeCode = 1;
            sendType1.SendTypeName = "ایمیل";
            uiComboBoxItem1.DataRow = sendType1;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "ایمیل";
            uiComboBoxItem1.Value = 1;
            sendType2.ActingGroupCode = 0;
            sendType2.ActingGroupName = null;
            sendType2.GroupingCode = 0;
            sendType2.GroupingNme = null;
            sendType2.RowState = RASF.General.Enums.RowState.Original;
            sendType2.SendTypeCode = 2;
            sendType2.SendTypeName = "فکس";
            uiComboBoxItem2.DataRow = sendType2;
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "فکس";
            uiComboBoxItem2.Value = 2;
            sendType3.ActingGroupCode = 0;
            sendType3.ActingGroupName = null;
            sendType3.GroupingCode = 0;
            sendType3.GroupingNme = null;
            sendType3.RowState = RASF.General.Enums.RowState.Original;
            sendType3.SendTypeCode = 3;
            sendType3.SendTypeName = "حضوری";
            uiComboBoxItem3.DataRow = sendType3;
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "حضوری";
            uiComboBoxItem3.Value = 3;
            sendType4.ActingGroupCode = 0;
            sendType4.ActingGroupName = null;
            sendType4.GroupingCode = 0;
            sendType4.GroupingNme = null;
            sendType4.RowState = RASF.General.Enums.RowState.Original;
            sendType4.SendTypeCode = 4;
            sendType4.SendTypeName = "پست/پیک";
            uiComboBoxItem4.DataRow = sendType4;
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "پست/پیک";
            uiComboBoxItem4.Value = 4;
         //   this.drpSendType.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            //uiComboBoxItem1,
            //uiComboBoxItem2,
            //uiComboBoxItem3,
            //uiComboBoxItem4});
       //     this.drpSendType.ValueMember = "SendTypeCode";
            // 
            // drpGroup
            // 
            //this.drpGroup.DataSource = this.partGroupingList1;
            //this.drpGroup.DisplayMember = "GroupingNme";
            sendType5.ActingGroupCode = 0;
            sendType5.ActingGroupName = null;
            sendType5.GroupingCode = 1;
            sendType5.GroupingNme = "اداری";
            sendType5.RowState = RASF.General.Enums.RowState.Original;
            sendType5.SendTypeCode = 0;
            sendType5.SendTypeName = null;
            uiComboBoxItem5.DataRow = sendType5;
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "اداری";
            uiComboBoxItem5.Value = 1;
            sendType6.ActingGroupCode = 0;
            sendType6.ActingGroupName = null;
            sendType6.GroupingCode = 2;
            sendType6.GroupingNme = "آزمایشگاهی";
            sendType6.RowState = RASF.General.Enums.RowState.Original;
            sendType6.SendTypeCode = 0;
            sendType6.SendTypeName = null;
            uiComboBoxItem6.DataRow = sendType6;
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "آزمایشگاهی";
            uiComboBoxItem6.Value = 2;
            sendType7.ActingGroupCode = 0;
            sendType7.ActingGroupName = null;
            sendType7.GroupingCode = 3;
            sendType7.GroupingNme = "مالی";
            sendType7.RowState = RASF.General.Enums.RowState.Original;
            sendType7.SendTypeCode = 0;
            sendType7.SendTypeName = null;
            uiComboBoxItem7.DataRow = sendType7;
            uiComboBoxItem7.FormatStyle.Alpha = 0;
            uiComboBoxItem7.IsSeparator = false;
            uiComboBoxItem7.Text = "مالی";
            uiComboBoxItem7.Value = 3;
            sendType8.ActingGroupCode = 0;
            sendType8.ActingGroupName = null;
            sendType8.GroupingCode = 4;
            sendType8.GroupingNme = "تفاهم نامه";
            sendType8.RowState = RASF.General.Enums.RowState.Original;
            sendType8.SendTypeCode = 0;
            sendType8.SendTypeName = null;
            uiComboBoxItem8.DataRow = sendType8;
            uiComboBoxItem8.FormatStyle.Alpha = 0;
            uiComboBoxItem8.IsSeparator = false;
            uiComboBoxItem8.Text = "تفاهم نامه";
            uiComboBoxItem8.Value = 4;
//this.drpGroup.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            //uiComboBoxItem5,
            //uiComboBoxItem6,
            //uiComboBoxItem7,
            //uiComboBoxItem8});
         //   this.drpGroup.ValueMember = "GroupingCode";
            // 
            // EditSendLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 815);
            this.Name = "EditSendLetters";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "EditSendLetters";
            this.Load += new System.EventHandler(this.EditSendLetters_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}