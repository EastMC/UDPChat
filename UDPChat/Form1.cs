using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private bool isInputsValid()
        {
            try
            {
                var netIP = IPAddress.Parse(textBoxLANNet.Text);
            }
            catch { return false; }
            return true;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Any() && TextBoxPassword.Text.Any())
            {
                if (isInputsValid())
                {
                    iniManager.WritePrivateString("credentials", "login", textBoxLogin.Text);
                    iniManager.WritePrivateString("settings", "ip", textBoxLANNet.Text);
                    chatForm = new Chat(this, textBoxLogin.Text);
                    var udp = new UDP((int)numericUpDownPortSend.Value,
                        (int)numericUpDownPortReceive.Value,
                        TextBoxPassword.Text,
                        IPAddress.Parse(textBoxLANNet.Text),
                        (int)numericUpDownMask.Value);
                    chatForm.Udp = udp;
                    chatForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Некорректные параметры настройки.");
                    SetSettingsFormsVisible(true);
                }






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
            numericUpDownMask.Visible = _isVisible;
            textBoxLANNet.Visible = _isVisible;
            numericUpDownPortReceive.Visible = _isVisible;
            numericUpDownPortSend.Visible = _isVisible;
        }


    }
}
