namespace SpringField
{
    partial class UploadProcessControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.Browse = new System.Windows.Forms.Button();
            this.DocType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(223, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "UPLOAD DOCUMENT";
            // 
            // Show
            // 
            this.Show.FlatAppearance.BorderSize = 0;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Show.Location = new System.Drawing.Point(490, 272);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(99, 37);
            this.Show.TabIndex = 12;
            this.Show.Text = "SHOW";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Process
            // 
            this.Process.FlatAppearance.BorderSize = 0;
            this.Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Process.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Process.Location = new System.Drawing.Point(385, 272);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(99, 37);
            this.Process.TabIndex = 13;
            this.Process.Text = "PROCESS";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.AutoScroll = true;
            this.DetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsPanel.Location = new System.Drawing.Point(63, 105);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(496, 161);
            this.DetailsPanel.TabIndex = 15;
            // 
            // Browse
            // 
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Browse.Location = new System.Drawing.Point(141, 66);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(79, 33);
            this.Browse.TabIndex = 16;
            this.Browse.Text = "BROWSE";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // DocType
            // 
            this.DocType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocType.FormattingEnabled = true;
            this.DocType.Location = new System.Drawing.Point(341, 69);
            this.DocType.Name = "DocType";
            this.DocType.Size = new System.Drawing.Size(118, 28);
            this.DocType.TabIndex = 17;
            this.DocType.Text = "    TYPE";
            this.DocType.SelectedIndexChanged += new System.EventHandler(this.DocType_SelectedIndexChanged);
            // 
            // UploadProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocType);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label3);
            this.Name = "UploadProcessControl";
            this.Size = new System.Drawing.Size(619, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ComboBox DocType;
    }
}
