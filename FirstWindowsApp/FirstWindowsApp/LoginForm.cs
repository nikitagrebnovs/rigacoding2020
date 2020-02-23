using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String pass = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `pass`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main dlg = new Main();
                dlg.ShowDialog();
            }
            else
                MessageBox.Show("No");

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Black;
        }

        private void exit_MouseUp(object sender, MouseEventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.LimeGreen;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint2;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reigsterForm dlg = new reigsterForm();
            dlg.Show();
            
        }

       
    }
}
