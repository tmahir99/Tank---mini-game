namespace Tenkovi
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.podlogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 120;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podlogaToolStripMenuItem,
            this.rezimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 537);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podlogaToolStripMenuItem
            // 
            this.podlogaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zidToolStripMenuItem,
            this.travaToolStripMenuItem});
            this.podlogaToolStripMenuItem.Name = "podlogaToolStripMenuItem";
            this.podlogaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.podlogaToolStripMenuItem.Text = "Podloga";
            // 
            // travaToolStripMenuItem
            // 
            this.travaToolStripMenuItem.Name = "travaToolStripMenuItem";
            this.travaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.travaToolStripMenuItem.Text = "Trava";
            this.travaToolStripMenuItem.Click += new System.EventHandler(this.travaToolStripMenuItem_Click);
            // 
            // zidToolStripMenuItem
            // 
            this.zidToolStripMenuItem.Name = "zidToolStripMenuItem";
            this.zidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zidToolStripMenuItem.Text = "Zid";
            this.zidToolStripMenuItem.Click += new System.EventHandler(this.zidToolStripMenuItem_Click);
            // 
            // rezimToolStripMenuItem
            // 
            this.rezimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradiToolStripMenuItem,
            this.igrajToolStripMenuItem});
            this.rezimToolStripMenuItem.Name = "rezimToolStripMenuItem";
            this.rezimToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.rezimToolStripMenuItem.Text = "Rezim";
            // 
            // igrajToolStripMenuItem
            // 
            this.igrajToolStripMenuItem.Name = "igrajToolStripMenuItem";
            this.igrajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.igrajToolStripMenuItem.Text = "Igraj";
            this.igrajToolStripMenuItem.Click += new System.EventHandler(this.igrajToolStripMenuItem_Click);
            // 
            // gradiToolStripMenuItem
            // 
            this.gradiToolStripMenuItem.Name = "gradiToolStripMenuItem";
            this.gradiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradiToolStripMenuItem.Text = "Gradi";
            this.gradiToolStripMenuItem.Click += new System.EventHandler(this.gradiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podlogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrajToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

