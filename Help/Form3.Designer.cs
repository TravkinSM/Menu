
namespace Help
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.saveLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fontComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.sizeTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLabel1,
            this.saveLabel1,
            this.fontComboBox1,
            this.sizeTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(415, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // openLabel1
            // 
            this.openLabel1.Image = ((System.Drawing.Image)(resources.GetObject("openLabel1.Image")));
            this.openLabel1.Name = "openLabel1";
            this.openLabel1.Size = new System.Drawing.Size(16, 22);
            // 
            // saveLabel1
            // 
            this.saveLabel1.Image = global::Help.Properties.Resources.Скачать;
            this.saveLabel1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.saveLabel1.Name = "saveLabel1";
            this.saveLabel1.Size = new System.Drawing.Size(16, 22);
            // 
            // fontComboBox1
            // 
            this.fontComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fontComboBox1.Items.AddRange(new object[] {
            "Segoe UI",
            "Times New Roman",
            "Calibri"});
            this.fontComboBox1.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.fontComboBox1.Name = "fontComboBox1";
            this.fontComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // sizeTextBox1
            // 
            this.sizeTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sizeTextBox1.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.sizeTextBox1.MaxLength = 2;
            this.sizeTextBox1.Name = "sizeTextBox1";
            this.sizeTextBox1.Size = new System.Drawing.Size(30, 25);
            this.sizeTextBox1.Text = "9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 161);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 201);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel openLabel1;
        private System.Windows.Forms.ToolStripLabel saveLabel1;
        private System.Windows.Forms.ToolStripComboBox fontComboBox1;
        private System.Windows.Forms.ToolStripTextBox sizeTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}