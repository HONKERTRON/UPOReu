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

            //Сохраняем соединение, полученное через конструктор в переменную
            this.connection = connection;
            //Открываем соединение
            connection.Open();
            //Задаем запрос, в который помимо данных из таблицы получим разницу между датами в днях
            String cmd = "SELECT *, -DATEDIFF(day, [EXTINGUSHER].[date_start], [EXTINGUSHER].[date_created]) FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] INNER JOIN [UO] on [UO].[idUO] = [EXTINGUSHER].[idUO] INNER JOIN [USERS] ON [UO].[idUSERS] = [USERS].[idUSERS] ORDER BY DATEDIFF(day, [EXTINGUSHER].[date_created], [EXTINGUSHER].[date_start]) DESC;";
            adapterSP = new SqlDataAdapter(cmd, connection);
            // Заполняем Dataset
            adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            //Выводим содержимое таблицы в датагридвью
            dataGridViewReport.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            //Закрываем соединение
            connection.Close();

            //Копируем заголовки в соседний датагридвью, чтобы заголовки были одинаковыми
            string[] columnNames = new String[dataGridViewReport.Columns.Count];
            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
            {
                columnNames[0] = dataGridViewReport.Columns[i].Name;
                dataGridViewResult.Columns.Add(columnNames[0], columnNames[0]);
            }
            //Настраиваем форматы хранения даты в датапикере
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
            //Получаем номер выбранной строчки
            Int32 rowIndex = dataGridViewReport.SelectedCells[0].OwningRow.Index;
            //Копируем строчку
            DataGridViewRow row = (DataGridViewRow)dataGridViewReport.SelectedCells[0].OwningRow.Clone();

            //Копируем содержимое выбранной строчки в новую
            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
            {
                row.Cells[i].Value = dataGridViewReport.Rows[rowIndex].Cells[i].Value;
            }
            //Добавляем строчку в соседний датагридвью
            dataGridViewResult.Rows.Add(row);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Открываем диалог сохранения файла
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            //Создаем объект, отвечающий за таблицы в отчете
            TableContent table = new TableContent("Extingushers");
            for (int i = 0; i < dataGridViewResult.RowCount-1; i++)
            {
                //Заполняем эту таблицу, создавая объекты, отвечающие за метки в отчете
                table.AddRow(///TODO CORRECT CELLS
                        new FieldContent("Number", dataGridViewResult.Rows[i].Cells[3].Value.ToString()),
                        new FieldContent("Mark", dataGridViewResult.Rows[i].Cells[6].Value.ToString()),
                        new FieldContent("Concentration", dataGridViewResult.Rows[i].Cells[9].Value.ToString()),
                        new FieldContent("Expired", dataGridViewResult.Rows[i].Cells[dataGridViewResult.ColumnCount-1].Value.ToString())
                        );
            }
            //Удаляем старый файл, если он есть
            File.Delete(saveFileDialog.FileName);
            //Копируем на его место шаблон
            File.Copy("InputTemplate.docx", saveFileDialog.FileName);

            //Обозначем, какими данными заполним шаблон
            var valuesToFill = new Content(
                new FieldContent("Report date", DateTime.Now.ToString()),
                table);
            //Заполняем шаблон, убирая метки
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
            //Запрос, учитывающий выбранный интервал
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
            //Примерно то же самое, что и выше
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
