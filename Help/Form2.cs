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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ToolStripMenuItem downloadTB = new ToolStripMenuItem("Загрузить");
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem saveTB = new ToolStripMenuItem("Сохранить");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { downloadTB, separator, saveTB });
            textBox1.ContextMenuStrip = contextMenuStrip1;
            downloadTB.Click += downloadTB_Click;
            saveTB.Click += saveTB_Click;
        }

        private void downloadTB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                textBox1.Text = text;
            }
        }
        private void saveTB_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
