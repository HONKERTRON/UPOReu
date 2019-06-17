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

namespace UPOReu
{
    public partial class FormInsertUO : Form
    {
        public SqlConnection connection;
        public int objectid = -1;
        public int personid = -1;

        public FormInsertUO(SqlConnection connection, int id = -1)
        {
            InitializeComponent();
            this.connection = connection;
            this.objectid = id;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-M-d";
        }

        private void FormInsertUO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPeople formPeople = new FormPeople(connection, 1);
            formPeople.dataGridViewPeople.CellDoubleClick += (senderObj, eargs) =>
            {
                this.personid = formPeople.select;
                formPeople.Close();
            };
            formPeople.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(objectid > 0 && personid > 0)
            {
                connection.Open();
                String cmd = "INSERT INTO [UO] ([idOBJECT], [idUSERS], [date], [apperience], [mass], [pressure], [state], [actions]) VALUES (" + objectid.ToString() + ", " + personid.ToString() + ", '" + dateTimePicker.Text.ToString() + "', '" + textBoxApp.Text + "', " + textBoxMass.Text + ", " + textBoxP.Text + ", '" + textBoxS.Text + "', '" + textBoxA.Text + "');";
                SqlCommand query_ = new SqlCommand(cmd, connection);
                int res = Convert.ToInt32(query_.ExecuteScalar());
                connection.Close();
                Close();
            }
        }
    }
}
