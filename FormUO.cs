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
    public partial class FormUO : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterUO;
        public DataSet dataSetUO = new DataSet();

        public FormUO(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            dataSetUO.Clear();
            connection.Open();
            adapterUO = new SqlDataAdapter("SELECT * FROM [UO] WHERE [UO].[idOBJECT] = " + id.ToString() + " ORDER BY [idOBJECT] ASC", connection);
            adapterUO.Fill(dataSetUO, "UO");
            dataGridViewUO.DataSource = dataSetUO.Tables["UO"];
            connection.Close();
            dataGridViewUO.Columns[0].ReadOnly = true;
        }

        private void dataGridViewUO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewUO.Rows[dataGridViewUO.SelectedCells[0].RowIndex].Cells[0].Value);

            FormExtingusher formEx = new FormExtingusher(connection, idObject);
            formEx.Show();
        }

        private void FormUO_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
