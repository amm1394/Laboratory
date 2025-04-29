using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Amadesazi
{
    public partial class TahviliAmadesazi : Form
    {
        private List<String> UserName = new List<String>();
        private List<Guid> UserId = new List<Guid>();
        private int Postion = 0;

        public TahviliAmadesazi()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.splitContainer1.SplitterDistance = (this.splitContainer1.Panel1.Width + this.splitContainer1.Panel2.Width) / 2;
        }

        private void TahviliAmadesazi_Load(object sender, EventArgs e)
        {
            this.amadesazi3.GetData += MyControl1_GetData;
            this.amadesazi4.GetData += MyControl1_GetData;
            this.Loaddata();
            MyControl1_GetData(this.amadesazi3, new EventArgs());
            MyControl1_GetData(this.amadesazi4, new EventArgs());

        }


        private void MyControl1_GetData(object sender, EventArgs e)
        {
            RASF.Main.Controls.Amadesazi.Amadesazi control = (RASF.Main.Controls.Amadesazi.Amadesazi)sender;
            var Data1 = from row in this.tahviliAmadesaziList1
                        where row.UserName == this.UserName[Postion]
                        orderby row.DateOfTest
                        select row;

            //var CNKol = from row in this.showTakhiriMonthlyList1
            //            where row.TestExecutersCodeEnter1 == this.UserId[Postion]
            //            select new
            //            {
            //                CNKol = row.CNKol
            //            };

            //var CNTakhiri = from row in this.showTakhiriMonthlyList1
            //                where row.TestExecutersCodeEnter2 == this.UserId[Postion]
            //                select new
            //                {
            //                    CNTakhiri = row.CNTakhiri
            //                };


            
            control.UserName = this.UserName[Postion];
           // control.CNKol = CNKol.FirstOrDefault().CNKol.ToString();
           // control.CNTakhiri = CNTakhiri.FirstOrDefault().CNTakhiri.ToString();
            control.DataSource = Data1.ToList<RASF.General.Data.TahviliAmadesazi>();

            Postion++;
            if (Postion == this.UserName.Count)
            {
                this.Loaddata();
                Postion = 0;
            }
        }

        private void Loaddata()
        {
            this.tahviliAmadesaziList1.Fill();
            this.showTakhiriMonthlyList1.Fill();

            var groupedData = from row in tahviliAmadesaziList1
                              group row by row.UserName into g
                              select g;

            this.UserName.Clear();
            this.UserId.Clear();

            foreach (var name in groupedData)
            {
                UserName.Add(name.Key);
                if (String.IsNullOrWhiteSpace(name.First().UserId.ToString()) == true)
                {
                    UserId.Add(new Guid());
                }
                else
                {
                    UserId.Add(new Guid(name.First().UserId.ToString()));
                }
            }
        }

    }
}
