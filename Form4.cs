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
    public partial class FormBan : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        //Подключение к SQL Server'у 
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=PR3; Integrated Security=True";
        string sql = "SELECT * FROM Ban_list";

        public FormBan()
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

        private void FormBan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR3DataSet.Ban_list". При необходимости она может быть перемещена или удалена.
            this.ban_listTableAdapter.Fill(this.pR3DataSet.Ban_list);

        }


        //Добавление новой строки в таблицу (После добавления строки, нужно нажать на кнопку "Сохранить" затем на кнопку "Обновить")
        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);

        }
        //Удаление выделеной строки
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        //Сохранение изменений
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("INSERT INTO Ban_list(ID, Player_id, Administrators_id, Ban_type_id, Ban_time, Comment_from_admin) VALUES ('', '', '', '', '', '')", connection);
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 35, "ID"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Player_id", SqlDbType.Int, 35, "Player_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Administrators_id", SqlDbType.Int, 35, "Administrators_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ban_type_id", SqlDbType.Int, 35, "Ban_type_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ban_time", SqlDbType.NVarChar, 150, "Ban_time"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Comment_from_admin", SqlDbType.NVarChar, 220, "Comment_from_admin"));

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
        private void button4_Click(object sender, EventArgs e)
        {
            openchild(panel1, new FormBan());
        }
    }

}
