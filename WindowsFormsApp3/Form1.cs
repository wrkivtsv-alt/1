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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Guest("Гость").Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            var usertab = uSersTableAdapter1.GetData();

            for (int i = 0;i < usertab.Rows.Count;i++)
            {
                if (login == usertab.Rows[i]["Login"].ToString()){

                    if (password == usertab.Rows[i]["Password"].ToString())
                    {
                        string role = usertab.Rows[i]["Role"].ToString();
                        string Fio = usertab.Rows[i]["FIO"].ToString();
                        UserData.Name = Fio;

                        switch (role)
                        {
                            case "Авторизированный клиент":
                                new Guest(Fio).Show();
                                this.Visible=false;
                                break;
                            case "Администратор":
                                new Manager(Fio).Show();
                                this.Visible = false;
                                break;
                            case "Менеджер":
                                new Manager(Fio).Show();
                                this.Visible = false;
                                break;

                        }
                    }

                }
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
