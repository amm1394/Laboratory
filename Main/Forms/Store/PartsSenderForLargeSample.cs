using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class PartsSenderForLargeSample : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        public PartsSenderForLargeSample()
        {
            InitializeComponent();
            this.ShowpnlSave = false;

            this.part_PicList1.spName = "Part_Pic_Store";
        }


        private void RefechGrids()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.partsAreNotStoredForLargeSampleList1.Fill(Parameter);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.emptyBasketForLargeSampleList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.partsAreNotExitedFromStoredForLargeSampleList1.Fill(Parameter2);

            this.txtDesc.Text = "";
            List<System.Data.SqlClient.SqlParameter> ParameterD1 = new List<System.Data.SqlClient.SqlParameter>();
            ParameterD1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            string Desc = (string)RASF.General.Lists.Base.BaseList<Object>.FillScalar("DescriptionPartsSenderForLargeSample_Select", ParameterD1);
            if (Desc != null)
            {
                this.txtDesc.Text = Desc.ToString();
            }

            this.grdParts.Refetch();
            this.grdEmptyBasket.Refetch();
            this.grdExit.Refetch();
        }

        private void grdEmptyBasket_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            Guid BasketCode = ((RASF.General.Data.Basket)this.grdEmptyBasket.CurrentRow.DataRow).BasketCode;

            foreach(RASF.General.Data.EnterExitPieces Parts in this.partsAreNotStoredForLargeSampleList1)
            {
                if (Parts.IsCheked == true)
                {
                    Parts.BasketCode = BasketCode;
                }
                else
                {
                    Parts.RowState = General.Enums.RowState.Original;
                }
            }
            this.partsAreNotStoredForLargeSampleList1.Update();
            RefechGrids();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (txtRefered.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("لطفا نام تحویل گیرنده را وارده نمایید");
            }
            else
            {
                foreach (RASF.General.Data.EnterExitPieces Exits in this.partsAreNotExitedFromStoredForLargeSampleList1)
                {
                    if (Exits.IsCheked == true)
                    {
                        Exits.ReferedName = txtRefered.Text;
                    }
                    else
                    {
                        Exits.RowState = General.Enums.RowState.Original;
                    }
                }

                this.partsAreNotExitedFromStoredForLargeSampleList1.Update();


                RefechGrids();

                txtRefered.Text = "";
            }
        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;
            this.txtDesc.Text = "";
            RefechGrids();

            List<System.Data.SqlClient.SqlParameter> Parameter5 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter5.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            int VoidPart = (int)RASF.General.Lists.Base.BaseList<Object>.FillScalar("VoidPart", Parameter5);

            label2.Text = VoidPart.ToString();

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.part_PicList1.Fill(Parameter1);

            this.letter_Scan1.Genrate_PartPic_Pdf(this.part_PicList1);

            List<System.Data.SqlClient.SqlParameter> ParameterS = new List<System.Data.SqlClient.SqlParameter>();
            ParameterS.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.ContractsCode));
            int Samlpe = (int)RASF.General.Lists.BanksList.FillScalar("Donotsendsample_Select", ParameterS);

            if (Samlpe == 1)
            {
                MessageBox.Show("نمونه ارسال نشود");
            }
        }

        private void PartsSenderForLargeSample_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
        }

        private void btnDeliver_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtDesc.Text != "")
            {
                List<System.Data.SqlClient.SqlParameter> ParameterD2 = new List<System.Data.SqlClient.SqlParameter>();
                ParameterD2.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.ContractsCode));
                ParameterD2.Add(new System.Data.SqlClient.SqlParameter("@Description", this.txtDesc.Text));
                RASF.General.Lists.BanksList.FillScalar("DescriptionPartsSenderForLargeSample_Insert", ParameterD2);
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
            }
            else
            {
                MessageBox.Show("متنی قرار داده نشد ه است");
            }
        }
    }
}
