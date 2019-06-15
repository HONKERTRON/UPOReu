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
    public partial class FormRRTOSZ : Form
    {
        ////public SqlConnection connection;
        public SqlDataAdapter adapterJTT, adapterJD;
        ////public DataSet dataSetJournal = new DataSet();
        public DataSet dataSetJTT = new DataSet();
        ////public DataSet dataSetJD = new DataSet();
        public int id = -1;
        public SqlConnection connection;
        public SqlDataAdapter adapterRRTOSZ;
        public DataSet dataSetRRTOSZ = new DataSet();
        public SqlCommandBuilder builderRRTOSZ;

        public void RefreshWindow(int id, int secondary_id)
        {
            dataSetRRTOSZ.Clear();
            connection.Open();
            adapterRRTOSZ = new SqlDataAdapter("SELECT [idRRTOSZ], [idOBJECT], [date], [type_system], [type_work], [description], [result_state], [result_work], [worker] FROM [RRTOSZ] ORDER BY [idRRTOSZ] ASC", connection);
            builderRRTOSZ = new SqlCommandBuilder(adapterRRTOSZ);
            adapterRRTOSZ.Fill(dataSetRRTOSZ, "RRTOSZ");

            dataGridViewRRTOSZ.DataSource = dataSetRRTOSZ.Tables["RRTOSZ"];
            connection.Close();
            dataGridViewRRTOSZ.Columns[0].ReadOnly = true;
            dataSetRRTOSZ.Clear();
            this.id = id;
            connection.Open();
            adapterRRTOSZ = new SqlDataAdapter("SELECT * FROM [RRTOSZ] WHERE [RRTOSZ].[idOBJECT] = " + id.ToString() + " ORDER BY [idOBJECT] ASC", connection);
            adapterRRTOSZ.Fill(dataSetRRTOSZ, "RRTOSZ");
            dataGridViewRRTOSZ.DataSource = dataSetRRTOSZ.Tables["RRTOSZ"];
            connection.Close();
            dataGridViewRRTOSZ.Columns[0].ReadOnly = true;
            if (secondary_id >= 0)
            {
                dataSetJTT.Clear();
                connection.Open();
                adapterJTT = new SqlDataAdapter("SELECT * FROM [DETAILS] WHERE [DETAILS].[idRRTOSZ] = " + secondary_id.ToString() + " ORDER BY [idRRTOSZ] ASC", connection);
                adapterJTT.Fill(dataSetJTT, "DETAILS");
                dataGridViewDetails.DataSource = dataSetJTT.Tables["DETAILS"];
                connection.Close();
                dataGridViewDetails.Columns[0].ReadOnly = true;
            }
        }

        public FormRRTOSZ(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            builderRRTOSZ = new SqlCommandBuilder(adapterRRTOSZ);
            RefreshWindow(-1, 1);

            //столбцы таблицы
            //dataGridViewUO.Columns[0].HeaderText = "Ключ объекта";
            //dataGridViewUO.Columns[1].HeaderText = "Ключ огнетушиетля";
            //dataGridViewUO.Columns[2].HeaderText = "Дата проверки";
            //dataGridViewUO.Columns[3].HeaderText = "Ключ пользователя";
            //dataGridViewUO.Columns[4].HeaderText = "Apperience";
            //dataGridViewUO.Columns[5].HeaderText = "Масса";
            //dataGridViewUO.Columns[6].HeaderText = "Pressure";
            //dataGridViewUO.Columns[7].HeaderText = "State";
            //dataGridViewUO.Columns[8].HeaderText = "Actions";

            //стиль столбцов
            this.dataGridViewRRTOSZ.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            this.dataGridViewRRTOSZ.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        }

        private void dataGridViewRRTOSZ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 sec_id = Convert.ToInt32(dataGridViewRRTOSZ.Rows[dataGridViewRRTOSZ.SelectedCells[0].RowIndex].Cells[0].Value);
            RefreshWindow(id, sec_id);
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {

        }
    }
}
