namespace MyNewPaint
{
    partial class PluginManagerForm
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
            this.pluginsGridView = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pluginsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pluginsGridView
            // 
            this.pluginsGridView.AllowUserToAddRows = false;
            this.pluginsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pluginsGridView.Location = new System.Drawing.Point(9, 10);
            this.pluginsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pluginsGridView.Name = "pluginsGridView";
            this.pluginsGridView.RowHeadersWidth = 51;
            this.pluginsGridView.RowTemplate.Height = 24;
            this.pluginsGridView.Size = new System.Drawing.Size(582, 303);
            this.pluginsGridView.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(489, 318);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 38);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PluginManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pluginsGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PluginManagerForm";
            this.Text = "PluginManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pluginsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pluginsGridView;
        private System.Windows.Forms.Button btn_Save;
    }
}