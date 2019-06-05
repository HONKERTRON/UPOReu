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
    public partial class FormJRRTOSZ : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterJournal, adapterJTT, adapterJD;
        public DataSet dataSetJournal = new DataSet();
        public DataSet dataSetJTT = new DataSet();
        public DataSet dataSetJD = new DataSet();

        public void RefreshWindow(int secondary_id)
        {
            dataSetJournal.Clear();
            connection.Open();
            adapterJournal = new SqlDataAdapter("SELECT [ID_JRRTOSZ], [DATE_JRRTOSZ], [OP_RABOT], [NAM_TYPE_SAVE_SYS] FROM [JRRTOSZ] INNER JOIN [TYPE_SAVE_SYS] ON [JRRTOSZ].[ID_TYPE_SAVE_SYS] = [TYPE_SAVE_SYS].[ID_TYPE_SAVE_SYS] ORDER BY [ID_PALAS] ASC", connection);
            adapterJournal.Fill(dataSetJournal, "JRRTOSZ");
            dataGridViewRRTOSZ.DataSource = dataSetJournal.Tables["JRRTOSZ"];
            connection.Close();
            if (secondary_id >= 0)
            {
                dataSetJTT.Clear();
                connection.Open();
                adapterJTT = new SqlDataAdapter("SELECT [ID_SOS_PALASE], [NAM_SOS_PALASE], [OP_SOS_PALASE] FROM [SOS_PALASE] ORDER BY [ID_SOS_PALASE] ASC", connection);
                adapterJTT.Fill(dataSetJTT, "SOS_PALASE");
                dataGridViewDetails.DataSource = dataSetJTT.Tables["SOS_PALASE"];
                connection.Close();
            }
        }

        public FormJRRTOSZ(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            RefreshWindow(-1);
        }

        private void dataGridViewRRTOSZ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormJournal_Load(object sender, EventArgs e)
        {

        }
    }
}
