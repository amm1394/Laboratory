using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //14000813
            String FileName = "Test.Xml";
            GenerateMenu.Classes.WriteXML.WriteFile(FileName, this.menuStrip1);
            String connection = "Data Source=192.168.0.3;Initial Catalog= LaboratoryRASF ;Persist Security Info=True;User ID=sa;Password=AliReza23280";
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(connection))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("UserAccesMenu_Update", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("UserId", "DB95A451-1371-4218-8201-AD1A42609067"));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("XmlMenu", System.IO.File.ReadAllBytes(FileName)));
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }

        private void mnuTestForThePresenceDateForm_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void mnuFinancial_Click(object sender, EventArgs e)
        {

        }

        private void mnuCostomerCost1_Click(object sender, EventArgs e)
        {

        }

        private void mnuHormor_Click(object sender, EventArgs e)
        {

        }

        private void mnuNToCustomer_Click(object sender, EventArgs e)
        {

        }

        private void mnuViewSabtS_Click(object sender, EventArgs e)
        {

        }

        private void mnuViewSabtSamane_Click(object sender, EventArgs e)
        {

        }

        private void مدیریتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void mnuDetailOfReceptionForm_Click(object sender, EventArgs e)
        {

        }
    }
}
