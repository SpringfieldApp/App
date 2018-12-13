namespace SpringField
{
    partial class SpringFieldControl
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
            this.UserGuide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserGuide
            // 
            this.UserGuide.FlatAppearance.BorderSize = 0;
            this.UserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserGuide.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.UserGuide.Location = new System.Drawing.Point(421, 204);
            this.UserGuide.Name = "UserGuide";
            this.UserGuide.Size = new System.Drawing.Size(148, 46);
            this.UserGuide.TabIndex = 3;
            this.UserGuide.Text = "User Guide";
            this.UserGuide.UseVisualStyleBackColor = true;
            this.UserGuide.Click += new System.EventHandler(this.UserGuide_Click);
            // 
            // SpringFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserGuide);
            this.Name = "SpringFieldControl";
            this.Size = new System.Drawing.Size(639, 310);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UserGuide;
    }
}
