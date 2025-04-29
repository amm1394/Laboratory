namespace RASF.Main.Forms.Personel
{
    using Janus.Windows.GridEX;
    using Janus.Windows.UI;
    using Janus.Windows.UI.Dock;
    using Janus.Windows.UI.Tab;
    using RASF.General.Controls;
    using RASF.General.Events;
    using RASF.General.Forms.Base;
    using RASF.General.Lists;
    using RASF.Main.Controls.Laboratory;
    using RASF.Main.Controls.PickDate;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    partial class Personnelfunction
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (this.components != null))
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personnelfunction));
            Janus.Windows.GridEX.GridEXLayout grdPersonel_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDetailOutput_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdPersonel = new RASF.General.Controls.Grid();
            this.outPutExecutersDetailList1 = new RASF.General.Lists.OutPutExecutersDetailList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grpOfficesName = new RASF.General.Controls.GroupBox();
            this.laboratoryName1 = new RASF.Main.Controls.Laboratory.LaboratoryName();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDetailOutput = new RASF.General.Controls.Grid();
            this.outPutExecutersDetailFormanagerList1 = new RASF.General.Lists.OutPutExecutersDetailFormanagerList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).BeginInit();
            this.grpOfficesName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 581);
            this.pnlButton.Size = new System.Drawing.Size(1085, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1085, 581);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(880, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(963, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1025, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPersonel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPersonel
            // 
            this.grdPersonel.AlowRetrieveStructure = false;
            this.grdPersonel.AlternatingColors = true;
            this.grdPersonel.BuiltInTextsData = resources.GetString("grdPersonel.BuiltInTextsData");
            this.grdPersonel.DataSource = this.outPutExecutersDetailList1;
            this.grdPersonel.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPersonel_DesignTimeLayout.LayoutString = resources.GetString("grdPersonel_DesignTimeLayout.LayoutString");
            this.grdPersonel.DesignTimeLayout = grdPersonel_DesignTimeLayout;
            this.grdPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPersonel.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdPersonel.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdPersonel.GroupByBoxVisible = false;
            this.grdPersonel.Location = new System.Drawing.Point(3, 8);
            this.grdPersonel.Name = "grdPersonel";
            this.grdPersonel.RecordNavigator = true;
            this.grdPersonel.Size = new System.Drawing.Size(1079, 261);
            this.grdPersonel.TabIndex = 0;
            this.grdPersonel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPersonel.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPersonel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdPersonel.SelectionChanged += new System.EventHandler(this.grdPersonel_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1085, 83);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.grpDate);
            this.uiTabPage1.Controls.Add(this.grpOfficesName);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1081, 59);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "کارکرد پرسنل آماده سازی";
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(806, 59);
            this.grpDate.TabIndex = 6;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(379, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 39);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // grpOfficesName
            // 
            this.grpOfficesName.Controls.Add(this.laboratoryName1);
            this.grpOfficesName.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOfficesName.Location = new System.Drawing.Point(806, 0);
            this.grpOfficesName.Name = "grpOfficesName";
            this.grpOfficesName.Size = new System.Drawing.Size(275, 59);
            this.grpOfficesName.TabIndex = 5;
            this.grpOfficesName.Text = "انتخاب نام آزمایشگاه";
            this.grpOfficesName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // laboratoryName1
            // 
            this.laboratoryName1.BackColor = System.Drawing.Color.Transparent;
            this.laboratoryName1.Location = new System.Drawing.Point(6, 15);
            this.laboratoryName1.Name = "laboratoryName1";
            this.laboratoryName1.Size = new System.Drawing.Size(271, 29);
            this.laboratoryName1.TabIndex = 0;
            this.laboratoryName1.SelectedValueChanged += new System.EventHandler(this.laboratoryName1_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDetailOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 226);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDetailOutput
            // 
            this.grdDetailOutput.AlowRetrieveStructure = false;
            this.grdDetailOutput.AlternatingColors = true;
            this.grdDetailOutput.BuiltInTextsData = resources.GetString("grdDetailOutput.BuiltInTextsData");
            this.grdDetailOutput.DataSource = this.outPutExecutersDetailFormanagerList1;
            this.grdDetailOutput.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetailOutput_DesignTimeLayout.LayoutString = resources.GetString("grdDetailOutput_DesignTimeLayout.LayoutString");
            this.grdDetailOutput.DesignTimeLayout = grdDetailOutput_DesignTimeLayout;
            this.grdDetailOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetailOutput.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDetailOutput.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDetailOutput.GroupByBoxVisible = false;
            this.grdDetailOutput.Location = new System.Drawing.Point(3, 8);
            this.grdDetailOutput.Name = "grdDetailOutput";
            this.grdDetailOutput.Size = new System.Drawing.Size(1079, 215);
            this.grdDetailOutput.TabIndex = 2;
            this.grdDetailOutput.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetailOutput.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetailOutput.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Personnelfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1085, 611);
            this.Name = "Personnelfunction";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Personnelfunction_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).EndInit();
            this.grpOfficesName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private General.Controls.GroupBox groupBox1;
        //private General.Controls.TabControl tabControl1;
        //private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        //private General.Lists.OutPutExecutersDetailList outPutExecutersDetailList1;
        //private General.Controls.Grid grdPersonel;
        //private General.Controls.GroupBox grpDate;
        //private Controls.PickDate.PickDate pickDate1;
        //private General.Controls.GroupBox groupBox2;
        //private General.Controls.Grid grid1;
        //private General.Controls.Grid grdDetailOutput;
        //private General.Lists.OutPutExecutersDetailFormanagerList outPutExecutersDetailFormanagerList1;

      //  private IContainer components;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.TabControl tabControl1;
        private UITabPage uiTabPage1;
        private OutPutExecutersDetailList outPutExecutersDetailList1;
        private Grid grdPersonel;
        private RASF.General.Controls.GroupBox groupBox2;
        private Grid grdDetailOutput;
        private OutPutExecutersDetailFormanagerList outPutExecutersDetailFormanagerList1;
        private RASF.General.Controls.GroupBox grpDate;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Controls.GroupBox grpOfficesName;
        private LaboratoryName laboratoryName1;
    }
}
