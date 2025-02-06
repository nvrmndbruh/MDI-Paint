using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyNewPaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            toolSelect.SelectedIndex = 0;
            StarPointCount = 5;
            StarRadiusRatio = 0.5;
        }

        public static Color CurrentColor { get; set; } 
        public static Tools CurrentTool { get; set; }
        public static int CurrentPenThickness {  get; set; }
        public static int StarPointCount { get; set; }
        public static double StarRadiusRatio { get; set; }
        public static Cursor CurrentCursor { get; set; }


        #region Выбор цвета
        private void SetColorBlack_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Black;
            colorSelect.Image = blackSelected.Image;
        }

        private void SetColorRed_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
            colorSelect.Image = redSelected.Image;
        }

        private void SetColorGreen_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
            colorSelect.Image = greenSelected.Image;
        }

        private void SetColorBlue_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
            colorSelect.Image = blueSelected.Image;
        }

        private void SetColorOther_Click(object sender, EventArgs e)
        {
            var d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK)
                CurrentColor = d.Color;
            colorSelect.Image = otherSelected.Image;
        }
        #endregion

        #region Настройки пера

        private void UsePenTool()
        {
            CurrentTool = Tools.Pen;
            CurrentCursor = Cursors.Hand;
        }

        private void UseCircleTool()
        {
            CurrentTool = Tools.Ellipse;
        }

        private void UseRectangleTool()
        {
            CurrentTool = Tools.Rectangle;
        }

        private void UseStarTool()
        {
            CurrentTool = Tools.Star;
        }

        private void UseLineTool()
        {
            CurrentTool = Tools.Line;
        }

        private void UseEraserTool()
        {
            CurrentTool = Tools.Eraser;
        }


        private void toolStripSplitButton2_Click(object sender, EventArgs e)
        {
            var cmb = (ToolStripComboBox)sender;
            switch (cmb.Text)
            {
                case "Перо": { UsePenTool(); break; }
                case "Эллипс": { UseCircleTool(); break; }
                case "Прямоугольник": { UseRectangleTool(); break; }
                case "Звезда": { UseStarTool(); break; }
                case "Линия": { UseLineTool(); break; }
                case "Ластик": { UseEraserTool(); break; }
            }
        }

        private void thicknessSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentPenThickness = (int)((NumericUpDown)sender).Value;
        }

        private void StarSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new StarSettingsForm(this);
            settingsForm.ShowDialog();
        }


        #endregion

        #region Расположение окон

        private void CascadeLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArrangeIconsLayout_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewDocument_Click(object sender, EventArgs e)
        {
            var f = new DocumentForm();
            f.MdiParent = this;
            f.Show();
        }

        private void CanvasSize_Click(object sender, EventArgs e)
        {
            var csf = new CanvasSizeForm();
            csf.MdiParent = this;
            csf.Show();
        }

        private void AboutApplication_Click(object sender, EventArgs e)
        {
            var f = new AboutBoxForm();
            f.ShowDialog();
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
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

        private void файлToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            SaveAsButton.Enabled = d != null;

        }

        public void ShowPosition(int x, int y) 
        {
            if (x!=-1)
                statusLabelPosition.Text = $"X: {x} Y: {y}";
            else
                statusLabelPosition.Text = string.Empty;
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files|*.*|*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream s = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                var tmp = new Bitmap(s);
                DocumentForm doc = new DocumentForm(tmp);
                doc.MdiParent = this;
                doc.Show();
            }
        }
    }
}
