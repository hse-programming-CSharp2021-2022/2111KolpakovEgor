using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool flag = true;

        async private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (label1.Text.Length != 0)
                {
                    if (label1.Text[label1.Text.Length - 1] == ' ')
                        label1.Text = label1.Text[..^2];
                    else
                        label1.Text = label1.Text[..^1];
                }
                else
                {
                    for (Opacity = 1; Opacity > 0; Opacity -= 0.1)
                    {
                        await Task.Delay(100);
                    }
                    if (Opacity == 0)
                        flag = false;
                }
            }
            else 
            {
                label1.Text = "Кот уже ушёл!";
                for (Opacity = 0; Opacity < 1; Opacity += 0.1)
                {
                    await Task.Delay(100);
                }
                timer1.Enabled = false;
            }
        }
    }
}