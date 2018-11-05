using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringfieldApp
{
    public partial class SpringfieldApp : Form
    {
        OpenFileDialog oft = new OpenFileDialog();
        string pathPDF, fileNamePDF;
        bool processed = false;

        // pathPDF is the the LOCATION of the pdf file user selected
        // fileNamePDF is the NAME of the pdf file user selected

        public SpringfieldApp()
        {
            InitializeComponent();
            show.Enabled = false;
            process.Enabled = false;
        }
        
        // clickListener for BROWSE Button
        private void browse_Click(object sender, EventArgs e)
        {
            oft.Filter = "PDF(*.pdf) | *.pdf";
            if (oft.ShowDialog() == DialogResult.OK)
            {
                pathPDF = oft.FileName;
                fileNamePDF = oft.SafeFileName;
                browse.Text = fileNamePDF;
                process.Enabled = true;
            }
        }
        
        // clickListener for PROCESS Button
        private void process_Click(object sender, EventArgs e)
        {
            // call the python script on the pdf file
            // path of that pdf is pathPDF

            // once the processing is done
            // show.Enabled = true;
            // processed = true;

            // and save the processed file as csv someWhere
            // so that it can be given to user when he clicks SHOW button
        }

        // clickListener for SHOW Button
        private void show_Click(object sender, EventArgs e)
        {
            if (processed)
            {
                // once the processing is done this button should get activated

                // open the processed csv file
            }
        }
    }
}
