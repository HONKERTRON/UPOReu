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
            adapterSP = new SqlDataAdapter("SELECT [ID_OTVFACE], [NAM_OTVFACE], [FAM_OTVFACE], [OT_OTVFACE], [MAIL_OTVFACE], [NUM_OTVFACE] FROM [OTVFACE] WHERE [ID_OTVFACE] = " + id.ToString() + " ORDER BY [ID_OTVFACE] ASC;", connection);
            adapterSP.Fill(dataSetSP, "OTVFACE");
            dataGridView1.DataSource = dataSetSP.Tables["OTVFACE"];
            connection.Close();
        }

        private void FormShowPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
