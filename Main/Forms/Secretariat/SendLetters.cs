using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Secretariat
{
    public partial class SendLetters : RASF.General.Forms.Base.DockContentForm
    {
        public SendLetters()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendLetters_Load(object sender, EventArgs e)
        {
            this.partGroupingList1.Fill();
            this.sendTypeList1.Fill();
            this.actingGroupList1.Fill();
           // this.sendLettersList1.Fill();

            General.Classes.Utility.CreateDropDow(drpGroup, "GroupingNme", "GroupingCode", partGroupingList1);
            General.Classes.Utility.CreateDropDow(drpSendType, "SendTypeName", "SendTypeCode", sendTypeList1);
         //   General.Classes.Utility.CreateDropDow(drpActingGroup, "ActingGroupName", "ActingGroupCode", actingGroupList1);

            this.letter_Scan1.Intial_Watcher();
            //?????
            if (this is RASF.Main.Forms.Secretariat.EditSendLetters)
            {
                this.sendLettersList1.list[0].RowState = General.Enums.RowState.Updated;
                if (this.sendLettersList1.list[0].Letter != null)
                {
                    this.letter_Scan1.Document = this.sendLettersList1.list[0].Letter;
                }
            }
            else
            {
                this.sendLettersList1.Add(new General.Data.SendLetters());
                this.sendLettersList1.list[0].SendLettersCode = this.sendLettersList1.GetId();
                this.sendLettersList1.list[0].RowState = General.Enums.RowState.Added;
              //  this.sendLettersList1[0].ContractYear = RASF.General.Classes.Global.FinancialYear;
            }
            
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

          
            //    this.sendLettersList1.Add(new General.Data.SendLetters());
             //   this.sendLettersList1.list[0].SendLettersCode = this.sendLettersList1.GetId();
             //   this.sendLettersList1.list[0].RowState = General.Enums.RowState.Added;
                this.sendLettersList1[0].CompanyName = this.txtCompanyName.Text;
                this.sendLettersList1[0].DescForSendType = this.txtDescForSendType.Text;
                this.sendLettersList1[0].GroupingCode = (int)this.drpGroup.SelectedValue;
                this.sendLettersList1[0].Reciever = this.txtReciever.Text;
                this.sendLettersList1[0].SendType = (int)this.drpSendType.SelectedValue;
                this.sendLettersList1[0].SubjectOfLetters = this.txtSubjectOfLetters.Text;
                this.sendLettersList1[0].UserRegister = RASF.General.Classes.Global.CurrentUserName;
                this.sendLettersList1[0].Letter = this.letter_Scan1.Document;

                if (this.sendLettersList1[0].CompanyName != null && this.sendLettersList1[0].DescForSendType != null && this.sendLettersList1[0].GroupingCode != -1 && this.sendLettersList1[0].Reciever != null && this.sendLettersList1[0].SendType != -1 && this.sendLettersList1[0].SubjectOfLetters != null )
                {
                    this.sendLettersList1.Update();

                    string LetterNo = this.sendLettersList1.GetLetterNo();

                    if (this is RASF.Main.Forms.Secretariat.EditSendLetters)
                    {
                        System.Windows.Forms.MessageBox.Show("نامه مورد نظر با شماره " + "  " + LetterNo + "  " + "اصلاح گردید");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("نامه مورد نظر با شماره " + "  " + LetterNo + "  " + "ذخیره گردید");
                    }

                 //   this.drpActingGroup.SelectedIndex = -1;
                    this.txtDescForSendType.Text = "";
                    this.drpGroup.SelectedIndex = -1;
                    this.txtReciever.Text = "";
                    this.drpSendType.SelectedIndex = -1;
                    this.txtSubjectOfLetters.Text = "";
                    this.letter_Scan1.Document = null;
                    this.txtCompanyName.Text = "";
                 //   this.letter_Scan1.Dispose();
                }
                else
                {
                    MessageBox.Show("اطلاعات را کامل وارد کنید");
                }

           this.Close();


        }
    }
}
