using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class EditTafahomName : RASF.General.Forms.Base.DockContentForm
    {
        private Int64 TafahomCode;
        public EditTafahomName(Int64 TafahomId)
        {
            InitializeComponent();
            this.tafahomNameList1.spName = "TafahomNameEdit";
            TafahomCode = TafahomId;
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomNameCode", this.tafahomNameList1.list[0].TafahomNameCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomnameNo", txttafahomno.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("HasIntroduction", chkIntroduction.Checked));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Discount", txtDiscount.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Cheque", txtCheque.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Tasviyeh", txtTasviyeh.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CoOperatopnGroupCode", drpCooperation.SelectedValue));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Connector", txtConnector.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TechnicalAssis", txttechnical.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Signatory", txtSignatory.Text));
            RASF.General.Lists.BanksList.FillScalar("TafahomName_Update", Parameter);

            this.Close();
        }

        private void EditTafahomName_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@TafahomNameCode", TafahomCode));
            this.tafahomNameList1.Fill(Parameters);

            this.cooperationGroup_TafahomNameList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCooperation, "Description", "Code", cooperationGroup_TafahomNameList1);


            txttafahomno.Text = this.tafahomNameList1.list[0].TafahomnameNo;
            txtDiscount.Text = this.tafahomNameList1.list[0].Discount.ToString();
            txtCheque.Text = this.tafahomNameList1.list[0].Cheque.ToString();
            txtTasviyeh.Text = this.tafahomNameList1.list[0].Tasviyeh.ToString();
            chkIntroduction.Checked = this.tafahomNameList1.list[0].HasIntroduction;
            drpCooperation.SelectedValue = this.tafahomNameList1.list[0].CoOperatopnGroupCode;
            txtConnector.Text = this.tafahomNameList1.list[0].Connector;
            txttechnical.Text = this.tafahomNameList1.list[0].TechnicalAssis;
            txtSignatory.Text = this.tafahomNameList1.list[0].Signatory;
            datepictafahomSign.SelectedDateTime = this.tafahomNameList1.list[0].TafahomNameSignDate;
            datepicTafahomFrom.SelectedDateTime = this.tafahomNameList1.list[0].TafahomNameDateFrom;
            datepicTafahomTo.SelectedDateTime = this.tafahomNameList1.list[0].TafahomNameDateTo;
        }
    }
}
