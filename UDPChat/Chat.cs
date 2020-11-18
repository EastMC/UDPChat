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
        private FormStartup parent;
        private UDP udp;
        private Timer onlineTimer;
        private const string uniquePart = "14832133161941921251119219416133321481";
        private const string servicePart = "8899aabbccddeeff0077665544332211";
        private TreeNode onlineUsers = new TreeNode("Online:");

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
            onlineTimer = new Timer
            {
                Interval = 1000
            };
            onlineTimer.Tick += SendOnline;
            onlineTimer.Tick += RefreshOnlineList;
            onlineTimer.Start();
            InitializeComponent();
            TreeViewOnline.Nodes.Add(onlineUsers);
        }

        private void SendOnline(object sender, EventArgs e)
        {
            udp.Send($"{login}{servicePart}");
        }

        private void RefreshOnlineList(object sender, EventArgs e)
        {
            onlineUsers.Nodes.Clear();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            udp.CloseAllConnections();
            parent.Close();
        }

        private void DisplayReceivedMessage(string _message)
        {
            if (_message.Contains(servicePart))
            {
                /*
                if (onlineUsers.Nodes.Find(_message.Replace(servicePart, ""), false).Length == 0)
                {
                    onlineUsers.Nodes.Add(new TreeNode(_message.Replace(servicePart, "")));
                }
                */
            }

            if (_message.Contains(uniquePart))
            {
                TextBoxViewHistory.Text = TextBoxViewHistory.Text +
                        (TextBoxViewHistory.Text.Any() ? "\r\n" : "") +
                        $"{DateTime.Now.ToShortTimeString()} {_message.Replace(uniquePart,"")}";
            }
    }

        private void TextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBoxViewHistory.Text = TextBoxViewHistory.Text +
                    (TextBoxViewHistory.Text.Any()?"\r\n":"") +
                    $"{DateTime.Now.ToShortTimeString()} {login}: {TextBoxMessage.Text}";
                udp.Send($"{login}: {TextBoxMessage.Text}{uniquePart}");
                TextBoxMessage.Clear();

            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            TextBoxMessage.Select();
        }
    }
}
