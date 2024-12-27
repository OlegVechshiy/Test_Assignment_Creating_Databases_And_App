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
    public partial class frmAdd_Update_OrderHeader : Form
    {
        public int numberOrder { get; set; }
        public frmAdd_Update_OrderHeader()
        {
            InitializeComponent();
        }

        private void frmAdd_Update_OrderHeader_Load(object sender, EventArgs e)
        {
            this.зАГОЛОВОКTableAdapter.Fill(this.productionOrderManagementDataSet.ЗАГОЛОВОК);
            if (numberOrder > 0)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT* FROM ЗАГОЛОВОК WHERE Номер_заказа = @numberOrder", con);
                cmd.Parameters.AddWithValue("@numberOrder", numberOrder);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                comboBox1.SelectedValue = rd["Номер_заказа"].ToString();
                textBox1.Text = rd["Цех_производитель"].ToString();
                dateTimePicker1.Value = (DateTime)rd["Дата_начала"];
                dateTimePicker2.Value = (DateTime)rd["Дата_окончания"];
                comboBox2.SelectedItem = rd["Статус"].ToString();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ProductionOrderManagementConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT* FROM ЗАГОЛОВОК WHERE Номер_заказа = @numberOrder", con);
            if (numberOrder > 0)
            {
                cmd = new SqlCommand("UPDATE ЗАГОЛОВОК SET Цех_производитель = @machineShop, Дата_начала = @dateStart, Дата_окончания = @dateEnd, Статус = @status WHERE Номер_заказа = @numberOrder", con);
                cmd.Parameters.AddWithValue("@numberOrder", numberOrder);
            }
            else cmd = new SqlCommand("INSERT ЗАГОЛОВОК(Цех_производитель, Дата_начала, Дата_окончания, Статус) VALUES(@machineShop, @dateStart, @dateEnd, @status)", con);
            cmd.Parameters.AddWithValue("@machineShop", textBox1.Text);
            cmd.Parameters.AddWithValue("@dateStart", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@dateEnd", dateTimePicker2.Value);
            if (comboBox2.SelectedIndex != -1) cmd.Parameters.AddWithValue("@status", comboBox2.SelectedItem);
            else cmd.Parameters.AddWithValue("@status", "");
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Нарушение целостности данных, или некорректный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Поле Цех-производитель не заполнено!");
                MessageBox.Show("Поля под * не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else errorProvider1.Clear();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}