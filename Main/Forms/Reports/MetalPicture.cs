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
    public partial class MetalPicture : RASF.General.Forms.Base.DockContentForm
    {
        public Guid PartsTestMasterCode { get; set; }

        public List<RASF.General.Data.Metal_Pic> Selectedpic
        {
            get { return this.metal_PicList1.Where(row => row.Check == true).ToList(); }
        }
        public MetalPicture()
        {
            InitializeComponent();
        }

        private void MetalPicture_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            this.metal_PicList1.Fill(Parameters);

            this.grdpic.Refetch();
        }

    }
}
