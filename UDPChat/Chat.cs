using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChat
{
    public partial class Chat : Form
    {
        private string login;
        private string password;
        private FormStartup parent;

        public Chat(FormStartup _parent, string _login, string _password)
        {
            login = _login;
            parent = _parent;
            password = _password;
            InitializeComponent();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void TextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBoxViewHistory.Text = TextBoxViewHistory.Text +
                    (TextBoxViewHistory.Text.Any()?"\r\n":"") +
                    $"{DateTime.Now.ToShortTimeString()} {login}: {TextBoxMessage.Text}";
                TextBoxMessage.Clear();
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            TextBoxMessage.Select();
        }
    }
}
