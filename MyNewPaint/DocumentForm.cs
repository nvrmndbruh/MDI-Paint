using System;
using System.CodeDom;
using System.Drawing;
using System.Windows.Forms;

namespace MyNewPaint
{
    public partial class DocumentForm : Form
    {
        private int x, y;

        public Bitmap Bmp;

        private Bitmap BmpTemp;

        private Graphics graphics;

        public DocumentForm()
        {
            InitializeComponent();
            Bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            graphics = Graphics.FromImage(Bmp);
            BmpTemp = Bmp;
        }

        public DocumentForm(Bitmap bmp)
        {
            InitializeComponent();
            Bmp = bmp;
            graphics = Graphics.FromImage(Bmp);
            BmpTemp = Bmp;
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
                        graphics.DrawLine(pen, x, y, e.X, e.Y);
                        x = e.X;
                        y = e.Y;
                        BmpTemp = Bmp;
                        Invalidate();
                        break;
                    case Tools.Ellipse:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);
                        graphics.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y-y));
                        Invalidate();
                        break;
                    case Tools.Rectangle:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);
                        graphics.DrawRectangle(pen, x, y, e.X - x, e.Y - y);
                        Invalidate();
                        break;
                    case Tools.Star:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);
                        int n = MainForm.StarPointCount;                 // число вершин
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
                    case Tools.Line:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);
                        graphics.DrawLine(pen, x, y, e.X, e.Y);
                        Invalidate();
                        break;
                    case Tools.Eraser:
                        pen.Color = Color.Transparent;
                        graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        graphics.DrawLine(pen, x, y, e.X, e.Y);
                        x = e.X;
                        y = e.Y;
                        Invalidate();
                        break;
                    case Tools.Fill:
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
            e.Graphics.DrawImage(BmpTemp, 0, 0);
        }

        private void DocumentForm_MouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.CurrentTool)
            {
                case Tools.Pen:
                    break;
                default:
                    Bmp = BmpTemp;
                    Invalidate();
                    break;
            }
        }

        private void DocumentForm_MouseLeave(object sender, EventArgs e)
        {
            var parent = MdiParent as MainForm;
            parent?.ShowPosition(-1, -1);
            Cursor = Cursors.Arrow;
        }


        public void SaveButton_Click(object sender, EventArgs e)
        {
            //bmp.Save();
        }

        private void DocumentForm_MouseEnter(object sender, EventArgs e)
        {
            MainForm.CurrentCursor = Cursors.Arrow;
        }

        public void SaveAsButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|All files|*.*";
            dialog.FileName = $"{((DocumentForm)ActiveMdiChild).Text}";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ((DocumentForm)ActiveMdiChild).Bmp.Save(dialog.FileName);
                ActiveMdiChild.Text = dialog.FileName;
            }
        }
    }
}
