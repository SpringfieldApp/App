namespace SpringfieldApp
{
    partial class SpringfieldApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpringfieldApp));
            this.springFieldHeader = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // springFieldHeader
            // 
            resources.ApplyResources(this.springFieldHeader, "springFieldHeader");
            this.springFieldHeader.Name = "springFieldHeader";
            // 
            // upload
            // 
            resources.ApplyResources(this.upload, "upload");
            this.upload.Name = "upload";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.browse, "browse");
            this.browse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browse.Name = "browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // process
            // 
            this.process.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.process, "process");
            this.process.ForeColor = System.Drawing.Color.White;
            this.process.Name = "process";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // processLabel
            // 
            resources.ApplyResources(this.processLabel, "processLabel");
            this.processLabel.Name = "processLabel";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.show, "show");
            this.show.Name = "show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // create
            // 
            resources.ApplyResources(this.create, "create");
            this.create.Name = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // SpringfieldApp
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.process);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.springFieldHeader);
            this.Name = "SpringfieldApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label processedLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label springFieldHeader;
        private System.Windows.Forms.Label upload;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
    }
}

