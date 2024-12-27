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
    public partial class frmAdd_Update_OrderPosition : Form
    {
        public int numberPositionOrder { get; set; }
        public int numOrder { get; set; }
        public frmAdd_Update_OrderPosition()
        {
            InitializeComponent();
        }

        private void frmAdd_Update_OrderPosition_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "productionOrderManagementDataSet.ЗАГОЛОВОК". При необходимости она может быть перемещена или удалена.
            this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "productionOrderManagementDataSet.ПОЗИЦИИ". При необходимости она может быть перемещена или удалена.
            this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
            this.пОЗИЦИИTableAdapter.Fill(this.productionOrderManagementDataSet.ПОЗИЦИИ);
            if (numberPositionOrder > 0)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT* FROM ПОЗИЦИИ WHERE Номер_позиции_заказа = @numberPositionOrder AND Номер_заказа = @numOrder", con);
                cmd.Parameters.AddWithValue("@numberPositionOrder", numberPositionOrder);
                cmd.Parameters.AddWithValue("@numOrder", numOrder);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                comboBox1.SelectedValue = rd["Номер_позиции_заказа"].ToString();
                comboBox2.SelectedValue = rd["Номер_заказа"].ToString();
                textBox1.Text = rd["Марка_стали"].ToString();
                textBox2.Text = rd["Диаметр"].ToString();
                textBox3.Text = rd["Стенка"].ToString();
                textBox4.Text = rd["Объем_позиции"].ToString();
                comboBox3.SelectedItem = rd["Единица_измерения"].ToString();
                comboBox4.SelectedItem = rd["Статус"].ToString();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox1.Text == null))
            {
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((textBox2.Text == "") || (textBox2.Text == null))
            {
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((textBox3.Text == "") || (textBox3.Text == null))
            {
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((textBox4.Text == "") || (textBox4.Text == null))
            {
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT* FROM ПОЗИЦИИ WHERE Номер_позиции_заказа = @numberPositionOrder AND Номер_заказа = @numOrder", con);
            if (numberPositionOrder > 0)
            {
                cmd = new SqlCommand("UPDATE ПОЗИЦИИ SET Номер_заказа = @numOrder2, Марка_стали = @steelMark, Диаметр = @diameter, Стенка = @wall, Объем_позиции = @positionVolume, Единица_измерения = @unitMeasurement, Статус = @status WHERE Номер_позиции_заказа = @numberPositionOrder AND Номер_заказа = @numOrder", con);
                cmd.Parameters.AddWithValue("@numberPositionOrder", numberPositionOrder);
                cmd.Parameters.AddWithValue("@numOrder", numOrder);
            }
            else cmd = new SqlCommand("INSERT ПОЗИЦИИ(Номер_заказа, Марка_стали, Диаметр, Стенка, Объем_позиции, Единица_измерения, Статус) VALUES(@numOrder2, @steelMark, @diameter, @wall, @positionVolume, @unitMeasurement, @status)", con);
            cmd.Parameters.AddWithValue("@numOrder2", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@steelMark", textBox1.Text);
            cmd.Parameters.AddWithValue("@diameter", textBox2.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@wall", textBox3.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@positionVolume", textBox4.Text.Replace(",", "."));
            if (comboBox3.SelectedIndex != -1) cmd.Parameters.AddWithValue("@unitMeasurement", comboBox3.SelectedItem);
            else cmd.Parameters.AddWithValue("@unitMeasurement", "");
            if (comboBox4.SelectedIndex != -1) cmd.Parameters.AddWithValue("@status", comboBox4.SelectedItem);
            else cmd.Parameters.AddWithValue("@status", "");
            con.Open();
            //try
            //{
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
           // }
            //catch
          //  {
             //   MessageBox.Show("Нарушение целостности данных, или некорректный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
            con.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Поле Марка стали не может быть пустым!");
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Поле Диаметр не может быть пустым!");
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
            if ((textBox2.Text.IndexOf("0") == 0) || (textBox2.Text.IndexOf(",") == 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Диаметр не может быть равен нулю!");
                MessageBox.Show("Диаметр не может быть равен нулю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Поле Стенка не может быть пустым!");
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
            if ((textBox3.Text.IndexOf("0") == 0) || (textBox3.Text.IndexOf(",") == 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Стенка не может быть равна нулю!");
                MessageBox.Show("Стенка не может быть равна нулю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "Поле Объем позиции не может быть пустым!");
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
            if ((textBox4.Text.IndexOf("0") == 0) || (textBox4.Text.IndexOf(",") == 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "Объем позиции не может быть равен нулю!");
                MessageBox.Show("Объем позиции не может быть равен нулю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.A || e.KeyChar == (char)Keys.X || e.KeyChar == (char)Keys.C || e.KeyChar == (char)Keys.V || e.KeyChar == (char)Keys.Z);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.A || e.KeyChar == (char)Keys.X || e.KeyChar == (char)Keys.C || e.KeyChar == (char)Keys.V || e.KeyChar == (char)Keys.Z);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.A || e.KeyChar == (char)Keys.X || e.KeyChar == (char)Keys.C || e.KeyChar == (char)Keys.V || e.KeyChar == (char)Keys.Z);
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}