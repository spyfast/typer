using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<string> _messages;
        private Thread _threadWorking;
        private bool Active { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Text += Application.ProductVersion;

            if (!File.Exists("messages.txt"))
                File.Create("messages.txt").Close();
            _messages = new List<string>(File.ReadAllLines("messages.txt", Encoding.GetEncoding("windows-1251")));

            label_countMessages.Text += _messages.Count;
            
            if (_messages.Count == 0)
                button_launch.Enabled = false;
        }
        private void Work()
        {
            Random random = new Random();
            Thread.Sleep(5000);
            while (true)
            {
                foreach (char c in _messages[random.Next(0, _messages.Count)])
                {
                    if (c == 10)
                        SendKeys.SendWait("^{ENTER}");
                    else if (!char.IsControl(c))
                    {
                        if (char.IsWhiteSpace(c))
                            SendKeys.SendWait(" ");
                        else
                            SendKeys.SendWait("{" + c.ToString() + "}");
                    }
                    Thread.Sleep((int)numericUpDown_typingDelay.Value);
                }
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep((int)numericUpDown_sendingDelay.Value);
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            Active = !Active;
            if (Active)
            {
                button_launch.Text = "Стоп";
                _threadWorking = new Thread(Work)
                {
                    IsBackground = true
                };
                _threadWorking.Start();
            }
            else
            {
                button_launch.Text = "Старт";
                _threadWorking?.Abort();
            }
        }
    }
}
