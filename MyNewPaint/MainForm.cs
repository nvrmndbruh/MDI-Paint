using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyNewPaint
{
    public partial class MainForm : Form
    {
        private static Color currentColor;
        public static Color CurrentColor
        {
            get { return currentColor; }
            set
            {
                currentColor = value;
                CurrentPen = new Pen(currentColor, CurrentPenThickness);
                CurrentPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                CurrentPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

        private static int currentPenThickness;
        public static int CurrentPenThickness
        {
            get { return currentPenThickness; }
            set
            {
                currentPenThickness = value;
                CurrentPen = new Pen(currentColor, CurrentPenThickness);
                CurrentPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                CurrentPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

        private static Pen currentPen;
        public static Pen CurrentPen
        {
            get { return currentPen; }
            set
            { 
                currentPen = value;
                currentPenThickness = (int)currentPen.Width;
                currentColor = currentPen.Color;
            }
        }
        public static Tools CurrentTool { get; set; }
        public static int StarPointCount { get; set; }
        public static double StarRadiusRatio { get; set; }
        public static bool FillFigures { get; set; } = false;


        Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();

        private PluginsConfiguration config;

        private CancellationTokenSource _cts;

        public MainForm()
        {
            InitializeComponent();
            CurrentPenThickness = 1;
            CurrentColor = Color.Black;
            toolSelect.SelectedIndex = 0;
            StarPointCount = 5;
            StarRadiusRatio = 0.5;

            FindPlugins();
            CreatePluginsMenu();
        }

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

        private void UseFillTool()
        {
            CurrentTool = Tools.Fill;
        }

        private void UseTextTool()
        {
            CurrentTool = Tools.Text;
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
                case "Заливка": { UseFillTool(); break; }
                case "Текст": { UseTextTool(); break; }
            }
        }

        private void thicknessSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentPenThickness = (int)((NumericUpDown)sender).Value;
        }

        private void StarSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new StarSettingsForm();
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

        #region Активация кнопок меню

        private void FileMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            saveButton.Enabled = d != null;
            saveAsButton.Enabled = d != null;
        }

        private void PictureMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            canvasSizeButton.Enabled = d != null;
        }

        private void окноToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            cascadeButton.Enabled = d != null;
            tileVerticalButton.Enabled = d != null;
            arrangeButton.Enabled = d != null;
        }

        #endregion

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CanvasSize_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm doc)
            {
                var csf = new CanvasSizeForm(this);
                if (csf.ShowDialog() == DialogResult.OK)
                {
                    var tmp = new Bitmap(csf.CanvasWidth, csf.CanvasHeight);
                    using (var g = Graphics.FromImage(tmp))
                    {
                        g.DrawImage(doc.Bmp, 0, 0);
                    }
                    doc.UpdateBitmap(tmp);
                }
            }
        }

        private void AboutApplication_Click(object sender, EventArgs e)
        {
            var f = new AboutBoxForm();
            f.ShowDialog();
        }

        private void NewDocument_Click(object sender, EventArgs e)
        {
            var f = new DocumentForm();
            f.MdiParent = this;
            f.Show();
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Изображения (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream s = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                var tmp = new Bitmap(s);
                DocumentForm doc = new DocumentForm(tmp);
                doc.MdiParent = this;
                doc.Text = dlg.FileName;
                doc.Show();
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            var doc = ActiveMdiChild as DocumentForm;

            if (doc.FilePath == null)
                FileSaveAs_Click(sender, e);
            else
                doc.Save(doc.FilePath);
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            var doc = ActiveMdiChild as DocumentForm;

            dialog.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|All files|*.*";
            dialog.FileName = $"{doc.Text}";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc.Save(dialog.FileName);
                doc.Text = dialog.FileName;
            }
        }


        public void ShowPosition(int x, int y) 
        {
            if (x!=-1)
                statusLabelPosition.Text = $"X: {x} Y: {y}";
            else
                statusLabelPosition.Text = string.Empty;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            MainForm.FillFigures = !MainForm.FillFigures;
            fillButton.Image = FillFigures
                ? Properties.Resources.fill
                : Properties.Resources.no_fill;
        }



        private void zoomDefaultButton_Click(object sender, EventArgs e)
        {
            var doc = ActiveMdiChild as DocumentForm;
            doc?.ResetZoom();
            doc.Invalidate();
        }


        void FindPlugins()
        {
            // папка с плагинами
            plugins.Clear();
            config = LoadConfig();

            string folder = AppDomain.CurrentDomain.BaseDirectory;
            var files = Directory.GetFiles(folder, "*.dll");
            var loadedPlugins = new List<PluginConfigEntry>();

            foreach (string file in files)
            {
                try
                {
                    Assembly asm = Assembly.LoadFile(file);

                    foreach (Type type in asm.GetTypes())
                    {
                        if (type.GetInterface(typeof(IPlugin).FullName) != null)
                        {
                            // получаем версию из VersionAttribute
                            var versionAttr = type.GetCustomAttributes(typeof(VersionAttribute), false)
                                         .FirstOrDefault() as VersionAttribute;

                            string version = versionAttr != null
                                ? $"{versionAttr.Major}.{versionAttr.Minor}"
                                : "Unknown";

                            var pluginName = Path.GetFileName(file);

                            // если автоматический режим или в конфиге включён
                            bool shouldLoad = config.AutoMode ||
                                config.Plugins.FirstOrDefault(p => p.Path == pluginName)?.Enabled == true;

                            if (shouldLoad)
                            {
                                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                                plugins[plugin.Name] = plugin;
                            }

                            if (!config.Plugins.Any(p => p.Path == pluginName))
                            {
                                loadedPlugins.Add(new PluginConfigEntry
                                {
                                    Path = pluginName,
                                    Enabled = true,
                                    Version = version
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
            }
            // если были добавлены новые плагины — обновим конфиг
            if (loadedPlugins.Any())
            {
                config.Plugins.AddRange(loadedPlugins);
                SaveConfig(config);
            }
        }

        private void CreatePluginsMenu()
        {
            // Сначала очистка, чтобы не дублировать
            filtersToolStripMenuItem.DropDownItems.Clear();

            // Добавляем плагин‑фильтры
            foreach (var kvp in plugins)
            {
                var item = new ToolStripMenuItem(kvp.Value.Name);
                item.Click += OnPluginClick;
                filtersToolStripMenuItem.DropDownItems.Add(item);
            }

            filtersToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            var manageItem = new ToolStripMenuItem("Управление плагинами ...");
            manageItem.Click += managePluginsToolStripMenuItem_Click;
            filtersToolStripMenuItem.DropDownItems.Add(manageItem);
        }

        private async void OnPluginClick(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                MessageBox.Show("Нет открытого документа для применения фильтра.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = (ToolStripMenuItem)sender;
            if (!plugins.TryGetValue(item.Text, out IPlugin plugin))
                return;

            btnCancel.Visible = true;
            progressBar1.Value = 0;
            _cts = new CancellationTokenSource();
            var progress = new Progress<int>(p =>
            progressBar1.Value = Math.Max(progressBar1.Minimum, Math.Min(progressBar1.Maximum, p))
            );

            try
            {
                await plugin.Transform(((DocumentForm)ActiveMdiChild).Bmp, progress, _cts.Token);

                // помечаем документ как изменённый
                ((DocumentForm)ActiveMdiChild).Saved = false;

                // обновляем временный слой сразу под новую картинку
                ((DocumentForm)ActiveMdiChild).BmpTemp = (Bitmap)((DocumentForm)ActiveMdiChild).Bmp.Clone();

                // обновляем
                ActiveMdiChild.Invalidate(true);
                ActiveMdiChild.Update();
                ActiveMdiChild.Focus();
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция отменена", "Плагин", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btnCancel.Visible = false;
                progressBar1.Value = 0;
                _cts.Dispose();
            }
        }

        private void managePluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new PluginManagerForm(config);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                config.AutoMode = false;
                SaveConfig(config);

                // обновляем
                FindPlugins();
                CreatePluginsMenu();
            }
        }

        private string configPath = "Plugins.config";

        private PluginsConfiguration LoadConfig()
        {
            var config = new PluginsConfiguration();

            if (!File.Exists(configPath))
            {
                config.AutoMode = true;
                return config;
            }

            var doc = XDocument.Load(configPath);
            var root = doc.Element("PluginsConfig");
            config.AutoMode = (root.Attribute("mode")?.Value ?? "auto") == "auto";

            foreach (var pluginNode in root.Elements("Plugin"))
            {
                config.Plugins.Add(new PluginConfigEntry
                {
                    Path = pluginNode.Attribute("path")?.Value,
                    Enabled = bool.Parse(pluginNode.Attribute("enabled")?.Value ?? "false"),
                    Version = pluginNode.Attribute("version")?.Value ?? "unknown"
                });
            }

            return config;
        }

        private void SaveConfig(PluginsConfiguration config)
        {
            try
            {
                var doc = new XDocument(new XElement("PluginsConfig",
                new XAttribute("mode", config.AutoMode ? "auto" : "manual"),
                config.Plugins.Select(p =>
                    new XElement("Plugin",
                        new XAttribute("path", p.Path),
                        new XAttribute("enabled", p.Enabled),
                        new XAttribute("version", p.Version)
                    ))
            ));

                doc.Save(configPath);
            }
            catch
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
