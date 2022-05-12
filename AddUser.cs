using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Interfeces
{
    public partial class AddUser : Form
    {
        private mainWindow main_window;
        public AddUser(mainWindow inp_main_window)
        {
            InitializeComponent();
            comboBoxAccess.SelectedIndex = 0;
            main_window = inp_main_window;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void checkBoxConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxConfirmPassword.UseSystemPasswordChar = !checkBoxConfirmPassword.Checked;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                main_window.users.Add(new User(textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxFName.Text, 
                    textBoxLogin.Text, textBoxPassword.Text, comboBoxAccess.SelectedIndex));
                this.Close();
                main_window.Show();
            }
            else
            {
                MessageBox.Show("Ошибка: пароли не совпадают", "Ошибка пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_window.Show();
        }
    }
}
