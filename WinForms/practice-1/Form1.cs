using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_1
{
    public partial class wnd1 : Form
    {
        public wnd1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my first window app");
        }

        private void Form1_FormClose(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye!");
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //{
            //    MessageBox.Show("Pessed with left click", "Warning");
            //}
            //else if (click.Button == MouseButtons.Right)
            //{
            //    MessageBox.Show("Pessed with right click", "Warning");
            //}
            //else
            //{
            //    MessageBox.Show("Pessed with middle click", "Warning");
            //}
        }

       
    }
}
