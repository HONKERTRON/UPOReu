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
    public partial class FormObjects : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterObject, adapterState;
        public DataSet dataSetObject = new DataSet();
        public DataSet dataSetState = new DataSet();
        public SqlCommandBuilder builderObjects, builderState;

        public void RefreshWindow(int secondary_id)
        {
            dataSetObject.Clear();
            connection.Open();
            adapterObject = new SqlDataAdapter("SELECT [ID_PALAS], [NAM_PALAS], [ADREAS_PALAS] FROM [PALAS] ORDER BY [ID_PALAS] ASC", connection);
            builderObjects = new SqlCommandBuilder(adapterObject);
            adapterObject.Fill(dataSetObject, "PALAS");
            dataGridViewObjects.DataSource = dataSetObject.Tables["PALAS"];
            connection.Close();
            if(secondary_id >= 0)
            {
                dataSetState.Clear();
                connection.Open();
                adapterState = new SqlDataAdapter("SELECT [ID_SOS_PALASE], [NAM_SOS_PALASE], [OP_SOS_PALASE] FROM [SOS_PALASE] ORDER BY [ID_SOS_PALASE] ASC", connection);
                builderState = new SqlCommandBuilder(adapterState);
                adapterState.Fill(dataSetState, "SOS_PALASE");
                dataGridViewState.DataSource = dataSetState.Tables["SOS_PALASE"];
                connection.Close();
            }
        }

        public FormObjects(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            builderObjects = new SqlCommandBuilder(adapterObject);
            RefreshWindow(-1); 
        }

        private void ExtingusherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);

            FormExtingusher formEx = new FormExtingusher(connection, idObject);
            formEx.Show();
        }

        private void PersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idPerson = -1;
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);
            connection.Open();
            String cmd = "SELECT [ID_OTVFACE] FROM [PALAS] WHERE [ID_PALAS] = "+ idObject.ToString() +" ;";
            SqlCommand query_ = new SqlCommand(cmd, connection);
            idPerson = Convert.ToInt32(query_.ExecuteScalar());
            connection.Close();

            FormShowPerson formSP = new FormShowPerson(connection, idPerson);
            formSP.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adapterObject.UpdateCommand = builderObjects.GetUpdateCommand();
            adapterObject.InsertCommand = builderObjects.GetInsertCommand();
            adapterObject.DeleteCommand = builderObjects.GetDeleteCommand();

            adapterObject.Update(dataSetObject.Tables["PALAS"]);
            dataSetObject.AcceptChanges();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);
            RefreshWindow(idObject);
        }
    }
}
