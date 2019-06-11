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
using System.IO;

namespace UPOReu
{
    public partial class FormAuth : Form
    {
        SqlConnection connection;
        DataSet dataSet = new DataSet();

        public FormAuth()
        {
            InitializeComponent();
            using (FileStream fstream = File.OpenRead(@".\database"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                connection = new SqlConnection(@"Data Source=" + textFromFile + ";Initial Catalog=UPOReu;Integrated Security=True");
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            //eO3VRUuP
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if ((textBoxUsername.TextLength == 0) || (textBoxPassword.TextLength == 0))
            {
                label1.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                try
                {
                    connection.Open();
                    String cmd = "SELECT [role] FROM [USERS] WHERE [username] = '" + textBoxUsername.Text + "' AND HASHBYTES ('MD5', '" + textBoxPassword.Text + "') = [password];";
                    SqlCommand query = new SqlCommand(cmd, connection);
                    SqlDataReader reader = query.ExecuteReader();
                    List<String> list = new List<String>();
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                    connection.Close();
                    if (list.Count > 0)
                    {
                        Hide();
                        FormMain formMain = new FormMain(connection, this, Convert.ToInt32(list[0])); ///TODO Add Roles
                        formMain.Show();

                    }
                    else
                    {
                        MessageBox.Show("Введен неверный пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                catch
                {
                    MessageBox.Show("Нет соединения с базой данных", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    Close();
                }
                
            } 
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
