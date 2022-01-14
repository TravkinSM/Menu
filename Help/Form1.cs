using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Help
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            helpMenuItem.Click += helpMenuItem_Click;
            saveMenuItem.Click += saveMenuItem_Click;
            downloadMenuItem.Click += downloadMenuItem_Click;
            saveMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            downloadMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text);
            }
        }
        private void downloadMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                textBox1.Text = text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
