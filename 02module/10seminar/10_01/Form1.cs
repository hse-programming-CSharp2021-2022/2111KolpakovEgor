using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_01
{
    public partial class Form1 : Form
    {
        int X, Y;
        int W, H;

        public Form1()
        {
            InitializeComponent();
            X = Y = 0;
            W = H = 100;
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - W;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            TransparencyKey = SystemColors.ControlDark;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = trackBar2.Value;
            Invalidate();
        }
    }
}
