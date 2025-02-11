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
    public partial class CanvasSizeForm : Form
    {
        public int CanvasWidth { get; private set; } = 500;
        public int CanvasHeight { get; private set; } = 500;

        public CanvasSizeForm(MainForm parent)
        {
            InitializeComponent();
            CanvasWidth = ((DocumentForm)parent.ActiveMdiChild).Bmp.Width;
            CanvasHeight = ((DocumentForm)parent.ActiveMdiChild).Bmp.Height;
            widthSelect.Value = CanvasWidth;
            heightSelect.Value = CanvasHeight;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            CanvasWidth = (int)widthSelect.Value;
            CanvasHeight = (int)heightSelect.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void widthSelect_ValueChanged(object sender, EventArgs e)
        {
            CanvasWidth = (int)widthSelect.Value;
        }

        private void heightSelect_ValueChanged(object sender, EventArgs e)
        {
            CanvasHeight = (int)heightSelect.Value;
        }
    }
}
