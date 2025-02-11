using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MyNewPaint
{
    public partial class DocumentForm : Form
    {
        private int x, y;
        public Bitmap Bmp { get; set; }
        private Bitmap BmpTemp {get; set; }
        public string FilePath {  get; set; }
        public bool Saved { get; set; } = true;

        private Graphics graphics;

        public DocumentForm()
        {
            Bmp = new Bitmap(500, 500);
            BmpTemp = Bmp;
            graphics = Graphics.FromImage(Bmp);
            InitializeComponent();
            this.ClientSize = new Size(Bmp.Width, Bmp.Height);
        }

        public DocumentForm(Bitmap bmp)
        {
            Bmp = new Bitmap(bmp);
            BmpTemp = Bmp;
            graphics = Graphics.FromImage(Bmp);
            InitializeComponent();
            this.ClientSize = new Size(Bmp.Width, Bmp.Height);
        }

        public void UpdateBitmap(Bitmap bmp)
        {
            this.Bmp = bmp;
            this.BmpTemp = bmp;
            graphics = Graphics.FromImage(bmp);
            InitializeComponent();
            this.ClientSize = new Size(bmp.Width, bmp.Height);
        }

        private float zoom = 1.0f;
        private const float step = 0.1f;
        private const float MinZoom = 0.1f;
        private const float MaxZoom = 4.0f;

        public void ZoomIn()
        {
            zoom += step;
            if (zoom > MaxZoom) zoom = MaxZoom;
            UpdateZoom();
        }

        public void ZoomOut()
        {
            zoom -= step;
            if (zoom < MinZoom) zoom = MinZoom;
            UpdateZoom();
        }

        public void ResetZoom()
        {
            zoom = 1.0f;
            UpdateZoom();
        }

        private void UpdateZoom()
        {
            this.AutoScrollMinSize = new Size(
                (int)(Bmp.Width * zoom),
                (int)(Bmp.Height * zoom)
            );
            this.Invalidate();
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Saved = false;
                var pen = MainForm.CurrentPen;

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
                        if (MainForm.FillFigures)
                            graphics.FillEllipse(new SolidBrush(pen.Color), new Rectangle(x, y, e.X - x, e.Y - y));
                        else
                            graphics.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y-y));
                        Invalidate();
                        break;
                    case Tools.Rectangle:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);

                        int rx = Math.Min(e.X, x);
                        int ry = Math.Min(e.Y, y);
                        int width = Math.Abs(x - e.X);
                        int height = Math.Abs(y - e.Y);
                        var rectangle = new Rectangle(rx, ry, width, height);

                        if (MainForm.FillFigures)
                            graphics.FillRectangle(new SolidBrush(pen.Color), rectangle);
                        else
                            graphics.DrawRectangle(pen, rectangle);
                        Invalidate();
                        break;
                    case Tools.Star:
                        BmpTemp = (Bitmap)Bmp.Clone();
                        graphics = Graphics.FromImage(BmpTemp);
                        int n = MainForm.StarPointCount;
                        double radiusRatio = MainForm.StarRadiusRatio;
                        double sx = (e.X-x) / 2;
                        double sy = (e.Y - y) / 2;
                        double cx = x + sx;
                        double cy = y + sy;
                        double ratio = sx == 0 ? 1 : sy/sx;
                        PointF[] points = new PointF[2 * n + 1];
                        double a = Math.PI/2, da = Math.PI/n, l;
                        for (int k = 0; k < 2 * n + 1; k++)
                        {
                            l = k % 2 == 0 ? sx * radiusRatio : sx;
                            points[k] = new PointF(
                                (float)(cx + l * Math.Cos(a)),
                                (float)(cy + l * Math.Sin(a)*ratio));
                            a += da;
                        }

                        if (MainForm.FillFigures)
                            graphics.FillPolygon(new SolidBrush(pen.Color), points);
                        else
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
                        pen.Color = MainForm.CurrentColor;
                        break;
                }
               
            }

            var parent = MdiParent as MainForm;
            parent?.ShowPosition(e.X, e.Y);
            
        }

        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            int scrollX = -this.AutoScrollPosition.X;
            int scrollY = -this.AutoScrollPosition.Y;
            int zx = (int)((e.X + scrollX) / zoom);
            int zy = (int)((e.Y + scrollY) / zoom);

            x = zx;
            y = zy;

            if (MainForm.CurrentTool == Tools.Text)
            {
                using (var inputDialog = new TextInputDialog())
                {
                    if (inputDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(inputDialog.EnteredText))
                    {
                        DrawText(new Point(x, y), inputDialog.EnteredText);
                        Saved = false;
                    }
                }
            }
            switch (MainForm.CurrentTool)
            {
                case Tools.Fill:
                    FloodFill(new Point(x, y), Bmp.GetPixel(x, y), MainForm.CurrentColor);
                    Invalidate();
                    break;
            }
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

        private void DocumentForm_MouseEnter(object sender, EventArgs e)
        {
            Cursor = ChangeCursor(MainForm.CurrentTool);
        }

        private void DocumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var doc = (DocumentForm)sender;

            if (!doc.Saved)
            {
                var res = MessageBox.Show(
                "Сохранить изменения?", "Изменения не сохранены",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (res == DialogResult.Yes)
                {
                    if (doc.FilePath == null)
                    {
                        doc.SaveAs();
                    }
                    else
                        doc.Save(doc.FilePath);
                }
            }
        }

        public void SaveAs()
        {
            var dialog = new SaveFileDialog();
            
            dialog.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|All files|*.*";
            dialog.FileName = $"{this.Text}";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Save(dialog.FileName);
                this.Text = dialog.FileName;
                Saved = true;
            }
        }

        public void Save(string path)
        {
            try
            {
                ImageFormat format = ImageFormat.Png;
                if (path.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    format = ImageFormat.Bmp;
                else if (path.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    format = ImageFormat.Jpeg;

                Bmp.Save(path, format);
                FilePath = path; // Обновляем путь
                Saved = true; // Документ сохранен
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FloodFill(Point startPoint, Color targetColor, Color fillColor)
        {
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            var queue = new Queue<Point>();
            queue.Enqueue(startPoint);

            int width = Bmp.Width;
            int height = Bmp.Height;

            var visited = new bool[width, height];

            while (queue.Count > 0)
            {
                var point = queue.Dequeue();
                int x = point.X;
                int y = point.Y;

                // Если точка выходит за границы изображения, пропускаем ее
                if (x < 0 || x >= width || y < 0 || y >= height) continue;

                // Если точка уже посещена или ее цвет не совпадает с целевым, пропускаем ее
                if (visited[x, y] || Bmp.GetPixel(x, y).ToArgb() != targetColor.ToArgb()) continue;

                // Заливаем точку
                Bmp.SetPixel(x, y, fillColor);
                visited[x, y] = true;

                // Добавляем соседние точки в очередь
                queue.Enqueue(new Point(x + 1, y)); // Право
                queue.Enqueue(new Point(x - 1, y)); // Лево
                queue.Enqueue(new Point(x, y + 1)); // Низ
                queue.Enqueue(new Point(x, y - 1)); // Верх
            }
        }

        public static Cursor ChangeCursor(Tools tool)
        {
            Cursor cursor = null;
            switch (tool)
            {
                case (Tools.Pen):
                    cursor = Cursors.Hand;
                    break;
                case (Tools.Line):
                    cursor = Cursors.Arrow;
                    break;
                case (Tools.Eraser):
                    cursor = Cursors.Hand;
                    break;
                case (Tools.Ellipse):
                    cursor = Cursors.Cross;
                    break;
                case (Tools.Rectangle):
                    cursor = Cursors.Cross;
                    break;
                case (Tools.Fill):
                    cursor = Cursors.SizeAll;
                    break;
                case (Tools.Star):
                    cursor = Cursors.Cross;
                    break;
                case (Tools.Text):
                    cursor = Cursors.IBeam;
                    break;
            }
            return cursor;
        }
        private void DrawText(Point position, string text)
        {
            using (var g = Graphics.FromImage(Bmp))
            {
                var font = new Font("Arial", 12); // Шрифт и размер
                var brush = new SolidBrush(MainForm.CurrentColor); // Цвет текста
                g.DrawString(text, font, brush, position);
            }
            Invalidate(); // Перерисовываем холст
        }
    }

}
