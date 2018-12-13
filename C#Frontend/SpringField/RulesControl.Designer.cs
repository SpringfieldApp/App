namespace SpringField
{
    partial class RulesControl
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
            this.RulesPanel = new System.Windows.Forms.Panel();
            this.DocTypeText = new System.Windows.Forms.TextBox();
            this.KeyFieldTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RulesPanel
            // 
            this.RulesPanel.AutoScroll = true;
            this.RulesPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesPanel.Location = new System.Drawing.Point(0, 0);
            this.RulesPanel.Name = "RulesPanel";
            this.RulesPanel.Size = new System.Drawing.Size(311, 324);
            this.RulesPanel.TabIndex = 0;
            // 
            // DocTypeText
            // 
            this.DocTypeText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTypeText.Location = new System.Drawing.Point(354, 64);
            this.DocTypeText.Name = "DocTypeText";
            this.DocTypeText.Size = new System.Drawing.Size(205, 26);
            this.DocTypeText.TabIndex = 1;
            // 
            // KeyFieldTextBox
            // 
            this.KeyFieldTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyFieldTextBox.Location = new System.Drawing.Point(354, 151);
            this.KeyFieldTextBox.Multiline = true;
            this.KeyFieldTextBox.Name = "KeyFieldTextBox";
            this.KeyFieldTextBox.Size = new System.Drawing.Size(205, 117);
            this.KeyFieldTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(350, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Document Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(350, 112);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key Fields";
            // 
            // Browse
            // 
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Browse.Location = new System.Drawing.Point(480, 284);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(79, 33);
            this.Browse.TabIndex = 17;
            this.Browse.Text = "ADD";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // RulesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyFieldTextBox);
            this.Controls.Add(this.DocTypeText);
            this.Controls.Add(this.RulesPanel);
            this.Name = "RulesControl";
            this.Size = new System.Drawing.Size(590, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RulesPanel;
        private System.Windows.Forms.TextBox DocTypeText;
        private System.Windows.Forms.TextBox KeyFieldTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Browse;
    }
}
