namespace SpringfieldApp
{
    partial class RulePage
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
            this.keyfields = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.textarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key Fields";
            // 
            // keyfields
            // 
            this.keyfields.Location = new System.Drawing.Point(184, 52);
            this.keyfields.Multiline = true;
            this.keyfields.Name = "keyfields";
            this.keyfields.Size = new System.Drawing.Size(381, 20);
            this.keyfields.TabIndex = 4;
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(427, 119);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(108, 23);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // textarea
            // 
            this.textarea.Location = new System.Drawing.Point(77, 174);
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(488, 20);
            this.textarea.TabIndex = 3;
            // 
            // RulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 319);
            this.Controls.Add(this.textarea);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.keyfields);
            this.Controls.Add(this.label1);
            this.Name = "RulePage";
            this.Text = "RulePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyfields;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textarea;
    }
}