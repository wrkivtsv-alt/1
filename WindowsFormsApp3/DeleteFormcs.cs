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
    public partial class DeleteFormcs : Form
    {
        public DeleteFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Treining1DataSet.OrdersDataTable ordersTable = ordersTableAdapter1.GetData();
           int targetid = Convert.ToInt32(textBox1.Text.Trim());
            DataRow Flag = null;
            foreach (DataRow row in ordersTable.Rows)
            {
                if (Convert.ToInt32(row["idOrder"]) == targetid)
                {
                    Flag = row;
                }
            }

            if(Flag != null)
            {
                Flag.Delete();
            }
            ordersTableAdapter1.Update(ordersTable);
            MessageBox.Show($"Запись с Id = {targetid} удалена!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Manager(UserData.Name).Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Order().Show();
        }
    }
}
