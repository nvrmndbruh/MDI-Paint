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
            this.buttonCancel.Location = new System.Drawing.Point(145, 122);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(37, 122);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отношение радиусов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число лучей";
            // 
            // verticiesSelect
            // 
            this.verticiesSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticiesSelect.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.verticiesSelect.Location = new System.Drawing.Point(186, 25);
            this.verticiesSelect.Margin = new System.Windows.Forms.Padding(4);
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
            this.verticiesSelect.Size = new System.Drawing.Size(59, 22);
            this.verticiesSelect.TabIndex = 13;
            this.verticiesSelect.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.verticiesSelect.ValueChanged += new System.EventHandler(this.verticiesSelect_ValueChanged);
            // 
            // radiusRatioSelect
            // 
            this.radiusRatioSelect.Location = new System.Drawing.Point(186, 71);
            this.radiusRatioSelect.Mask = "0.00";
            this.radiusRatioSelect.Name = "radiusRatioSelect";
            this.radiusRatioSelect.Size = new System.Drawing.Size(37, 22);
            this.radiusRatioSelect.TabIndex = 14;
            this.radiusRatioSelect.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.radiusRatioSelect_MaskInputRejected);
            // 
            // StarSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 175);
            this.Controls.Add(this.radiusRatioSelect);
            this.Controls.Add(this.verticiesSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StarSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
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