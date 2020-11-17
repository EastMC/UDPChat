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
            SetSettingsFormsVisible(false);
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Any() && TextBoxPassword.Text.Any())
            {
                iniManager.WritePrivateString("credentials", "login", textBoxLogin.Text);
                iniManager.WritePrivateString("settings", "ip", textBoxLANNet.Text);
                ///var udp = new UDP(textBoxPortSend.Text,
                ///    textBoxPortReceive.Text,
                ///    TextBoxPassword.Text,
                ///    textBoxLANNet.Text,
                //    textBoxLANMask.Text);
               // udp.Notify += DisplayReceivedMessage;


                chatForm = new Chat(this, textBoxLogin.Text, TextBoxPassword.Text, textBoxPortSend.Text, textBoxPortReceive.Text, textBoxLANNet.Text);
                chatForm.Show();

                this.Hide();
            }
            else MessageBox.Show("Введите логин и пароль");

        }

        private void FormStartup_Load(object sender, EventArgs e)
        {
            string login = iniManager.GetPrivateString("credentials", "login");
            textBoxLogin.Text = login;
            string ip = iniManager.GetPrivateString("settings", "ip");
            textBoxLANNet.Text = ip;


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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SetSettingsFormsVisible(!labelLANParams.Visible);
        }

        private void SetSettingsFormsVisible(bool _isVisible)
        {
            labelPortReceive.Visible = _isVisible;
            labelPortSend.Visible = _isVisible;
            labelLANParams.Visible = _isVisible;
            textBoxLANMask.Visible = _isVisible;
            textBoxLANNet.Visible = _isVisible;
            textBoxPortReceive.Visible = _isVisible;
            textBoxPortSend.Visible = _isVisible;
        }


    }
}
