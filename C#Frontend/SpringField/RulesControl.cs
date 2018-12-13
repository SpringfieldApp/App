using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpringField
{
    public partial class RulesControl : UserControl
    {
        string[] fields;
        int xLoc = 50, yLoc = 30;
        ArrayList types;

        public RulesControl()
        {
            InitializeComponent();
            types = new ArrayList();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            fields = KeyFieldTextBox.Lines;
            string path = @"D:\Yash\Codes\SpringField\App\Rules\" + DocTypeText.Text + ".txt";
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            File.WriteAllLines(path, fields);

            Label typeLab = new Label();
            typeLab.Width = 220;
            typeLab.Location = new Point(xLoc, yLoc);
            typeLab.Text = DocTypeText.Text.ToUpper();
            this.RulesPanel.Controls.Add(typeLab);
            yLoc += 35;

            types.Add(DocTypeText.Text);
            File.WriteAllLines(@"D:\Yash\Codes\SpringField\App\C#Frontend\types\types.txt", Array.ConvertAll(types.ToArray(), x => x.ToString()));

            KeyFieldTextBox.Text = "";
            DocTypeText.Text = "";
        }
    }
}