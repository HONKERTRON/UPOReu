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
    public partial class FormInsertEx : Form
    {
        SqlConnection connection;
        public FormInsertEx(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO Finish registration
            connection.Open();
            SqlCommand query = new SqlCommand("SELECT [idEXTINGUSHER] FROM [EXTINGUSHER] WHERE [number] = '" + textBox1.Text + "';", connection);
            SqlDataReader reader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            connection.Close();
            // if ((comboBox1.TextLength == 0) || (textBoxAdres.TextLength == 0))
            // {
            //    labelInfoInsertObject.Text = "Одно из обязательных полей не заполнено.";
            // }
            //  else
            // {
            //     if (list.Count > 0)
            // {
            // labelInfoInsertObject.Text = "Пользователь с таким логином уже существует.";
            // }
            // else
            {
                connection.Open();
                String cmd = "INSERT INTO [EXTINGUSHER]([idMANUFACTURER], [number], [date_start], [place], [mark], [factory_number], [date_created], [concentration], [type_ex]) VALUES " +
                    "('" + comboBox1.FormatString + "', '" + textBox1.Text + "', '" + textBox22.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + maskedTextBox2.Text + "', '" + textBox5.Text + "', '" + comboBox2.Text + "');";
                SqlCommand query_ = new SqlCommand(cmd, connection);
                label10.Text = "Изменено " + Convert.ToString(query_.ExecuteNonQuery()) + " записей.";
                connection.Close();
            }
        }
        public FormInsertEx()
        {
            InitializeComponent();
        }

        private void FormInsertEx_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuDataSet1.TYPE_EX". При необходимости она может быть перемещена или удалена.
            this.tYPE_EXTableAdapter.Fill(this.uPOReuDataSet1.TYPE_EX);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuDataSet.MANUFACTURER". При необходимости она может быть перемещена или удалена.
            this.mANUFACTURERTableAdapter.Fill(this.uPOReuDataSet.MANUFACTURER);

        }
    }


   
      

       

       
    }
//}
