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
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treining1DataSet.Adresses". При необходимости она может быть перемещена или удалена.
            this.adressesTableAdapter.Fill(this.treining1DataSet.Adresses);

        }
    }
}
