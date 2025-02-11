namespace MyNewPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasSizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.starsettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolSelect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.thicknessSelect = new System.Windows.Forms.NumericUpDown();
            this.colorSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.redSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.greenSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.blueSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.otherSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.fillButton = new System.Windows.Forms.ToolStripButton();
            this.zoomDefaultButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentButton,
            this.openButton,
            this.toolStripSeparator2,
            this.saveButton,
            this.saveAsButton,
            this.toolStripMenuItem1,
            this.exitButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            this.файлToolStripMenuItem.DropDownOpening += new System.EventHandler(this.FileMenuItem_DropDownOpening);
            // 
            // newDocumentButton
            // 
            this.newDocumentButton.Name = "newDocumentButton";
            this.newDocumentButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocumentButton.Size = new System.Drawing.Size(253, 22);
            this.newDocumentButton.Text = "&Новый";
            this.newDocumentButton.Click += new System.EventHandler(this.NewDocument_Click);
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openButton.Size = new System.Drawing.Size(253, 22);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(250, 6);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveButton.Size = new System.Drawing.Size(253, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsButton.Size = new System.Drawing.Size(253, 22);
            this.saveAsButton.Text = "Сохранить как ...";
            this.saveAsButton.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitButton.Size = new System.Drawing.Size(253, 22);
            this.exitButton.Text = "&Выход";
            this.exitButton.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canvasSizeButton,
            this.toolStripSeparator4,
            this.starsettingsButton});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            this.рисунокToolStripMenuItem.DropDownOpening += new System.EventHandler(this.PictureMenuItem_DropDownOpening);
            // 
            // canvasSizeButton
            // 
            this.canvasSizeButton.Name = "canvasSizeButton";
            this.canvasSizeButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.canvasSizeButton.Size = new System.Drawing.Size(232, 22);
            this.canvasSizeButton.Text = "Размер холста";
            this.canvasSizeButton.Click += new System.EventHandler(this.CanvasSize_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
            // 
            // starsettingsButton
            // 
            this.starsettingsButton.Name = "starsettingsButton";
            this.starsettingsButton.Size = new System.Drawing.Size(232, 22);
            this.starsettingsButton.Text = "Параметры звезды";
            this.starsettingsButton.Click += new System.EventHandler(this.StarSettings_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeButton,
            this.tileVerticalButton,
            this.arrangeButton});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            this.окноToolStripMenuItem.DropDownOpening += new System.EventHandler(this.окноToolStripMenuItem_DropDownOpening);
            // 
            // cascadeButton
            // 
            this.cascadeButton.Name = "cascadeButton";
            this.cascadeButton.Size = new System.Drawing.Size(187, 22);
            this.cascadeButton.Text = "Каскадом";
            this.cascadeButton.Click += new System.EventHandler(this.CascadeLayout_Click);
            // 
            // tileVerticalButton
            // 
            this.tileVerticalButton.Name = "tileVerticalButton";
            this.tileVerticalButton.Size = new System.Drawing.Size(187, 22);
            this.tileVerticalButton.Text = "Слева направо";
            this.tileVerticalButton.Click += new System.EventHandler(this.TileVerticalLayout_Click);
            // 
            // arrangeButton
            // 
            this.arrangeButton.Name = "arrangeButton";
            this.arrangeButton.Size = new System.Drawing.Size(187, 22);
            this.arrangeButton.Text = "Упорядочить значки";
            this.arrangeButton.Click += new System.EventHandler(this.ArrangeIconsLayout_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе ...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutApplication_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSelect,
            this.fillButton,
            this.toolStripLabel2,
            this.toolSelect,
            this.toolStripLabel1,
            this.toolStripLabel5,
            this.toolStripSeparator1,
            this.zoomInButton,
            this.zoomOutButton,
            this.zoomDefaultButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(729, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 24);
            this.toolStripLabel2.Text = "Кисть:";
            // 
            // toolSelect
            // 
            this.toolSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolSelect.Items.AddRange(new object[] {
            "Перо",
            "Заливка",
            "Ластик",
            "Линия",
            "Эллипс",
            "Прямоугольник",
            "Звезда",
            "Текст"});
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(120, 27);
            this.toolSelect.SelectedIndexChanged += new System.EventHandler(this.toolStripSplitButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(57, 24);
            this.toolStripLabel5.Text = "----------";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPosition
            // 
            this.statusLabelPosition.Name = "statusLabelPosition";
            this.statusLabelPosition.Size = new System.Drawing.Size(53, 17);
            this.statusLabelPosition.Text = "X: -- Y:--";
            // 
            // thicknessSelect
            // 
            this.thicknessSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thicknessSelect.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.thicknessSelect.Location = new System.Drawing.Point(257, 28);
            this.thicknessSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.thicknessSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessSelect.Name = "thicknessSelect";
            this.thicknessSelect.Size = new System.Drawing.Size(52, 20);
            this.thicknessSelect.TabIndex = 6;
            this.thicknessSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessSelect.ValueChanged += new System.EventHandler(this.thicknessSelect_ValueChanged);
            // 
            // colorSelect
            // 
            this.colorSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackSelected,
            this.redSelected,
            this.greenSelected,
            this.blueSelected,
            this.toolStripSeparator3,
            this.otherSelected});
            this.colorSelect.Image = ((System.Drawing.Image)(resources.GetObject("colorSelect.Image")));
            this.colorSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(66, 24);
            this.colorSelect.Text = "Цвет";
            // 
            // blackSelected
            // 
            this.blackSelected.Image = global::MyNewPaint.Properties.Resources.black_color;
            this.blackSelected.Name = "blackSelected";
            this.blackSelected.Size = new System.Drawing.Size(127, 26);
            this.blackSelected.Text = "Черный";
            this.blackSelected.Click += new System.EventHandler(this.SetColorBlack_Click);
            // 
            // redSelected
            // 
            this.redSelected.Image = global::MyNewPaint.Properties.Resources.red_color;
            this.redSelected.Name = "redSelected";
            this.redSelected.Size = new System.Drawing.Size(127, 26);
            this.redSelected.Text = "Красный";
            this.redSelected.Click += new System.EventHandler(this.SetColorRed_Click);
            // 
            // greenSelected
            // 
            this.greenSelected.Image = global::MyNewPaint.Properties.Resources.green_color;
            this.greenSelected.Name = "greenSelected";
            this.greenSelected.Size = new System.Drawing.Size(127, 26);
            this.greenSelected.Text = "Зеленый";
            this.greenSelected.Click += new System.EventHandler(this.SetColorGreen_Click);
            // 
            // blueSelected
            // 
            this.blueSelected.Image = global::MyNewPaint.Properties.Resources.blue_color;
            this.blueSelected.Name = "blueSelected";
            this.blueSelected.Size = new System.Drawing.Size(127, 26);
            this.blueSelected.Text = "Синий";
            this.blueSelected.Click += new System.EventHandler(this.SetColorBlue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // otherSelected
            // 
            this.otherSelected.Image = global::MyNewPaint.Properties.Resources.other_color;
            this.otherSelected.Name = "otherSelected";
            this.otherSelected.Size = new System.Drawing.Size(127, 26);
            this.otherSelected.Text = "Другой";
            this.otherSelected.Click += new System.EventHandler(this.SetColorOther_Click);
            // 
            // fillButton
            // 
            this.fillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(24, 24);
            this.fillButton.Text = "toolStripButton1";
            this.fillButton.ToolTipText = "Заливка";
            this.fillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // zoomDefaultButton
            // 
            this.zoomDefaultButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomDefaultButton.Image = global::MyNewPaint.Properties.Resources.zoom_default;
            this.zoomDefaultButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomDefaultButton.Name = "zoomDefaultButton";
            this.zoomDefaultButton.Size = new System.Drawing.Size(24, 24);
            this.zoomDefaultButton.Text = "toolStripButton3";
            this.zoomDefaultButton.Click += new System.EventHandler(this.zoomDefaultButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutButton.Image = global::MyNewPaint.Properties.Resources.zoom_in;
            this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(24, 24);
            this.zoomOutButton.Text = "toolStripButton2";
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInButton.Image = global::MyNewPaint.Properties.Resources.zoom_out;
            this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(24, 24);
            this.zoomInButton.Text = "toolStripButton1";
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(729, 513);
            this.Controls.Add(this.thicknessSelect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MDI Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDocumentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalButton;
        private System.Windows.Forms.ToolStripMenuItem arrangeButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPosition;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canvasSizeButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolSelect;
        private System.Windows.Forms.ToolStripDropDownButton colorSelect;
        private System.Windows.Forms.ToolStripMenuItem blackSelected;
        private System.Windows.Forms.ToolStripMenuItem redSelected;
        private System.Windows.Forms.ToolStripMenuItem greenSelected;
        private System.Windows.Forms.ToolStripMenuItem blueSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem otherSelected;
        private System.Windows.Forms.NumericUpDown thicknessSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem starsettingsButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton fillButton;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.ToolStripButton zoomDefaultButton;
    }
}

