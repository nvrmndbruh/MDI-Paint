namespace MyNewPaint
{
    partial class StarSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verticiesSelect = new System.Windows.Forms.NumericUpDown();
            this.radiusRatioSelect = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.verticiesSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(109, 99);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(28, 99);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отношение радиусов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число лучей";
            // 
            // verticiesSelect
            // 
            this.verticiesSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticiesSelect.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.verticiesSelect.Location = new System.Drawing.Point(140, 20);
            this.verticiesSelect.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.verticiesSelect.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.verticiesSelect.Name = "verticiesSelect";
            this.verticiesSelect.Size = new System.Drawing.Size(44, 20);
            this.verticiesSelect.TabIndex = 13;
            this.verticiesSelect.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.verticiesSelect.ValueChanged += new System.EventHandler(this.PointCountSelect);
            // 
            // radiusRatioSelect
            // 
            this.radiusRatioSelect.Location = new System.Drawing.Point(140, 58);
            this.radiusRatioSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiusRatioSelect.Mask = "0.00";
            this.radiusRatioSelect.Name = "radiusRatioSelect";
            this.radiusRatioSelect.Size = new System.Drawing.Size(29, 20);
            this.radiusRatioSelect.TabIndex = 14;
            this.radiusRatioSelect.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.RadiusRatioSelect_MaskInputRejected);
            // 
            // StarSettingsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(221, 142);
            this.Controls.Add(this.radiusRatioSelect);
            this.Controls.Add(this.verticiesSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StarSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки звезды";
            ((System.ComponentModel.ISupportInitialize)(this.verticiesSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown verticiesSelect;
        private System.Windows.Forms.MaskedTextBox radiusRatioSelect;
    }
}