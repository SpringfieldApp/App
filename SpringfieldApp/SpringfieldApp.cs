using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;


namespace SpringfieldApp
{
    public partial class SpringfieldApp : Form
    {
        OpenFileDialog oft = new OpenFileDialog();
        string pathPDF, fileNamePDF;
        bool processed = false;
        private string path;
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
            oft.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

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

            // Here instead pf fileNamePDF the python executeable file should come 
            doPython();
            // once the processing is done
             show.Enabled = true;
             processed = true;

            // and save the processed file as csv someWhere

            path = @"C:\temp\Saved Files\saved_data.txt";
            File.WriteAllText(path, result);
            // so that it can be given to user when he clicks SHOW button
        }

        // clickListener for SHOW Button
        private void show_Click(object sender, EventArgs e)
        {
            if (processed)
            {
                // once the processing is done this button should get activated
                File.OpenText(path);
                // open the processed csv file
            }
        }

        private void springFieldHeader_Click(object sender, EventArgs e)
        {

        }

        // function to call python scripts and return csv file of the processed data

        private static void doPython()
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.ExecuteFile(@"code.py");
        }
    }
}


