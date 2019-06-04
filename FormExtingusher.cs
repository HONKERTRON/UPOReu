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
        public SqlDataAdapter adapterSP;
        public DataSet dataSetSP = new DataSet();

        public FormExtingusher(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;

            connection.Open();
            adapterSP = new SqlDataAdapter("SELECT [ID_OGN], [NUM_OGN], [DATE_VV_EX], [ZAVOD_NUM], [DATE_BORN], [NAM_MARK_OGN] FROM [OGN] INNER JOIN [MARK_OGN] ON [OGN].[ID_MARK_OGN] = [MARK_OGN].[ID_MARK_OGN] WHERE [ID_PALAS] = " + id + " ORDER BY [ID_OGN] ASC", connection);
            adapterSP.Fill(dataSetSP, "OGN");
            dataGridViewEx.DataSource = dataSetSP.Tables["OGN"];
            connection.Close();
        }

        private void FormExtingusher_Load(object sender, EventArgs e)
        {

        }
    }
}
