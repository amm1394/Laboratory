using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class ReceptionPicture : RASF.General.Forms.Base.DockContentForm
    {
        public Guid PartsTestMasterCode { get; set; }

        //public List<RASF.General.Data.Metal_Pic> Selectedpic
        //{
        //    get { return this.reception_PicList1.Where(row => row.Check == true).ToList(); }
        //}
        public ReceptionPicture()
        {
            InitializeComponent();
        }

        private void MetalPicture_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            this.reception_PicList1.Fill(Parameters);

            this.grdpic.Refetch();
        }

    }
}
