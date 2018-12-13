using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Top = SpringField.Top;
            HomeControl.BringToFront();
        }

        private void SpringField_Click(object sender, EventArgs e)
        {
            SidePanel.Top = SpringField.Top;
            HomeControl.BringToFront();
        }

        private void AddRules_Click(object sender, EventArgs e)
        {
            SidePanel.Top = AddRules.Top;
            RulesControl.BringToFront();
        }

        private void UploadProcess_Click(object sender, EventArgs e)
        {
            SidePanel.Top = UploadProcess.Top;
            UploadProcessControl.BringToFront();
            UploadProcessControl.updateCombo();
        }
    }
}