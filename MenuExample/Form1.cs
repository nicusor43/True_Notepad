using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void decupeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void lipesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void copiazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy(); 
        }

        private void decupesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void lipesteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save File";

            saveFileDialog1.DefaultExt = ".rtf";

            saveFileDialog1.OverwritePrompt = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";

            openFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files(*.txt)|*.txt";

            openFileDialog1.FileName = "";

            openFileDialog1.InitialDirectory = "Documents";

            openFileDialog1.CheckFileExists = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;

            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowPaper = true;
            //etc etc;

            if(pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionColor = colorDialog1.Color;
            }
        }

        
    }
}
