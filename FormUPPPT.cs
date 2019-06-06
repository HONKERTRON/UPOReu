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

        public FormUPPPT(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            dataSetUPPPT.Clear();
            connection.Open();
            adapterUPPPT = new SqlDataAdapter("SELECT * FROM [UPPPT] WHERE [UPPPT].[idOBJECT] = " + id.ToString() + " ORDER BY [idOBJECT] ASC", connection);
            adapterUPPPT.Fill(dataSetUPPPT, "UPPPT");
            dataGridViewUPPPT.DataSource = dataSetUPPPT.Tables["UPPPT"];
            connection.Close();
        }

        private void FormUPPPT_Load(object sender, EventArgs e)
        {

        }
    }
}
