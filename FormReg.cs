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
            //Запрос на поиск человека с таким юзернеймом
            SqlCommand query = new SqlCommand("SELECT [idUSERS] FROM [USERS] WHERE [username] = '"+ textBoxUsername.Text+"';", connection);
            SqlDataReader reader = query.ExecuteReader();
            List<String> list = new List<String>();
            //Заполняем спсок результатами
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            connection.Close();
            if ((textBoxName.TextLength == 0) || (textBoxLastName.TextLength == 0) || (maskedTextBoxPhone.TextLength == 0) || (textBoxEmail.TextLength == 0) || (textBoxUsername.TextLength == 0) || (textBoxPassword.TextLength == 0))
            {
                label1.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                //Если человек нашелс
                if (list.Count > 0)
                {
                    label1.Text = "Пользователь с таким логином уже существует.";
                }
                //Если не нашелся
                else
                {
                    connection.Open();
                    //Запрос на вставку новой записи со всеми данными о человеке
                    String cmd = "INSERT INTO [USERS]([name], [last_name], [patronym], [phone_number], [email], [username], [password]) VALUES ('" + textBoxName.Text + "', '" + textBoxLastName.Text + "', '" + textBoxPatronym.Text + "', '" + maskedTextBoxPhone.Text + "', '" + textBoxEmail.Text + "', '" + textBoxUsername.Text + "', HASHBYTES ('MD5', '" + textBoxPassword.Text + "'));";
                    SqlCommand query_ = new SqlCommand(cmd, connection);
                    label1.Text = "Изменено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
                    connection.Close();
                }
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
