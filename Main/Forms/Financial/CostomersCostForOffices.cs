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
    public partial class CostomersCostForOffices : RASF.General.Forms.Base.DockContentForm
    {
        public CostomersCostForOffices()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void CostomersCost_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.costomersCostGridForOfficesList1.Fill(Parameter);

            this.grdCostomerCost.Refetch();

            this.chkParts.Checked = true;
        }

        private void grdCostomerCost_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value));
            this.costomerCostList1.Fill(Parameters);
            String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

            Aspose.Words.Document doc;
            if (chkParts.Checked == true)
            {
                doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_LetterInA4Paper));
                Report2.Load(String.Format("{0}\\Report\\CustomerscostInA4Paper.mrt", Application.StartupPath));
            }
            else
            {
                doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_Letter));
                Report2.Load(String.Format("{0}\\Report\\Customerscost.mrt", Application.StartupPath));
            }
            //if (informalFactor == false)
            //{
            //    doc.Range.Bookmarks["Amount"].Text = this.costomerCostList1[0].Amount.ToString();
            //}
            if (this.costomerCostList1.list[0].Delivery >DateTime.MinValue)
            {
                doc.Range.Bookmarks["Delivery"].Text = this.costomerCostList1[0].DeliveryString.ToString();
            }
            else
            {
                doc.Range.Bookmarks["Delivery"].Text = "";
            }

            Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Bmp);
            SaveOption.PrettyFormat = true;
            SaveOption.UseAntiAliasing = true;
            SaveOption.UseHighQualityRendering = true;
            doc.Range.Bookmarks["Amount"].Text = this.costomerCostList1[0].Amount.ToString();
            doc.Range.Bookmarks["CoName"].Text = this.costomerCostList1[0].CompanyName;
            doc.Range.Bookmarks["Date"].Text = this.costomerCostList1[0].LetterDate;
            doc.Range.Bookmarks["LetterNo"].Text = this.costomerCostList1[0].LetterNo;
            doc.Range.Bookmarks["ContractNo"].Text = this.costomerCostList1[0].ContractNo.ToString();
            

            doc.Save(FileName, SaveOption);

            if (chkParts.Checked == false)
            {
                using (Image img = Image.FromFile(FileName))
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    img.Save(FileName);
                }
            }

            Report2["@Code"] = this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value;
            Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
            image.File = FileName;
            Report2.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.costomersCostGridForOfficesList1.Fill(Parameter);

            this.grdCostomerCost.Refetch();

            this.chkParts.Checked = true;
        }

      
    }
}
