using KhanhLinh.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class StatusBarUC : UserControl
    {
        public StatusBarUC()
        {
            InitializeComponent();
        }

        private void StatusBarUC_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox2.Text = SessionInfo.Username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.SelectionStart = textBox1.Text.Length;
        }
    }
}
