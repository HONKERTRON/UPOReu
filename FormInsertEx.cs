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
        public SqlConnection connection;
        public List<Int32> listkeystype = new List<Int32>();
        public List<Int32> listkeysman = new List<Int32>();
        public int idUO = -1;

        public FormInsertEx(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy-M-d";
            dateTimePickerCreated.Format = DateTimePickerFormat.Custom;
            dateTimePickerCreated.CustomFormat = "yyyy-M-d";

            connection.Open();
            SqlCommand query = new SqlCommand("SELECT [type_ex], [description] FROM [TYPE_EX];", connection);
            SqlDataReader reader = query.ExecuteReader();
            
            while (reader.Read())
            {
                listkeystype.Add(Convert.ToInt32(reader[0]));
                    comboBox2.Items.Add(reader[1].ToString());
            }
            connection.Close();

            connection.Open();
            query = new SqlCommand("SELECT [idMANUFACTURER], [name] FROM [MANUFACTURER];", connection);
            reader = query.ExecuteReader();
            
            while (reader.Read())
            {
                listkeysman.Add(Convert.ToInt32(reader[0]));
                comboBox1.Items.Add(reader[1].ToString());
            }
            connection.Close();
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
            if(idUO > 0)
            {
                connection.Open();
                String cmd = "INSERT INTO [EXTINGUSHER]([idMANUFACTURER], [idUO], [number], [date_start], [place], [mark], [factory_number], [date_created], [concentration], [type_ex]) VALUES " +
                    "('" + listkeysman[comboBox2.SelectedIndex] + "', " + idUO.ToString() + ", '" + textBox1.Text + "', '" + dateTimePickerStart.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePickerCreated.Text + "', '" + textBox5.Text + "', '" + listkeystype[comboBox2.SelectedIndex] + "');";
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
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuDataSet1.TYPE_EX". При необходимости она может быть перемещена или удалена.
            //this.tYPE_EXTableAdapter.Fill(this.uPOReuDataSet1.TYPE_EX);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuDataSet.MANUFACTURER". При необходимости она может быть перемещена или удалена.
            //this.mANUFACTURERTableAdapter.Fill(this.uPOReuDataSet.MANUFACTURER);

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FormUO formUO = new FormUO(connection, -1, 1);
            formUO.dataGridViewUO.CellContentClick += (senderObj, eargs) =>
            {
                this.idUO = Convert.ToInt32(formUO.dataGridViewUO.Rows[formUO.dataGridViewUO.SelectedCells[0].RowIndex].Cells[0].Value);
                formUO.Close();
            };
            formUO.Show();
        }
    }
    }
//}
