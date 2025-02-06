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
    public partial class StarSettingsForm : Form
    {
        //public static MainForm MainForm { get; set; }

        public StarSettingsForm(MainForm parent)
        {
            InitializeComponent();
            //MainForm = parent;
            verticiesSelect.Value = MainForm.StarPointCount;
            radiusRatioSelect.Text = (MainForm.StarRadiusRatio).ToString("f2");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MainForm.StarPointCount = (int)verticiesSelect.Value;
            MainForm.StarRadiusRatio = double.Parse(radiusRatioSelect.Text);
        }

        private void PointCountSelect(object sender, EventArgs e)
        {
            MainForm.StarPointCount = (int)((NumericUpDown)sender).Value;
        }

        private void RadiusRatioSelect_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неправильный формат ввода!\nВводимое значение должно иметь вид '*.**'");   
        }
    }
}
