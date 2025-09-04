using PluginInterface;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyNewPaint
{
    public partial class PluginManagerForm : Form
    {
        private readonly PluginsConfiguration config;

        public PluginManagerForm(PluginsConfiguration config)
        {
            InitializeComponent();
            this.config = config;
            pluginsGridView.DataSource = new BindingList<PluginConfigEntry>(config.Plugins);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
