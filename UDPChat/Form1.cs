using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChat
{
    public partial class FormStartup : Form
    {
        private INIManager iniManager = new INIManager(Directory.GetCurrentDirectory() + "\\settings.ini");
        private Chat chatForm;

        public FormStartup()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Any() && TextBoxPassword.Text.Any())
            {
                iniManager.WritePrivateString("credentials", "login", textBoxLogin.Text);
                chatForm = new Chat(this, textBoxLogin.Text, TextBoxPassword.Text);
                chatForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Введите логин и пароль");

        }

        private void FormStartup_Load(object sender, EventArgs e)
        {
            string login = iniManager.GetPrivateString("credentials", "login");
            textBoxLogin.Text = login;

            if (textBoxLogin.Text.Any())
            {
                TextBoxPassword.Select();
            }
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ButtonEnter_Click(this, new EventArgs());
            }
        }
    }
}
