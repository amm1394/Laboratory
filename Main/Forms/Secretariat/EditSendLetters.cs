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
    public partial class EditSendLetters : RASF.Main.Forms.Secretariat.SendLetters
    {
        private Guid sendletterscode;
        public EditSendLetters(Guid SendLettersCode)
        {
            InitializeComponent();
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("SendLettersCode", SendLettersCode));
            this.sendLettersList1.Fill(Parameters2);
            this.sendletterscode = SendLettersCode;
        }

        private void EditSendLetters_Load(object sender, EventArgs e)
        {
            this.txtCompanyName.Text = this.sendLettersList1.list[0].CompanyName;
            this.txtDescForSendType.Text = this.sendLettersList1.list[0].DescForSendType;
            this.txtReciever.Text = this.sendLettersList1.list[0].Reciever;
            this.txtSubjectOfLetters.Text = this.sendLettersList1.list[0].SubjectOfLetters;
            this.drpGroup.SelectedValue = this.sendLettersList1.list[0].GroupingCode;
            this.drpSendType.SelectedValue = this.sendLettersList1.list[0].SendType;

        }
    }
}
