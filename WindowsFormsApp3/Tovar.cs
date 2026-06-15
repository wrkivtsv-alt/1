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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treining1DataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.treining1DataSet.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Manager(UserData.Name).Show();
            this.Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex < 0) return;

            DataGridViewRow selectedRow = dataGridView1.Rows[hit.RowIndex];

            ProductCard cardForm = new ProductCard(selectedRow);
            cardForm.Show();
        }
    }
}
