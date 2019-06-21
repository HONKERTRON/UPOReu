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
using System.Data.Sql;

namespace UPOReu
{
    public partial class FormAuth : Form
    {
        SqlConnection connection;
        DataSet dataSet = new DataSet();

        public FormAuth()
        {
            InitializeComponent();
            //Создаем енумератор, который будет искать активные соединения
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //Создаем таблицу, в которой будут записаны активные соединения с MSSQL
            DataTable table = instance.GetDataSources();
            //Заполняем комбобокс соединениями
            foreach (DataRow row in table.Rows)
            {
                if (row["InstanceName"].ToString() == "")
                    serverComboBox.Items.Add(row["ServerName"]);
                else
                    serverComboBox.Items.Add(row["ServerName"] + "\\" + row["InstanceName"]);
            }
            //Текущий статус соединения
            statusStrip1.Items[1].Text = "Не установлено.";
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            //eO3VRUuP
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            //Проверка на обязательные поля
            if ((textBoxUsername.TextLength == 0) || (textBoxPassword.TextLength == 0))
            {
                label1.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                //Поскольку, мы не уверены, есть ли соединение с БД, делаем try
                try
                {
                    //Открываем соединение
                    connection.Open();
                    //Пытаемся получить роль человека, у которого логин и пароль совпадают с указанными
                    String cmd = "SELECT [role] FROM [USERS] WHERE [username] = '" + textBoxUsername.Text + "' AND HASHBYTES ('MD5', '" + textBoxPassword.Text + "') = [password];";
                    //Создаем запрос
                    SqlCommand query = new SqlCommand(cmd, connection);
                    //Получаем результат запроса
                    SqlDataReader reader = query.ExecuteReader();
                    List<String> list = new List<String>();
                    //Заполняем список результатами
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                    //Закрываем соединение
                    connection.Close();
                    //Если мы нашли хотя бы 1 человека (успешно залогинились)
                    if (list.Count > 0)
                    {
                        //Получаем роль в виде числа
                        int role = Convert.ToInt32(list[0]);
                        //Прячем формочку
                        Hide();
                        //Делаем что-то в зависимости от роли
                        switch(role)
                        {
                            //роль 10, суперадмин
                            case 10:
                                //Создаем главную формочку, передавая туда соединение, указатель на текущую форму и роль
                                FormMain formMain = new FormMain(connection, this, role); ///TODO Add Roles
                                //Показываем созданную форму
                                formMain.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введен неверный пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                catch
                {
                    MessageBox.Show("Нет соединения с базой данных", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                
            } 
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Создаем соединение, на основании выбранной строчки комбобокса
            connection = new SqlConnection(@"Data Source=" + serverComboBox.SelectedItem.ToString() + ";Initial Catalog=UPOReu;Integrated Security=True");
            try
            {
                //Проверяем соединение
                connection.Open();
                connection.Close();
                ///TODO заполнить статус страйп
                statusStrip1.Items[1].Text = "Активно.";
            }
            catch
            {
                statusStrip1.Items[1].Text = "Не активно.";
            }
        }
    }
}
