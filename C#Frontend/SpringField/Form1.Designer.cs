namespace SpringField
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.UploadProcess = new System.Windows.Forms.Button();
            this.AddRules = new System.Windows.Forms.Button();
            this.SpringField = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeControl = new SpringField.SpringFieldControl();
            this.UploadProcessControl = new SpringField.UploadProcessControl();
            this.RulesControl = new SpringField.RulesControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.UploadProcess);
            this.panel1.Controls.Add(this.AddRules);
            this.panel1.Controls.Add(this.SpringField);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 450);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 39);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 54);
            this.SidePanel.TabIndex = 1;
            // 
            // UploadProcess
            // 
            this.UploadProcess.FlatAppearance.BorderSize = 0;
            this.UploadProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadProcess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadProcess.ForeColor = System.Drawing.Color.White;
            this.UploadProcess.Location = new System.Drawing.Point(9, 147);
            this.UploadProcess.Name = "UploadProcess";
            this.UploadProcess.Size = new System.Drawing.Size(161, 54);
            this.UploadProcess.TabIndex = 1;
            this.UploadProcess.Text = "Upload | Process";
            this.UploadProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UploadProcess.UseVisualStyleBackColor = true;
            this.UploadProcess.Click += new System.EventHandler(this.UploadProcess_Click);
            // 
            // AddRules
            // 
            this.AddRules.FlatAppearance.BorderSize = 0;
            this.AddRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRules.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRules.ForeColor = System.Drawing.Color.White;
            this.AddRules.Location = new System.Drawing.Point(9, 93);
            this.AddRules.Name = "AddRules";
            this.AddRules.Size = new System.Drawing.Size(161, 54);
            this.AddRules.TabIndex = 2;
            this.AddRules.Text = "Add Rules";
            this.AddRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRules.UseVisualStyleBackColor = true;
            this.AddRules.Click += new System.EventHandler(this.AddRules_Click);
            // 
            // SpringField
            // 
            this.SpringField.FlatAppearance.BorderSize = 0;
            this.SpringField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpringField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringField.ForeColor = System.Drawing.Color.White;
            this.SpringField.Location = new System.Drawing.Point(9, 39);
            this.SpringField.Name = "SpringField";
            this.SpringField.Size = new System.Drawing.Size(161, 54);
            this.SpringField.TabIndex = 3;
            this.SpringField.Text = "SpringField";
            this.SpringField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpringField.UseVisualStyleBackColor = true;
            this.SpringField.Click += new System.EventHandler(this.SpringField_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "App for SpringField Challenge \'18";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(293, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "SpringField";
            // 
            // HomeControl
            // 
            this.HomeControl.Location = new System.Drawing.Point(176, 140);
            this.HomeControl.Name = "HomeControl";
            this.HomeControl.Size = new System.Drawing.Size(619, 310);
            this.HomeControl.TabIndex = 8;
            // 
            // UploadProcessControl
            // 
            this.UploadProcessControl.Location = new System.Drawing.Point(176, 124);
            this.UploadProcessControl.Name = "UploadProcessControl";
            this.UploadProcessControl.Size = new System.Drawing.Size(619, 326);
            this.UploadProcessControl.TabIndex = 9;
            // 
            // RulesControl
            // 
            this.RulesControl.Location = new System.Drawing.Point(198, 120);
            this.RulesControl.Name = "RulesControl";
            this.RulesControl.Size = new System.Drawing.Size(590, 324);
            this.RulesControl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UploadProcessControl);
            this.Controls.Add(this.HomeControl);
            this.Controls.Add(this.RulesControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SpringField";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UploadProcess;
        private System.Windows.Forms.Button AddRules;
        private System.Windows.Forms.Button SpringField;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SpringFieldControl HomeControl;
        private UploadProcessControl UploadProcessControl;
        private RulesControl RulesControl;
    }
}

