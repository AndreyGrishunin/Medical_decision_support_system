using MESysWin.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //if (Settings.Instance.currenUser.Login.Equals("Пациент"))
            //{
            //    buttonLogout.Visible = true;
            //}

            //textBoxLogin.Text = Settings.Instance.currenUser.Login;
            //textBoxLogin.SelectAll();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            if (Settings.Instance.Login(textBoxLogin.Text, textBoxPassword.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправельно введен логин или пароль. Проверьте данные и повторите попытку.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {

                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void LoginTextEnter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == " Логин")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void LoginTextLeave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = " Логин";
                textBoxLogin.ForeColor = Color.Silver;
            }
        }

        private void PasswordTextEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == " Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }

        }
        private void PasswordTextLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = " Пароль";
                textBoxPassword.ForeColor = Color.Silver;
            }
            else
            {
                textBoxPassword.PasswordChar = '\0';
            }
        }


        private void checkBoxShowPassword_MouseLeave(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
        }

        private void Registration_link_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            var registration = new RegistrationForm();
            registration.ShowDialog();
        }

    }
}
