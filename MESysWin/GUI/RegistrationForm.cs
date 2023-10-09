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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void NameTextEnter(object sender, EventArgs e)
        {
            if (textBoxName.Text == " Имя")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void NameTextLeave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = " Имя";
                textBoxName.ForeColor = Color.Silver;
            }
        }

        private void SecondNameTextEnter(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text == " Фамилия")
            {
                textBoxSecondName.Text = "";
                textBoxSecondName.ForeColor = Color.Black;
            }
        }

        private void SecondNameTextLeave(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text == "")
            {
                textBoxSecondName.Text = " Фамилия";
                textBoxSecondName.ForeColor = Color.Silver;
            }
        }

        private void MiddleNameTextEnter(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == " Отчество")
            {
                textBoxMiddleName.Text = "";
                textBoxMiddleName.ForeColor = Color.Black;
            }
        }

        private void MiddleNameTextLeave(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == "")
            {
                textBoxMiddleName.Text = " Отчество";
                textBoxMiddleName.ForeColor = Color.Silver;
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

        private void EmailTextEnter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == " Электронная почта")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void EmailTextLeave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = " Электронная почта";
                textBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void PhoneTextEnter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == " Номер телефона");
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void PhoneTextLeave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "");
            {
                textBoxPhone.Text = " Номер телефона";
                textBoxPhone.ForeColor = Color.Silver;
            }
        }

        private void userToolStripMenuItem_Click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            var login = new LoginForm();
            login.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            this.Close();
        }

        private void buttonOk_Click_Click(object sender, EventArgs e)
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
    }
}
