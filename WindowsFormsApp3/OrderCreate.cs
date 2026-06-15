using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class OrderCreate : Form
    {
        public OrderCreate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Manager(UserData.Name).Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Tovar().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Users().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Adres().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Treining1DataSet.OrdersDataTable ordersTable = ordersTableAdapter1.GetData();
            DataRow newRow = ordersTable.NewRow();

            newRow["articleId"] = textBox1.Text.Trim();
            newRow["DateOrder"] = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            newRow["DateDilivery"] = Convert.ToDateTime(dateTimePicker2.Text.Trim());
            newRow["Adress"] = textBox5.Text.Trim();
            newRow["Users"] = textBox6.Text.Trim();
            newRow["Code"] = textBox7.Text.Trim();
            newRow["Statuses"] = textBox8.Text.Trim();

            ordersTable.Rows.Add(newRow);
            ordersTableAdapter1.Update(ordersTable);

            MessageBox.Show("Добавлено!");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
