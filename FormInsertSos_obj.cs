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
    public partial class FormInsertSos_obj : Form
    {
        public SqlConnection connection;
        int objectid = -1;

        public FormInsertSos_obj(SqlConnection connection, int idObject)
        {
            InitializeComponent();
            this.connection = connection;
            this.objectid = idObject; 
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-M-d";
        }

        private void FormInsertSos_obj_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertSOj_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand query = new SqlCommand("INSERT INTO [OBJECT_STATE] ([idOBJECT], [description], [date]) VALUES ("+objectid.ToString()+", '"+textBoxSOjdes.Text.ToString()+"', '"+dateTimePicker.Text.ToString()+"');", connection);
            Int32 res = query.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
