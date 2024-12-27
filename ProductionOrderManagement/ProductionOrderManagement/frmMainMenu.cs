using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionOrderManagement
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Activated(object sender, EventArgs e)
        {
            позицииЗаказаToolStripMenuItem.Enabled = true;
            int countOrders;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ЗАГОЛОВОК", con);
            con.Open();
            countOrders = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (countOrders == 0)
            {
                позицииЗаказаToolStripMenuItem.Enabled = false;
            }
        }

        private void заголовокЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderHeader f = new frmOrderHeader();
            f.Show();
        }

        private void позицииЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderPosition f = new frmOrderPosition();
            f.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завершить работу с программой?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}