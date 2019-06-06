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
        public SqlConnection connection;
        public SqlDataAdapter adapterJournal, adapterJTT, adapterJD;
        public DataSet dataSetJournal = new DataSet();
        public DataSet dataSetJTT = new DataSet();
        public DataSet dataSetJD = new DataSet();
        public int id = -1;

        public void RefreshWindow(int id, int secondary_id)
        {
            dataSetJournal.Clear();
            this.id = id;
            connection.Open();
            adapterJournal = new SqlDataAdapter("SELECT * FROM [RRTOSZ] WHERE [RRTOSZ].[idOBJECT] = " + id.ToString() + " ORDER BY [idOBJECT] ASC", connection);
            adapterJournal.Fill(dataSetJournal, "RRTOSZ");
            dataGridViewRRTOSZ.DataSource = dataSetJournal.Tables["RRTOSZ"];
            connection.Close();
            if (secondary_id >= 0)
            {
                dataSetJTT.Clear();
                connection.Open();
                adapterJTT = new SqlDataAdapter("SELECT * FROM [DETAILS] WHERE [DETAILS].[idRRTOSZ] = " + secondary_id.ToString() + " ORDER BY [idRRTOSZ] ASC", connection);
                adapterJTT.Fill(dataSetJTT, "DETAILS");
                dataGridViewDetails.DataSource = dataSetJTT.Tables["DETAILS"];
                connection.Close();
            }
        }

        public FormRRTOSZ(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            RefreshWindow(id, -1);
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
