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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            openLabel1.Click += openL_Click;
            saveLabel1.Click += saveL_Click;
            fontComboBox1.SelectedIndexChanged += font_change;
            sizeTextBox1.TextChanged += size_change;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void openL_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                textBox1.Text = text;
            }
        }
        private void saveL_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text);
            }
        }
        private void font_change(object sender, EventArgs e)
        {
            textBox1.Font = 
                new Font(fontComboBox1.SelectedItem.ToString(),
                textBox1.Font.Size);
        }
        private void size_change(object sender, EventArgs e)
        {
            int? size = null;
            try
            {
                size = int.Parse(sizeTextBox1.Text);
            }
            catch { }
            if (size != null)
            {
                textBox1.Font =
                new Font(textBox1.Font.FontFamily,
                (float)size);
            }
        }
    }
}
