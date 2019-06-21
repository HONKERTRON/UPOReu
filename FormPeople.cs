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
        public SqlCommandBuilder builderPeople;
        public int select = 0;

        public void RefreshWindow()
        {
            dataSetPeople.Clear();
            connection.Open();
            String cmd = "SELECT [idUSERS], [name], [last_name], [patronym], [phone_number], [email] FROM [USERS] WHERE CONCAT([name], [last_name], [patronym], [phone_number], [email]) LIKE '%" + textBoxSearch.Text + "%' ORDER BY [idUSERS] ASC;";
            adapterPeople = new SqlDataAdapter(cmd, connection);
            adapterPeople.Fill(dataSetPeople, "USERS");
            builderPeople = new SqlCommandBuilder(adapterPeople);
            dataGridViewPeople.DataSource = dataSetPeople.Tables["USERS"];
            connection.Close();

            dataGridViewPeople.Columns[0].HeaderText = "Ключ сотрудника";
            dataGridViewPeople.Columns[1].HeaderText = "Имя";
            dataGridViewPeople.Columns[2].HeaderText = "Фамилия";
            dataGridViewPeople.Columns[3].HeaderText = "Отчетсво";
            dataGridViewPeople.Columns[4].HeaderText = "Телефон";
            dataGridViewPeople.Columns[5].HeaderText = "Почта";



            this.dataGridViewPeople.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            this.dataGridViewPeople.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        }

        //mode означает режим, т.е. то, для чего мы создали форму: показать людей или выбрать человека из списка
        public FormPeople(SqlConnection connection, int mode)
        {
            InitializeComponent();
            this.connection = connection;
            //Сохранили режим
            this.select = mode;
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

        private void dataGridViewPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //В зависимости от режима, делаем разные вещи
            if (select > 0)
            {
                //Если выбираем, то просто сохраняем id человека в переменную
                Int32 idPerson = Convert.ToInt32(dataGridViewPeople.Rows[dataGridViewPeople.SelectedCells[0].RowIndex].Cells[0].Value);
                select = idPerson;
                Close();
            }
            else
            {
                //Если не выбираем, то просто открываем новое окошко, где можно подробнее рассмотреть человека
                Int32 idPerson = Convert.ToInt32(dataGridViewPeople.Rows[dataGridViewPeople.SelectedCells[0].RowIndex].Cells[0].Value);
                //Создали новую формочку, передали через конструктор не только соединение, но и id человека, чтобы сразу знать, кого показывать
                FormShowPerson formSP = new FormShowPerson(connection, idPerson);
                formSP.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReg reg = new FormReg(connection);
            reg.Show();
        }

        private void buttonDeletePeople_Click(object sender, EventArgs e)
        {
            dataGridViewPeople.Rows.Remove(dataGridViewPeople.Rows[dataGridViewPeople.SelectedCells[0].RowIndex]);
            adapterPeople.UpdateCommand = builderPeople.GetUpdateCommand();
            adapterPeople.InsertCommand = builderPeople.GetInsertCommand();
            adapterPeople.DeleteCommand = builderPeople.GetDeleteCommand();
            //Коммандбилдер умеет сам генерировать автоматические запросы к БД
            //Сохранили изменения
            dataSetPeople.AcceptChanges();
            //Выполнили автоматические запросы к БД
            adapterPeople.Update(dataSetPeople.Tables["USERS"]);
            Int32 idObject = Convert.ToInt32(dataGridViewPeople.Rows[dataGridViewPeople.SelectedCells[0].RowIndex].Cells[0].Value);
            connection.Open();
            String cmd = "DELETE FROM [USERS] WHERE [idUSERS] = " + idObject.ToString() + ";";
            SqlCommand query_ = new SqlCommand(cmd, connection);
            int res = Convert.ToInt32(query_.ExecuteNonQuery());
            connection.Close();
            RefreshWindow();
        }

        private void dataGridViewPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
