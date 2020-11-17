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
        private UDP udp;
        
        public UDP Udp
        {
            set
            {
                udp = value;
                udp.Notify += DisplayReceivedMessage;
            }
            get { return udp; }
        }

        public Chat(FormStartup _parent, string _login)
        {
            login = _login;
            parent = _parent;
            InitializeComponent();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            udp.CloseAllConnections();
            parent.Close();
        }

        private void DisplayReceivedMessage(string _message)
        {
            TextBoxViewHistory.Text = TextBoxViewHistory.Text +
                    (TextBoxViewHistory.Text.Any() ? "\r\n" : "") +
                    $"{DateTime.Now.ToShortTimeString()} {_message}";
        }

        private void TextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBoxViewHistory.Text = TextBoxViewHistory.Text +
                    (TextBoxViewHistory.Text.Any()?"\r\n":"") +
                    $"{DateTime.Now.ToShortTimeString()} {login}: {TextBoxMessage.Text}";
                udp.Send($"{login}: {TextBoxMessage.Text}");
                TextBoxMessage.Clear();

            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            TextBoxMessage.Select();
        }
    }
}
