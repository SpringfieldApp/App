namespace SpringField
{
    partial class DocumentControl
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
            this.Browse = new System.Windows.Forms.Button();
            this.DocType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Browse.Location = new System.Drawing.Point(41, 0);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(99, 37);
            this.Browse.TabIndex = 11;
            this.Browse.Text = "BROWSE";
            this.Browse.UseVisualStyleBackColor = true;
            // 
            // DocType
            // 
            this.DocType.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocType.FormattingEnabled = true;
            this.DocType.Location = new System.Drawing.Point(197, 8);
            this.DocType.Name = "DocType";
            this.DocType.Size = new System.Drawing.Size(99, 25);
            this.DocType.TabIndex = 14;
            this.DocType.Text = "    TYPE";
            // 
            // DocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocType);
            this.Controls.Add(this.Browse);
            this.Name = "DocumentControl";
            this.Size = new System.Drawing.Size(332, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ComboBox DocType;
    }
}
