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
    public partial class frmOrderPosition : Form
    {
        public frmOrderPosition()
        {
            InitializeComponent();
        }

        private void frmOrderPosition_Load(object sender, EventArgs e)
        {
            this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
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
            frmAdd_Update_OrderPosition f = new frmAdd_Update_OrderPosition();
            f.Text = "Добавление данных по позиции заказа";
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdd_Update_OrderPosition f = new frmAdd_Update_OrderPosition();
            f.Text = "Редактирование данных по позиции заказа";
            f.numberPositionOrder = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.numOrder = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            if (f.ShowDialog() == DialogResult.OK) this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
                SqlCommand cmd = new SqlCommand("DELETE FROM ПОЗИЦИИ WHERE Номер_позиции_заказа = @numberPositionOrder AND Номер_заказа = @numOrder", con);
                cmd.Parameters.AddWithValue("@numberPositionOrder", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@numOrder", dataGridView1.CurrentRow.Cells[1].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
                if (dataGridView1.RowCount == 0)
                {
                    SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT ('ПОЗИЦИИ', RESEED, 0)", con);
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
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите из списка поле, по которому хотите осуществить поиск.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((textBox1.Text == "") || (textBox1.Text == null))
            {
                MessageBox.Show("Введите в текстовое поле значение, по которому хотите осуществить поиск.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.пОЗИЦИИBindingSource.Filter = "Марка_стали" + "=" + "'" + textBox1.Text + "'";
                    break;
                case 1:
                    this.пОЗИЦИИBindingSource.Filter = "Диаметр" + "=" + "'" + textBox1.Text + "'";
                    break;
                case 2:
                    this.пОЗИЦИИBindingSource.Filter = "Стенка" + "=" + "'" + textBox1.Text + "'";
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.пОЗИЦИИBindingSource.Filter = "";
        }
    }
}