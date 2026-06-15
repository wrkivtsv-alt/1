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
    public partial class Guest : Form
    {
        public Guest(string name)
        {
            InitializeComponent();
            label13.Text = name;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treining1DataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.treining1DataSet.Tovar);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tovarBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovarBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tovarBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tovarBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Auth().Show();
            this.Visible = false;
        }
    }
}
