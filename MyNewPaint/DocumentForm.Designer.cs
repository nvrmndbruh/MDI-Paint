﻿namespace MyNewPaint
{
    partial class DocumentForm
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
            this.SuspendLayout();
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocumentForm";
            this.Text = "DocumentForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DocumentForm_MouseDown);
            this.MouseLeave += new System.EventHandler(this.DocumentForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DocumentForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DocumentForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}