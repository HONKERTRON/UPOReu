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
    public partial class FormAuth : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5V1BK5F\MSSQLSERVERH;Initial Catalog=UPOReuV3;Integrated Security=True");
        DataSet dataSet = new DataSet();

        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand query = new SqlCommand("SELECT [ID_LUDI] FROM LUDI WHERE [LOGLUGI] = '" + textBoxUsername.Text + "';", connection);
            SqlDataReader reader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            connection.Close();
            if ((textBoxUsername.TextLength == 0) || (textBoxPassword.TextLength == 0))
            {
                label1.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                if (list.Count > 0)
                {
                    //connection.Open();
                    //String cmd = "SELECT [ROLE] FROM LUDI WHERE [NAMLUDI] = '" + textBoxUsername.Text + "' AND HASHBYTES ('MD5', '" + textBoxPassword.Text + "') = [PARLUDI];";
                    //SqlCommand query_ = new SqlCommand(cmd, connection);
                    //label1.Text = "Найдено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
                    //connection.Close();

                    Hide();
                    FormMain formMain = new FormMain(connection, this, 10); ///TODO Add Roles
                    formMain.Show();
                }
            } 
        }
    }
}
