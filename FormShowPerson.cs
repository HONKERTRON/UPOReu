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
    public partial class FormShowPerson : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterSP;
        public DataSet dataSetSP = new DataSet();

        public FormShowPerson(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            dataSetSP.Clear();
            connection.Open();
            String cmd = "SELECT [name], [last_name], [patronym], [phone_number], [email] FROM [USERS] WHERE [idUSERS] ='" + id.ToString() +"' ORDER BY [idUSERS] ASC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            adapterSP.Fill(dataSetSP, "USERS");
            dataGridView1.DataSource = dataSetSP.Tables["USERS"];
            connection.Close();
        }

        private void FormShowPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
