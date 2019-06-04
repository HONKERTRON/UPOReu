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
    public partial class FormReg : Form
    {
        SqlConnection connection;
        public FormReg(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            ///TODO Finish registration
            connection.Open();
            SqlCommand query = new SqlCommand("SELECT [ID_LUDI] FROM LUDI WHERE [LOGLUGI] = '"+ textBoxUsername.Text+"';", connection);
            SqlDataReader reader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            connection.Close();
            if ((textBoxName.TextLength == 0) || (textBoxLastName.TextLength == 0) || (textBoxUsername.TextLength == 0) || (textBoxPassword.TextLength == 0))
            {
                label1.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                if (list.Count > 0)
                {
                    label1.Text = "Пользователь с таким логином уже существует.";
                }
                else
                {
                    connection.Open();
                    String cmd = "INSERT INTO LUDI([NAMLUDI], [FAMLUDI], [OTLUDI], [LOGLUGI], [PARLUDI]) VALUES ('" + textBoxName.Text + "', '" + textBoxLastName.Text + "', '" + textBoxPatronym.Text + "', '" + textBoxUsername.Text + "', HASHBYTES ('MD5', '" + textBoxPassword.Text + "'));";
                    SqlCommand query_ = new SqlCommand(cmd, connection);
                    label1.Text = "Изменено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
                    connection.Close();
                }
            }
        }
    }
}
