﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringField
{
    public partial class SpringFieldControl : UserControl
    {
        public SpringFieldControl()
        {
            InitializeComponent();
        }

        private void UserGuide_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Yash\Codes\SpringField\App\User_Guide.pdf");
        }
    }
}
