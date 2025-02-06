﻿namespace MyNewPaint
{
    partial class CanvasSizeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.widthSelect = new System.Windows.Forms.NumericUpDown();
            this.heightSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 106);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(96, 106);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // widthSelect
            // 
            this.widthSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthSelect.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.widthSelect.Location = new System.Drawing.Point(77, 24);
            this.widthSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthSelect.Name = "widthSelect";
            this.widthSelect.Size = new System.Drawing.Size(81, 20);
            this.widthSelect.TabIndex = 7;
            this.widthSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // heightSelect
            // 
            this.heightSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightSelect.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.heightSelect.Location = new System.Drawing.Point(77, 61);
            this.heightSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightSelect.Name = "heightSelect";
            this.heightSelect.Size = new System.Drawing.Size(81, 20);
            this.heightSelect.TabIndex = 8;
            this.heightSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CanvasSizeForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(183, 141);
            this.Controls.Add(this.heightSelect);
            this.Controls.Add(this.widthSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Размер холста";
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown widthSelect;
        private System.Windows.Forms.NumericUpDown heightSelect;
    }
}