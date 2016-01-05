using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyChar取得
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label7.Text = e.KeyCode.ToString();
            label8.Text = e.KeyValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label6.Text = e.KeyChar.ToString();
        }
    }
}
