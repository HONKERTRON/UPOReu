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
using TemplateEngine.Docx;

namespace UPOReu
{
    public partial class FormReportEx : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterSP;
        public DataSet dataSetSP = new DataSet();

        public FormReportEx(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            connection.Open();
            String cmd = "SELECT * FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] ORDER BY DATEDIFF(day, [EXTINGUSHER].[date_start], [EXTINGUSHER].[date_created]) ASC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            dataGridViewReport.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            connection.Close();

            string[] columnNames = new String[dataGridViewReport.Columns.Count];
            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
            {
                columnNames[0] = dataGridViewReport.Columns[i].Name;
                dataGridViewResult.Columns.Add(columnNames[0], columnNames[0]);
            }
        }

        private void FormReportEx_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 rowIndex = dataGridViewReport.SelectedCells[0].OwningRow.Index;
            DataGridViewRow row = (DataGridViewRow)dataGridViewReport.SelectedCells[0].OwningRow.Clone();

            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
            {
                row.Cells[i].Value = dataGridViewReport.Rows[rowIndex].Cells[i].Value;
            }
            dataGridViewResult.Rows.Add(row);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TableContent table = new TableContent("Extingushers");
            for (int i = 0; i < dataGridViewResult.RowCount; i++)
            {
                table.AddRow(///TODO CORRECT CELLS
                        new FieldContent("idOJECT", dataGridViewResult.Rows[i].Cells[0].ToString()),
                        new FieldContent("idEXTINGUSHER", dataGridViewResult.Rows[i].Cells[1].ToString()));
            }
               
            var valuesToFill = new Content(
                new FieldContent("Report date", DateTime.Now.Date.ToString()),
                table
                );

            using (var outputDocument = new TemplateProcessor("report.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
        }
    }
}
