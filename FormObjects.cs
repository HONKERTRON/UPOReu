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
        public int selid = -1;

        public void RefreshWindow(int secondary_id)
        {
            dataSetObject.Clear();
            connection.Open();
            adapterObject = new SqlDataAdapter("SELECT [idOBJECT], [name_object], [adress] FROM [OBJECTS] ORDER BY [idOBJECT] ASC", connection);
            builderObjects = new SqlCommandBuilder(adapterObject);
            adapterObject.Fill(dataSetObject, "OBJECTS");
            dataGridViewObjects.DataSource = dataSetObject.Tables["OBJECTS"];
            connection.Close();
            dataGridViewObjects.Columns[0].ReadOnly = true;
            if (secondary_id >= 0)
            {
                dataSetState.Clear();
                connection.Open();
                adapterState = new SqlDataAdapter("SELECT [OBJECT_STATEid], [date], [description] FROM [OBJECT_STATE] WHERE [idOBJECT] = " + secondary_id.ToString() + " ORDER BY [OBJECT_STATEid] ASC", connection);
                builderState = new SqlCommandBuilder(adapterState);
                adapterState.Fill(dataSetState, "OBJECT_STATE");
                dataGridViewState.DataSource = dataSetState.Tables["OBJECT_STATE"];
                connection.Close();
                dataGridViewState.Columns[0].ReadOnly = true;
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
            String cmd = "SELECT [idUSERS] FROM [OBJECTS] WHERE [idOBJECT] = " + idObject.ToString() +";";
            SqlCommand query_ = new SqlCommand(cmd, connection);
            idPerson = Convert.ToInt32(query_.ExecuteScalar());
            connection.Close();

            FormShowPerson formSP = new FormShowPerson(connection, idPerson);
            formSP.Show();
        }

        private void dataGridViewObjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewObjects.SelectedCells[0].RowIndex < dataGridViewObjects.RowCount-1)
            {
                Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);
                RefreshWindow(idObject);
            }
        }

        private void FormObjects_Load(object sender, EventArgs e)
        {

        }

        private void UOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);

            FormUO formUO = new FormUO(connection, idObject);
            formUO.Show();
        }

        private void PPSPPZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);

            FormPPSPPZ formPPSPPZ = new FormPPSPPZ(connection, idObject);
            formPPSPPZ.Show();
        }

        private void RRTOSZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);

            FormRRTOSZ formRRTOSZ = new FormRRTOSZ(connection, idObject);
            formRRTOSZ.Show();
        }

        private void UPPPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);

            FormUPPPT formUPPPT = new FormUPPPT(connection, idObject);
            formUPPPT.Show();
        }

        private void ChosePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 idObject = Convert.ToInt32(dataGridViewObjects.Rows[dataGridViewObjects.SelectedCells[0].RowIndex].Cells[0].Value);
            FormPeople formPeople = new FormPeople(connection, 1);
            formPeople.dataGridViewPeople.CellDoubleClick += (senderObj, eargs) =>
            {
                this.selid = formPeople.select;
                if (selid > 0)
                {
                    connection.Open();
                    String cmd = "UPDATE [OBJECTS] SET [idUSERS] = " + selid.ToString() + " WHERE [idOBJECT] = " + idObject.ToString() + " ;";
                    SqlCommand query_ = new SqlCommand(cmd, connection);
                    int res = Convert.ToInt32(query_.ExecuteScalar());
                    connection.Close();
                }
                formPeople.Close();
            };
            formPeople.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adapterObject.UpdateCommand = builderObjects.GetUpdateCommand();
            adapterObject.InsertCommand = builderObjects.GetInsertCommand();
            adapterObject.DeleteCommand = builderObjects.GetDeleteCommand();

            adapterObject.Update(dataSetObject.Tables["OBJECTS"]);
            dataSetObject.AcceptChanges();
            RefreshWindow(-1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
