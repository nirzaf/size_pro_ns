using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace size_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(700, 358);
            Int32 h;
            h = this.Size.Height;
            this.Size = new Size(700, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 h;
            h = this.Size.Height;
            this.Size = new Size(510, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(this.pictureBox1.Width + 10, this.pictureBox1.Size.Height + 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(this.pictureBox1.Width - 10, this.pictureBox1.Size.Height - 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X+10, this.pictureBox1.Location.Y );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X - 10, this.pictureBox1.Location.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + ";" + e.Y.ToString();
            //this.pictureBox1.Location = new Point(e.X, e.Y);
            this.button2.Location = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
