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
    public partial class FormUO : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter adapterUO, adapterSP;
        public DataSet dataSetUO = new DataSet();
        public DataSet dataSetSP= new DataSet();
        public SqlCommandBuilder builderUO;

        public void RefreshWindow(int secondary_id)
        {
            dataSetUO.Clear();
            connection.Open();
            adapterUO = new SqlDataAdapter("SELECT [idUO], [idOBJECT], [date], [UO].[idUSERS], [apperience], [mass], [pressure], [state], [actions], [name], [last_name], [patronym] FROM [UO] INNER JOIN [USERS] ON [UO].[idUSERS] = [USERS].[idUSERS] ORDER BY [idUO] ASC", connection);
            builderUO = new SqlCommandBuilder(adapterUO);
            adapterUO.Fill(dataSetUO, "UO");

            //connection.Open();
            //String cmd = "SELECT * FROM [EXTINGUSHER] INNER JOIN [TYPE_EX] ON [EXTINGUSHER].[type_ex] = [TYPE_EX].[type_ex] INNER JOIN [MANUFACTURER] ON [EXTINGUSHER].[idMANUFACTURER] = [MANUFACTURER].[idMANUFACTURER] WHERE [EXTINGUSHER].[idEXTINGUSHER] = " + id.ToString() + ";";
            //adapterUO = new SqlDataAdapter(cmd, connection);
            //adapterSP.Fill(dataSetSP, "EXTINGUSHER");
            //dataGridViewEx.DataSource = dataSetSP.Tables["EXTINGUSHER"];
            //connection.Close();


            //SELECT p.id, p.name `Имя сотрудника`, ps.id `pos.id`, ps.name `Должность
            //FROM `persons` p
            //INNER JOIN `positions` ps ON ps.id = p.post_id;


            dataGridViewUO.DataSource = dataSetUO.Tables["UO"];
            connection.Close();
            dataGridViewUO.Columns[0].ReadOnly = true;
        }


        public FormUO(SqlConnection connection, int id)
        {
            InitializeComponent();
            this.connection = connection;
            builderUO = new SqlCommandBuilder(adapterUO);
            RefreshWindow(-1);

            //столбцы таблицы
            dataGridViewUO.Columns[0].HeaderText = "Ключ объекта";
            dataGridViewUO.Columns[1].HeaderText = "Ключ огнетушиетля";
            dataGridViewUO.Columns[2].HeaderText = "Дата проверки";
            dataGridViewUO.Columns[3].HeaderText = "Ключ пользователя";
            dataGridViewUO.Columns[4].HeaderText = "Apperience";
            dataGridViewUO.Columns[5].HeaderText = "Масса";
            dataGridViewUO.Columns[6].HeaderText = "Pressure";
            dataGridViewUO.Columns[7].HeaderText = "State";
            dataGridViewUO.Columns[8].HeaderText = "Actions";

            //стиль столбцов
            this.dataGridViewUO.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            this.dataGridViewUO.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
        }

        private void dataGridViewUO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            Int32 idObject = Convert.ToInt32(dataGridViewUO.Rows[dataGridViewUO.SelectedCells[0].RowIndex].Cells[1].Value);
            String cmd = "SELECT [idEXTINGUSHER] FROM [EXTINGUSHER] WHERE [idUO] = " + idObject.ToString() + ";";
            SqlCommand query_ = new SqlCommand(cmd, connection);
            idObject = Convert.ToInt32(query_.ExecuteScalar());
            connection.Close();
            FormExtingusher formEx = new FormExtingusher(connection, idObject);
            formEx.Show();
        }

        private void FormUO_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUO_Click(object sender, EventArgs e)
        {

        }
    }
}
