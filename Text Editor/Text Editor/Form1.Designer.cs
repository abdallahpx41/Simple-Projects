namespace Text_Editor
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITBACKGROUNDCOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITTEXTSIZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(666, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITToolStripMenuItem,
            this.eDITBACKGROUNDCOLORToolStripMenuItem,
            this.eDITTEXTSIZEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.eDITToolStripMenuItem.Text = "EDIT TEXT COLOR";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // eDITBACKGROUNDCOLORToolStripMenuItem
            // 
            this.eDITBACKGROUNDCOLORToolStripMenuItem.Name = "eDITBACKGROUNDCOLORToolStripMenuItem";
            this.eDITBACKGROUNDCOLORToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.eDITBACKGROUNDCOLORToolStripMenuItem.Text = "EDIT BACKGROUND COLOR";
            this.eDITBACKGROUNDCOLORToolStripMenuItem.Click += new System.EventHandler(this.eDITBACKGROUNDCOLORToolStripMenuItem_Click);
            // 
            // eDITTEXTSIZEToolStripMenuItem
            // 
            this.eDITTEXTSIZEToolStripMenuItem.Name = "eDITTEXTSIZEToolStripMenuItem";
            this.eDITTEXTSIZEToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.eDITTEXTSIZEToolStripMenuItem.Text = "EDIT TEXT SIZE";
            this.eDITTEXTSIZEToolStripMenuItem.Click += new System.EventHandler(this.eDITTEXTSIZEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 445);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem eDITBACKGROUNDCOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITTEXTSIZEToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

