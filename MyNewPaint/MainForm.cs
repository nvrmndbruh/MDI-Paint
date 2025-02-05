using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewPaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            //CurrentTool = Tools.Pen;
            toolSelect.SelectedIndex = 0;
        }


        /// <summary>
        /// Текущий цвет.
        /// </summary>
        public static Color CurrentColor { get; set; } 
        public static Tools CurrentTool { get; set; }
        public static int CurrentPenThickness {  get; set; }


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

        #region Выбор пера
        private void UsePenTool_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Pen;
        }

        private void UseCircleTool_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Circle;
        }

        private void UseRectangleTool_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Rectangle;
        }

        private void UseStarTool_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Star;
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

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;

            if (d != null)
            {
                var dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    d.SaveAs(dlg.FileName);
                }

            }
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }


        private void файлToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;

            сохранитьКакToolStripMenuItem.Enabled = d != null;
        }

        public void ShowPosition(int x, int y) 
        {
            if (x!=-1)
                statusLabelPosition.Text = $"X: {x} Y: {y}";
            else
                statusLabelPosition.Text = string.Empty;
        }

        private void toolStripSplitButton2_Click(object sender, EventArgs e)
        {
            var cmb = (ToolStripComboBox)sender;
            switch (cmb.Text)
            {
                case "Перо":
                    {
                        CurrentTool = Tools.Pen;
                        break;
                    }
                case "Овал":
                    {
                        CurrentTool = Tools.Circle;
                        break;
                    }
                case "Прямоугольник":
                    {
                        CurrentTool = Tools.Rectangle;
                        break;
                    }
                case "Звезда":
                    {
                        CurrentTool = Tools.Star;
                        break;
                    }
                //case "Перо":
                //    {
                //        CurrentTool = Tools.Pen;
                //        break;
                //    }
            }
        }

        private void thicknessSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentPenThickness = (int)((NumericUpDown)sender).Value;
        }
    }
}
