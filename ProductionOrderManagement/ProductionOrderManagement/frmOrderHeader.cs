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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProductionOrderManagement
{
    public partial class frmOrderHeader : Form
    {
        public frmOrderHeader()
        {
            InitializeComponent();
        }

        private void frmOrderHeader_Load(object sender, EventArgs e)
        {
            this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
            if (dataGridView1.RowCount == 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdd_Update_OrderHeader f = new frmAdd_Update_OrderHeader();
            f.Text = "Добавление данных по заголовку заказа";
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdd_Update_OrderHeader f = new frmAdd_Update_OrderHeader();
            f.Text = "Редактирование данных по заголовку заказа";
            f.numberOrder = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (f.ShowDialog() == DialogResult.OK) this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
                SqlCommand cmd = new SqlCommand("DELETE FROM ЗАГОЛОВОК WHERE Номер_заказа = @numberOrder", con);
                cmd.Parameters.AddWithValue("@numberOrder", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
                if (dataGridView1.RowCount == 0)
                {
                    SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT ('ЗАГОЛОВОК', RESEED, 0)", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox1.Text == null))
            {
                MessageBox.Show("Введите в текстовое поле значение, по которому хотите осуществить поиск.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.зАГОЛОВОКBindingSource.Filter = "Цех_производитель" + "=" + "'" + textBox1.Text + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.зАГОЛОВОКBindingSource.Filter = "";
        }
    }
}
