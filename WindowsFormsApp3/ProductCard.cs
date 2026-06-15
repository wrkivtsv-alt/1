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
    public partial class ProductCard : Form
    {
        public ProductCard(DataGridViewRow row)
        {
            InitializeComponent();
            DataRowView rowView = (DataRowView)row.DataBoundItem;
            DataRow dataRow = rowView.Row;

            textBox1.Text = dataRow[1].ToString();  
            textBox2.Text = dataRow[2].ToString();  
            textBox3.Text = dataRow[4].ToString();  
            textBox4.Text = dataRow[7].ToString();  
            textBox5.Text = dataRow[9].ToString();  
            textBox6.Text = dataRow[10].ToString(); 
            textBox7.Text = dataRow[5].ToString();  

        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
