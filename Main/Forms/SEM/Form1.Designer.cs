namespace RASF.Main.Forms.SEM
{
    partial class Form1
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
            //DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            //DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            //DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            //this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.reportOfSemList1 = new RASF.General.Lists.ReportOfSemList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 606);
            this.pnlButton.Size = new System.Drawing.Size(1073, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(1073, 606);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(868, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(951, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1013, 0);
            // 
            // schedulerControl1
            // 
            //this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            //this.schedulerControl1.Name = "schedulerControl1";
            //this.schedulerControl1.Size = new System.Drawing.Size(1073, 465);
            //this.schedulerControl1.Start = new System.DateTime(2018, 8, 12, 0, 0, 0, 0);
            //this.schedulerControl1.TabIndex = 0;
            //this.schedulerControl1.Text = "schedulerControl1";
            //this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            //this.schedulerControl1.Views.FullWeekView.Enabled = true;
            //this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            //this.schedulerControl1.Views.WeekView.Enabled = false;
            //this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 636);
            this.Name = "Form1";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
       //     ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      //  private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private General.Lists.AppointmentsList appointmentsList1;
        private General.Lists.ResourcesList resourcesList1;
        private General.Lists.ReportOfSemList reportOfSemList1;
    }
}