using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            DrawCayleyTree(depth, 200, 310, length, -Math.PI / 2);
        }

        int depth = 10;
        double length = 100;

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        Pen pen = Pens.Blue;

        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void depth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                depth = int.Parse(Depth.Text);
            }
            catch
            {
                Depth.Text = "";
            }
        }

        private void Leng_TextChanged(object sender, EventArgs e)
        {
            try
            {
                length = double.Parse(Leng.Text);
            }
            catch
            {
                Leng.Text = "";
            }
        }

        private void Perr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = double.Parse(Perr.Text);
            }
            catch
            {
                Perr.Text = "";
            }
        }

        private void Perl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = double.Parse(Perl.Text);
            }
            catch
            {
                Perl.Text = "";
            }
        }

        private void Angler_TextChanged(object sender, EventArgs e)
        {
            try
            {
                th1 = double.Parse(Angler.Text) * Math.PI / 180;
            }
            catch
            {
                Angler.Text = "";
            }
        }

        private void Anglel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                th2 = double.Parse(Anglel.Text) * Math.PI / 180;
            }
            catch
            {
                Anglel.Text = "";
            }
        }

        private void ColorSet_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            pen = new Pen(ColorDialog.Color);
            ColorSet.BackColor = ColorDialog.Color;
        }
    }
}
