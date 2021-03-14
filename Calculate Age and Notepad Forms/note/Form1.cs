using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note
{
    public partial class Form1 : Form
    {
        public string filePath { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.SelectionFont = fontDialog1.Font;
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.SelectionColor = colorDialog1.Color;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.LoadFile(openFileDialog1.FileName);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath is null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.SaveFile(saveFileDialog1.FileName);
                    filePath = saveFileDialog1.FileName;
                }
            }
            else textBox1.SaveFile(filePath);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SaveFile(saveFileDialog1.FileName);
                filePath = saveFileDialog1.FileName;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit?", "Exit",
                MessageBoxButtons.YesNoCancel
                );
            if (result == DialogResult.Yes)
            {
                if (textBox1.TextLength != 0)
                    saveToolStripMenuItem_Click(this, new EventArgs());
                this.Close();
            }
        }
    }
}