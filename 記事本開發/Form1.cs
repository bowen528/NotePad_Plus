using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記事本開發
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxbx.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void OFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxbx.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                rTxbx.SelectionFont = fontDialog1.Font;
            }
        }

        private void FCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                rTxbx.SelectionColor = colorDialog1.Color;
            }
        }

        private void BCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxbx.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("確定結束程式 ？","結束程式",
               MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            
            
        }
    }
}
