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
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыЗвездыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colorSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.redSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.greenSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.blueSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.otherSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolSelect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.thicknessSelect = new System.Windows.Forms.NumericUpDown();
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
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveButton,
            this.SaveAsButton,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            this.файлToolStripMenuItem.DropDownOpening += new System.EventHandler(this.файлToolStripMenuItem_DropDownOpening);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.новыйToolStripMenuItem.Text = "&Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.NewDocument_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.FileOpen_Click);
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
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsButton.Size = new System.Drawing.Size(253, 22);
            this.SaveAsButton.Text = "Сохранить как ...";
            this.SaveAsButton.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem,
            this.параметрыЗвездыToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.размерХолстаToolStripMenuItem.Text = "Размер холста";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.CanvasSize_Click);
            // 
            // параметрыЗвездыToolStripMenuItem
            // 
            this.параметрыЗвездыToolStripMenuItem.Name = "параметрыЗвездыToolStripMenuItem";
            this.параметрыЗвездыToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.параметрыЗвездыToolStripMenuItem.Text = "Параметры звезды";
            this.параметрыЗвездыToolStripMenuItem.Click += new System.EventHandler(this.StarSettings_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.CascadeLayout_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalLayout_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsLayout_Click);
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
            this.toolStripLabel2,
            this.toolSelect,
            this.toolStripLabel1,
            this.toolStripLabel5,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(729, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            this.blackSelected.Image = ((System.Drawing.Image)(resources.GetObject("blackSelected.Image")));
            this.blackSelected.Name = "blackSelected";
            this.blackSelected.Size = new System.Drawing.Size(123, 22);
            this.blackSelected.Text = "Черный";
            this.blackSelected.Click += new System.EventHandler(this.SetColorBlack_Click);
            // 
            // redSelected
            // 
            this.redSelected.Image = ((System.Drawing.Image)(resources.GetObject("redSelected.Image")));
            this.redSelected.Name = "redSelected";
            this.redSelected.Size = new System.Drawing.Size(123, 22);
            this.redSelected.Text = "Красный";
            this.redSelected.Click += new System.EventHandler(this.SetColorRed_Click);
            // 
            // greenSelected
            // 
            this.greenSelected.Image = ((System.Drawing.Image)(resources.GetObject("greenSelected.Image")));
            this.greenSelected.Name = "greenSelected";
            this.greenSelected.Size = new System.Drawing.Size(123, 22);
            this.greenSelected.Text = "Зеленый";
            this.greenSelected.Click += new System.EventHandler(this.SetColorGreen_Click);
            // 
            // blueSelected
            // 
            this.blueSelected.Image = ((System.Drawing.Image)(resources.GetObject("blueSelected.Image")));
            this.blueSelected.Name = "blueSelected";
            this.blueSelected.Size = new System.Drawing.Size(123, 22);
            this.blueSelected.Text = "Синий";
            this.blueSelected.Click += new System.EventHandler(this.SetColorBlue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
            // 
            // otherSelected
            // 
            this.otherSelected.Image = ((System.Drawing.Image)(resources.GetObject("otherSelected.Image")));
            this.otherSelected.Name = "otherSelected";
            this.otherSelected.Size = new System.Drawing.Size(123, 22);
            this.otherSelected.Text = "Другой";
            this.otherSelected.Click += new System.EventHandler(this.SetColorOther_Click);
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
            this.thicknessSelect.Location = new System.Drawing.Point(231, 28);
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
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPosition;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem параметрыЗвездыToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

