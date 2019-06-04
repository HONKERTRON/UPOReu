using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UPOReu
{
    public partial class FormMain : Form
    {
        public int role = 0;
        public Form aform;
        SqlConnection connection;

        public FormMain(SqlConnection connection, Form aform, int role)
        {
            InitializeComponent();
            this.role = role;
            this.aform = aform;
            this.connection = connection;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            switch (role)
            {
                ///TODO Roles
                case 1:
                    Text = "Никто";
                    break;
                case 2:
                    Text = "Техник";
                    break;
                case 3:
                    Text = "Начальник чего-то там";
                    break;
                case 10 :
                    Text = "Главный администратор";
                    break;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            aform.Close();
        }

        private void buttonCreateAccs_Click(object sender, EventArgs e)
        {
            if(role > 3)
            {
                FormReg formReg = new FormReg(connection);
                formReg.Show();
            }
        }

        private void buttonObjects_Click(object sender, EventArgs e)
        {
            if (role > 2)
            {
                FormObjects formObj = new FormObjects(connection);
                formObj.Show();
            }
        }

        private void buttonJournal_Click(object sender, EventArgs e)
        {
            if (role > 2)
            {
                FormJournal formJ = new FormJournal(connection);
                formJ.Show();
            }
        }
    }
}
