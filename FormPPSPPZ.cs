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
    public partial class FormPPSPPZ : Form
    {
        public SqlConnection connection;
        public DataSet dataSetPPSPPZ = new DataSet();
        public SqlDataAdapter adapterPPSPPZ;

        public FormPPSPPZ(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            dataSetPPSPPZ.Clear();
            connection.Open();
            adapterPPSPPZ = new SqlDataAdapter("SELECT * FROM [PPSPPZ] WHERE [PPSPPZ].[idOBJECT] = " + id.ToString() + " ORDER BY [idOBJECT] ASC", connection);
            adapterPPSPPZ.Fill(dataSetPPSPPZ, "PPSPPZ");
            dataGridViewPPSPPZ.DataSource = dataSetPPSPPZ.Tables["PPSPPZ"];
            connection.Close();
            dataGridViewPPSPPZ.Columns[0].ReadOnly = true;
        }

        private void FormPPSPPZ_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPPSPPZ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
