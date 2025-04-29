using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class CostomersCost : RASF.General.Forms.Base.DockContentForm
    {
        public CostomersCost()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
         //   this.ShowpnlSave = false;
            this.ShowpnlUpdate = true;

        }

        private void CostomersCost_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            this.chkParts.Checked = true;
        }

        private void RefreshGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.costomersCostGridList1.Fill(Parameter);
            this.grdCostomerCost.Refetch();
        }

        public void grdCostomerCost_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value));
            this.costomerCostList1.Fill(Parameters);
            String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

            Boolean informalFactor = (Boolean)this.grdCostomerCost.CurrentRow.Cells["InformalFactor"].Value;

            Aspose.Words.Document doc;
          
            if (chkParts.Checked == true)
            {
               
                if (informalFactor == false)
                {
                    doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_LetterInA4Paper));
                    Report2.Load(String.Format("{0}\\Report\\CustomerscostInA4Paper.mrt", Application.StartupPath));
                }
                else
                {
                    doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_LetterPartsMasterForInformalFactor));
                   // Report2.Load(String.Format("{0}\\Report\\CustomerscostInA4Paper-Informal.mrt", Application.StartupPath));
                }

            }
            else
            {
                doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_Letter));
                Report2.Load(String.Format("{0}\\Report\\Customerscost.mrt", Application.StartupPath));
            }

            Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Jpeg);
            SaveOption.PrettyFormat = true;
            SaveOption.UseAntiAliasing = true;
            SaveOption.UseHighQualityRendering = true;
            if (informalFactor == false)
            {
                doc.Range.Bookmarks["Amount"].Text = this.costomerCostList1[0].Amount.ToString();
            }
            if (this.costomerCostList1.list[0].Delivery > DateTime.MinValue)
            {
                doc.Range.Bookmarks["Delivery"].Text = this.costomerCostList1[0].DeliveryString.ToString();
            }
            else
            {
                doc.Range.Bookmarks["Delivery"].Text = "";
            }
            doc.Range.Bookmarks["CoName"].Text = this.costomerCostList1[0].CompanyName;
            doc.Range.Bookmarks["Date"].Text = this.costomerCostList1[0].LetterDate;
            doc.Range.Bookmarks["LetterNo"].Text = this.costomerCostList1[0].LetterNo;
            doc.Range.Bookmarks["ContractNo"].Text = this.costomerCostList1[0].ContractNo.ToString();
            if (informalFactor == false)
            {
                doc.Range.Bookmarks["DateOfDay"].Text = this.costomerCostList1[0].DateOfDay;
            }


            doc.Save(FileName, SaveOption);

            if (chkParts.Checked == false)
            {
                using (System.Drawing.Image img = System.Drawing.Image.FromFile(FileName))
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    img.Save(FileName);
                }
            }


            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("Code", this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value));
            General.Lists.CostomerCostList.FillScalar("PrintCost_Select", Parameters1);

            Report2["@Code"] = this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value;
            Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
            image.File = FileName;
            Report2.Show();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCostomerCost.ExportToExcel("اعلام هزینه");
        }

      
    }
}
