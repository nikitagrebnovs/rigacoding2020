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
    public partial class reigsterForm : Form
    {
        public reigsterForm()
        {
            InitializeComponent();
            this.userpassField.AutoSize = false;
            this.userpassField.Size = new Size(this.userpassField.Size.Width, 64);

            userNameField.Text = "Enter name";
            UserSurnameField.Text = "Enter surname";
            userloginField.Text = "Enter login";
            userpassField.Text = "Enter password";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void reigsterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void reigsterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text=="Enter name") 
            userNameField.Text = "";
            userNameField.ForeColor = Color.Black;
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Enter name";
                userNameField.ForeColor = Color.Gray;
            }
        }


        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Enter surname")
                UserSurnameField.Text = "";
            UserSurnameField.ForeColor = Color.Black;

        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Enter surname";
                UserSurnameField.ForeColor = Color.Gray;
            }

        }

        private void userloginField_Enter(object sender, EventArgs e)
        {
            if (userloginField.Text == "Enter login")
                userloginField.Text = "";
            userloginField.ForeColor = Color.Black;

        }

        private void userloginField_Leave(object sender, EventArgs e)
        {
            if (userloginField.Text == "")
            {
                userloginField.Text = "Enter login";
                userloginField.ForeColor = Color.Gray;
            }
        }

        private void userpassField_Enter(object sender, EventArgs e)
        {
            if (userpassField.Text == "Enter password")
            {
                this.userpassField.UseSystemPasswordChar = true;
                userpassField.Text = "";
            }
            userpassField.ForeColor = Color.Black;
        }

        private void userpassField_Leave(object sender, EventArgs e)
        {
            if (userpassField.Text == "")
            {
                this.userpassField.UseSystemPasswordChar = false;
                userpassField.Text = "Enter password";
                userpassField.ForeColor = Color.Gray;
            }
        }

        private void userpassField_TextChanged(object sender, EventArgs e)
        {

        }

        private void regbotton_Click(object sender, EventArgs e)
        {
            if (checkLogin())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `firstdb`.`users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userloginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userpassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Succesful!");
                login();
            }
            else
                MessageBox.Show("Fail!");

            db.closeConnection();

        }

        public Boolean checkLogin()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userloginField.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Login already used");
                return true;
            }

            else
            {
                
                return false;
            }
        }

        public void login()
        {
            this.Hide();
            LoginForm dlg = new LoginForm();
            dlg.Show();

        }

    }
}
