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
    public partial class FormExtingusher : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterEx, adapterSP;
        public DataSet dataSetEx = new DataSet();
        public DataSet dataSetSP = new DataSet();
        public SqlCommandBuilder builderEx;


        public void RefreshWindow(int secondary_id)
        {
            dataSetEx.Clear();
            connection.Open();
            adapterEx = new SqlDataAdapter("SELECT [idEXTINGUSHER], [idUO], [idMANUFACTURER], [number], [date_start], [place], [mark], [factory_number], [date_created], [concentration], [type_ex] FROM [EXTINGUSHER] ORDER BY [idEXTINGUSHER] ASC", connection);
            builderEx = new SqlCommandBuilder(adapterEx);
            adapterEx.Fill(dataSetEx, "EXTINGUSHER");

            

            dataGridViewEx.DataSource = dataSetEx.Tables["EXTINGUSHER"];
            connection.Close();
            dataGridViewEx.Columns[0].ReadOnly = true;
        }

        public FormExtingusher(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            builderEx = new SqlCommandBuilder(adapterEx);
            RefreshWindow(-1);

            //connection.Open();
            //String cmd = "SELECT * FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] WHERE [EXTINGUSHER].[idEXTINGUSHER] = " + id.ToString() + ";";
            //adapterSP = new SqlDataAdapter(cmd, connection);
            //adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            //dataGridViewEx.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            //connection.Close();

            //столбцы таблицы
            dataGridViewEx.Columns[0].HeaderText = "Ключ огнетушителя";
            dataGridViewEx.Columns[1].HeaderText = "Ключ журнала";
            dataGridViewEx.Columns[2].HeaderText = "Ключ изготовителя изготовителя";
            dataGridViewEx.Columns[3].HeaderText = "Заводской номер";
            dataGridViewEx.Columns[4].HeaderText = "Дата начала эксплуатации";
            dataGridViewEx.Columns[5].HeaderText = "Место установки";
            dataGridViewEx.Columns[6].HeaderText = "Название";
            dataGridViewEx.Columns[7].HeaderText = "Заводской номер";
            dataGridViewEx.Columns[8].HeaderText = "Тип тушения";
            dataGridViewEx.Columns[9].HeaderText = "Концентрация вещества";
            dataGridViewEx.Columns[10].HeaderText = "Что-то еще";
            //стиль столбцов
            this.dataGridViewEx.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            this.dataGridViewEx.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        }

       

       // private void FormExtingusher_Load(object sender, EventArgs e)
       // {
            //InitializeComponent();
            //this.connection = connection;
            //builderUO = new SqlCommandBuilder(adapterUO);
            //RefreshWindow(-1);

            //столбцы таблицы
            //dataGridViewEx.Columns[0].HeaderText = "1";
            //dataGridViewEx.Columns[1].HeaderText = "2";
            //dataGridViewEx.Columns[2].HeaderText = "3";
            //dataGridViewEx.Columns[3].HeaderText = "4";
            //dataGridViewEx.Columns[4].HeaderText = "5";
            //dataGridViewEx.Columns[5].HeaderText = "6";
            //dataGridViewEx.Columns[6].HeaderText = "7";
            //dataGridViewEx.Columns[7].HeaderText = "8";
            

            //стиль столбцов
            //this.dataGridViewEx.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            //this.dataGridViewEx.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        //}
    }
}
