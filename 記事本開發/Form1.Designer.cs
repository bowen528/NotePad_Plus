
namespace 記事本開發
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rTxbx = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxbx
            // 
            this.rTxbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxbx.Location = new System.Drawing.Point(0, 24);
            this.rTxbx.Name = "rTxbx";
            this.rTxbx.Size = new System.Drawing.Size(800, 426);
            this.rTxbx.TabIndex = 0;
            this.rTxbx.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.格式設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SFToolStripMenuItem,
            this.OFToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // SFToolStripMenuItem
            // 
            this.SFToolStripMenuItem.Name = "SFToolStripMenuItem";
            this.SFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SFToolStripMenuItem.Text = "儲存檔案";
            this.SFToolStripMenuItem.Click += new System.EventHandler(this.SFToolStripMenuItem_Click);
            // 
            // OFToolStripMenuItem
            // 
            this.OFToolStripMenuItem.Name = "OFToolStripMenuItem";
            this.OFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OFToolStripMenuItem.Text = "開啟舊檔";
            this.OFToolStripMenuItem.Click += new System.EventHandler(this.OFToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.ShowShortcutKeys = false;
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "結束";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 格式設定ToolStripMenuItem
            // 
            this.格式設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.ColorToolStripMenuItem});
            this.格式設定ToolStripMenuItem.Name = "格式設定ToolStripMenuItem";
            this.格式設定ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.格式設定ToolStripMenuItem.Text = "格式設定";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.FontToolStripMenuItem.Text = "字型";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FCToolStripMenuItem,
            this.BCToolStripMenuItem});
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ColorToolStripMenuItem.Text = "色彩";
            // 
            // FCToolStripMenuItem
            // 
            this.FCToolStripMenuItem.Name = "FCToolStripMenuItem";
            this.FCToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.FCToolStripMenuItem.Text = "前景色";
            this.FCToolStripMenuItem.Click += new System.EventHandler(this.FCToolStripMenuItem_Click);
            // 
            // BCToolStripMenuItem
            // 
            this.BCToolStripMenuItem.Name = "BCToolStripMenuItem";
            this.BCToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.BCToolStripMenuItem.Text = "背景色";
            this.BCToolStripMenuItem.Click += new System.EventHandler(this.BCToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "test";
            this.saveFileDialog1.FileName = "Save_demo";
            this.saveFileDialog1.Title = "準備開始存檔";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NotePad Plus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BCToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

