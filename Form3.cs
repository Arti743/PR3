using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PR3
{
    public partial class FormPlayer : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        //Подключение к SQL Server'у 
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=PR3; Integrated Security=True";
        string sql = "SELECT * FROM Players";

        public FormPlayer()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR3DataSet.Players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.pR3DataSet.Players);

        }


        //Добавление новой строки в таблицу (После добавления строки, нужно нажать на кнопку "Сохранить" затем на кнопку "Обновить")
        private void button_Add_Click(object sender, EventArgs e)
        {
            openchild(panel1, new FormPlayer());
            DataRow row = ds.Tables[0].NewRow();
        }
        //Удаление выделеной строки
        private void button_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        //Сохранение изменений
        private void button_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("INSERT INTO Players(ID, Nickname, Server_name) VALUES ('','', '')", connection);
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 35, "ID"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Nickname", SqlDbType.NVarChar, 150, "Nickname"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Server_name", SqlDbType.NVarChar, 35, "Server_name"));

                adapter.Update(ds);
            }
        }

        //Обновление таблицы
        void openchild(Panel pen, Form emptyF)
        {
            emptyF.TopLevel = false;
            emptyF.FormBorderStyle = FormBorderStyle.None;
            emptyF.Dock = DockStyle.Fill;
            pen.Controls.Add(emptyF);
            emptyF.BringToFront();
            emptyF.Show();

        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            openchild(panel1, new FormPlayer());
        }
    }
}
