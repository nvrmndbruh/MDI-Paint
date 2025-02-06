﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyNewPaint
{
    public partial class DocumentForm : Form
    {
        private int x, y;

        private Bitmap bmp;

        private Bitmap bmpTemp;

        private Graphics graphics;

        public DocumentForm()
        {
            InitializeComponent();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            graphics = Graphics.FromImage(bmp);
            bmpTemp = bmp;
        }

        public DocumentForm(Bitmap bmp)
        {
            InitializeComponent();
            this.bmp = bmp;
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   
                var pen = new Pen(MainForm.CurrentColor, MainForm.CurrentPenThickness);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                switch (MainForm.CurrentTool)
                {
                    case Tools.Pen:
                        //graphics = Graphics.FromImage(bmp);
                        graphics.DrawLine(pen, x, y, e.X, e.Y);
                        x = e.X;
                        y = e.Y;
                        bmpTemp = bmp;
                        Cursor = Cursors.Default;

                        Invalidate();
                        break;
                    case Tools.Circle:
                        bmpTemp = (Bitmap)bmp.Clone();
                        graphics = Graphics.FromImage(bmpTemp);
                        graphics.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y-y));
                        Cursor = Cursors.Cross;

                        Invalidate();
                        break;
                    case Tools.Rectangle:
                        bmpTemp = (Bitmap)bmp.Clone();
                        graphics = Graphics.FromImage(bmpTemp);
                        graphics.DrawRectangle(pen, x, y, e.X - x, e.Y - y);

                        Invalidate();
                        break;
                    case Tools.Star:
                        bmpTemp = (Bitmap)bmp.Clone();
                        graphics = Graphics.FromImage(bmpTemp);

                        int n = MainForm.StarVerticies;                 // число вершин
                        double radiusRatio = MainForm.StarRadiusRatio;  // радиусы

                        double rx = (e.X-x) / 2;
                        double ry = (e.Y - y) / 2;
                        double cx = x + rx;
                        double cy = y + ry;

                        double ratio = rx == 0 ? 1 : ry/rx;

                        PointF[] points = new PointF[2 * n + 1];

                        double a = Math.PI/2, da = Math.PI/n, l;
                        for (int k = 0; k < 2 * n + 1; k++)
                        {
                            l = k % 2 == 0 ? rx * radiusRatio : rx;
                            points[k] = new PointF(
                                (float)(cx + l * Math.Cos(a)),
                                (float)(cy + l * Math.Sin(a)*ratio));
                            a += da;
                        }

                        graphics.DrawLines(pen, points);
                        
                        Invalidate();
                        break;
                }
               
            }

            var parent = MdiParent as MainForm;
            parent?.ShowPosition(e.X, e.Y);
            
        }

        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bmpTemp, 0, 0);
        }

        private void DocumentForm_MouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.CurrentTool)
            {
                case Tools.Circle:
                    bmp = bmpTemp;
                    Invalidate();
                    break;
                case Tools.Rectangle:
                    bmp = bmpTemp;
                    Invalidate();
                    break;
                case Tools.Star:
                    bmp = bmpTemp;
                    Invalidate();
                    break;
            }
        }

        private void DocumentForm_MouseLeave(object sender, EventArgs e)
        {
            var parent = MdiParent as MainForm;
            parent?.ShowPosition(-1, -1);
            Cursor = Cursors.Default;
        }

        public void SaveAs(string path)
        {
            bmp.Save(path);
        }
    }
}
