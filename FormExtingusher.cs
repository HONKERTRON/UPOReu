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
            String cmd = "SELECT * FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] WHERE [EXTINGUSHER].[idEXTINGUSHER] = " + id.ToString() + ";";
            adapterSP = new SqlDataAdapter(cmd, connection);
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            dataGridViewEx.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            connection.Close();
        }

        private void FormExtingusher_Load(object sender, EventArgs e)
        {

        }
    }
}
