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
    public partial class FormPeople : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterPeople;
        public DataSet dataSetPeople = new DataSet();

        public void RefreshWindow()
        {
            dataSetPeople.Clear();
            connection.Open();
            String cmd = "SELECT [idUSERS], [name], [last_name], [patronym], [phone_number], [email] FROM [USERS] WHERE [name] LIKE '%" + textBoxName.Text + "%' AND [last_name] LIKE '%" + textBoxLastname.Text + "%' ORDER BY [idUSERS] ASC;";
            adapterPeople = new SqlDataAdapter(cmd, connection);
            adapterPeople.Fill(dataSetPeople, "USERS");
            dataGridViewPeople.DataSource = dataSetPeople.Tables["USERS"];
            connection.Close();
        }

        public FormPeople(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            RefreshWindow();
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void textBoxLastname_TextChanged(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void dataGridViewPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idPerson = Convert.ToInt32(dataGridViewPeople.Rows[dataGridViewPeople.SelectedCells[0].RowIndex].Cells[0].Value);
            FormShowPerson formSP = new FormShowPerson(connection, idPerson);
            formSP.Show();
        }
    }
}
