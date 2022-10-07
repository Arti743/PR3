using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PR3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void openchild(Panel pen, Form emptyF)
        {
            emptyF.TopLevel = false;
            emptyF.FormBorderStyle = FormBorderStyle.None;
            emptyF.Dock = DockStyle.Fill;
            pen.Controls.Add(emptyF);
            emptyF.BringToFront();
            emptyF.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e) //Случайно два раза на панели нажал
        {

        }

        //Переключение форм при нажатии на кнопки
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormAdmin());
        }
        private void buttonBan_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormBan());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Win = new Form1();
            Win.Show();
            this.Hide();
        }
        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormPlayer());
        }

    }
}
