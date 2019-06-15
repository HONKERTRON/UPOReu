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
    public partial class FormInsertObject : Form
    {
        SqlConnection connection;
        public FormInsertObject(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertObject_Click(object sender, EventArgs e)
        {
            //TODO Finish registration
            connection.Open();
            SqlCommand query = new SqlCommand("SELECT [idOBJECT] FROM [OBJECTS] WHERE [name_object] = '" + textBoxNameObject.Text + "';", connection);
            SqlDataReader reader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            connection.Close();
            if ((textBoxNameObject.TextLength == 0) || (textBoxAdres.TextLength == 0))
            {
                labelInfoInsertObject.Text = "Одно из обязательных полей не заполнено.";
            }
            else
            {
                if (list.Count > 0)
                {
                    labelInfoInsertObject.Text = "Пользователь с таким логином уже существует.";
                }
                else
                {
                    connection.Open();
                    String cmd = "INSERT INTO [OBJECTS]([name_object], [adress]) VALUES " +
                        "('" + textBoxNameObject.Text + "', '" + textBoxAdres.Text + "');";
                    SqlCommand query_ = new SqlCommand(cmd, connection);
                    labelInfoInsertObject.Text = "Изменено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertSOj_Click(object sender, EventArgs e)
        {
            //    //TODO Finish registration
            //    connection.Open();
            //    SqlCommand query = new SqlCommand("SELECT [OBJECT_STATEid] FROM [OBJECT_STATE] WHERE [date] = '" + textBoxDateSOj.Text + "';", connection);
            //    SqlDataReader reader = query.ExecuteReader();
            //    List<String> list = new List<String>();
            //    while (reader.Read())
            //    {
            //        list.Add(reader[0].ToString());
            //    }
            //    connection.Close();
            //    if ((textBoxDateSOj.TextLength == 0) || (textBoxSOjdes.TextLength == 0))
            //    {
            //        labelInfoInsertObject.Text = "Одно из обязательных полей не заполнено.";
            //    }
            //    else
            //    {
            //        if (list.Count > 0)
            //        {
            //            label1.Text = "Пользователь с таким логином уже существует.";
            //        }
            //        else
            //        {
            //            connection.Open();
            //            String cmd = "INSERT INTO [OBJECT_STATE]([date], [description]) VALUES " +
            //                "('" + textBoxDateSOj.Text + "', '" + textBoxSOjdes.Text + "');";
            //            SqlCommand query_ = new SqlCommand(cmd, connection);
            //            label1.Text = "Изменено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
            //            connection.Close();
            //        }
            //    }
            //}
        }

    }
}

