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
    public partial class FormUPPPT : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterUPPPT;
        public DataSet dataSetUPPPT = new DataSet();
        public SqlCommandBuilder builderUPPPT;


        public void RefreshWindow(int secondary_id)
        {
            dataSetUPPPT.Clear();
            connection.Open();
            adapterUPPPT = new SqlDataAdapter("SELECT [idUPPPT], [idOBJECT], [date], [person], [topic], [place], [grade] FROM [UPPPT] ORDER BY [idUPPPT] ASC", connection);
            builderUPPPT = new SqlCommandBuilder(adapterUPPPT);
            adapterUPPPT.Fill(dataSetUPPPT, "UPPPT");

            dataGridViewUPPPT.DataSource = dataSetUPPPT.Tables["UPPPT"];
            connection.Close();
            dataGridViewUPPPT.Columns[0].ReadOnly = true;
        }


        public FormUPPPT(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            builderUPPPT = new SqlCommandBuilder(adapterUPPPT);
            RefreshWindow(-1);

            //столбцы таблицы
            dataGridViewUPPPT.Columns[0].HeaderText = "Ключ объекта";
            dataGridViewUPPPT.Columns[1].HeaderText = "Ключ огнетушиетля";
            dataGridViewUPPPT.Columns[2].HeaderText = "Дата проверки";
            dataGridViewUPPPT.Columns[3].HeaderText = "Ключ пользователя";
            dataGridViewUPPPT.Columns[4].HeaderText = "Apperience";
            dataGridViewUPPPT.Columns[5].HeaderText = "Масса";
            dataGridViewUPPPT.Columns[6].HeaderText = "Pressure";
            

            //стиль столбцов
            this.dataGridViewUPPPT.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            this.dataGridViewUPPPT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        }

        private void FormUPPPT_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUPPPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
