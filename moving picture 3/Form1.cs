﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving_picture_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 100 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y - 100);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y + 100);
                await Task.Delay(500);
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 100);
                //await Task.Delay(500);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 100, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 100);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y - 100);
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 100);
                //await Task.Delay(500);
            }
        }
    }
}
