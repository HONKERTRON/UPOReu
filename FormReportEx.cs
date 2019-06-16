using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        // Создаем объект DataAdapter
        public SqlDataAdapter adapterSP;
        // Создаем объект Dataset
        public DataSet dataSetSP = new DataSet();

        public FormReportEx(SqlConnection connection)
        {
            //Инициализация компонентов расположенных на форме
            InitializeComponent();

            this.connection = connection;
            connection.Open();
            String cmd = "SELECT *, -DATEDIFF(day, [EXTINGUSHER].[date_start], [EXTINGUSHER].[date_created]) FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] INNER JOIN [UO] on [UO].[idUO] = [EXTINGUSHER].[idUO] INNER JOIN [USERS] ON [UO].[idUSERS] = [USERS].[idUSERS] ORDER BY DATEDIFF(day, [EXTINGUSHER].[date_created], [EXTINGUSHER].[date_start]) DESC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            // Заполняем Dataset
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            dataGridViewReport.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            connection.Close();

            string[] columnNames = new String[dataGridViewReport.Columns.Count];
            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
            {
                columnNames[0] = dataGridViewReport.Columns[i].Name;
                dataGridViewResult.Columns.Add(columnNames[0], columnNames[0]);
            }

            dateTimePickerAfter.Format = DateTimePickerFormat.Custom;
            dateTimePickerAfter.CustomFormat = "yyyy-M-d";
            dateTimePickerBefore.Format = DateTimePickerFormat.Custom;
            dateTimePickerBefore.CustomFormat = "yyyy-M-d";
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
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            TableContent table = new TableContent("Extingushers");
            for (int i = 0; i < dataGridViewResult.RowCount-1; i++)
            {
                table.AddRow(///TODO CORRECT CELLS
                        new FieldContent("Number", dataGridViewResult.Rows[i].Cells[3].Value.ToString()),
                        new FieldContent("Mark", dataGridViewResult.Rows[i].Cells[6].Value.ToString()),
                        new FieldContent("Concentration", dataGridViewResult.Rows[i].Cells[9].Value.ToString()),
                        new FieldContent("Expired", dataGridViewResult.Rows[i].Cells[dataGridViewResult.ColumnCount-1].Value.ToString())
                        );
            }

            File.Delete(saveFileDialog.FileName);
            File.Copy("InputTemplate.docx", saveFileDialog.FileName);

            var valuesToFill = new Content(
                new FieldContent("Report date", DateTime.Now.ToString()),
                table);

            using (var outputDocument = new TemplateProcessor(saveFileDialog.FileName)
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
        }

        private void dateTimePickerAfter_ValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            String cmd = "SELECT *, -DATEDIFF(day, [EXTINGUSHER].[date_start], [EXTINGUSHER].[date_created]) FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] INNER JOIN [UO] on [UO].[idUO] = [EXTINGUSHER].[idUO] INNER JOIN [USERS] ON [UO].[idUSERS] = [USERS].[idUSERS] WHERE [date_start] > '" + dateTimePickerAfter.Text + "' AND [date_start] < '" + dateTimePickerBefore.Text + "' ORDER BY DATEDIFF(day, [EXTINGUSHER].[date_created], [EXTINGUSHER].[date_start]) DESC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            // Заполняем Dataset
            dataSetSP.Clear();
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            dataGridViewReport.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            connection.Close();
        }

        private void dateTimePickerBefore_ValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            String cmd = "SELECT *, -DATEDIFF(day, [EXTINGUSHER].[date_start], [EXTINGUSHER].[date_created]) FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] INNER JOIN [UO] on [UO].[idUO] = [EXTINGUSHER].[idUO] INNER JOIN [USERS] ON [UO].[idUSERS] = [USERS].[idUSERS] WHERE [date_start] > '" + dateTimePickerAfter.Text + "' AND [date_start] < '" + dateTimePickerBefore.Text + "' ORDER BY DATEDIFF(day, [EXTINGUSHER].[date_created], [EXTINGUSHER].[date_start]) DESC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            // Заполняем Dataset
            dataSetSP.Clear();
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            dataGridViewReport.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            connection.Close();
        }
    }
}
