using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting
{
    public partial class instructions : Form
    {
        public instructions()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = (@"C:/\Users\Ernest\Music\showtime.wav");
            Close();
        }

        private void instructions_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            BackColor = Color.LawnGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = (@"C:/\Users\Ernest\Music\showtime.wav");
            Close();
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = DefaultBackColor;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
