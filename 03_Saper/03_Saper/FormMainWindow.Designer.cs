namespace _03_Saper
{
    partial class FormMainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sredniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prostaToolStripMenuItem,
            this.sredniaToolStripMenuItem,
            this.trudnaToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // prostaToolStripMenuItem
            // 
            this.prostaToolStripMenuItem.Name = "prostaToolStripMenuItem";
            this.prostaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prostaToolStripMenuItem.Text = "Prosta";
            this.prostaToolStripMenuItem.Click += new System.EventHandler(this.prostaToolStripMenuItem_Click);
            // 
            // sredniaToolStripMenuItem
            // 
            this.sredniaToolStripMenuItem.Name = "sredniaToolStripMenuItem";
            this.sredniaToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.sredniaToolStripMenuItem.Text = "Srednia";
            this.sredniaToolStripMenuItem.Click += new System.EventHandler(this.sredniaToolStripMenuItem_Click);
            // 
            // trudnaToolStripMenuItem
            // 
            this.trudnaToolStripMenuItem.Name = "trudnaToolStripMenuItem";
            this.trudnaToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.trudnaToolStripMenuItem.Text = "Trudna";
            this.trudnaToolStripMenuItem.Click += new System.EventHandler(this.trudnaToolStripMenuItem_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 28);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 422);
            this.panelButtons.TabIndex = 1;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainWindow";
            this.Text = "Saper v0.1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sredniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnaToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
    }
}

