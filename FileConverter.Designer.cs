namespace WinFormsAppTest
{
    partial class FileConverter
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
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            vb6AplicationToolStripMenuItem = new ToolStripMenuItem();
            adminSecurityToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, vb6AplicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // vb6AplicationToolStripMenuItem
            // 
            vb6AplicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminSecurityToolStripMenuItem });
            vb6AplicationToolStripMenuItem.Name = "vb6AplicationToolStripMenuItem";
            vb6AplicationToolStripMenuItem.Size = new Size(93, 20);
            vb6AplicationToolStripMenuItem.Text = "Vb6Aplication";
            // 
            // adminSecurityToolStripMenuItem
            // 
            adminSecurityToolStripMenuItem.Name = "adminSecurityToolStripMenuItem";
            adminSecurityToolStripMenuItem.Size = new Size(180, 22);
            adminSecurityToolStripMenuItem.Text = "Admin Security";
            adminSecurityToolStripMenuItem.Click += adminSecurityToolStripMenuItem_Click_3;
            // 
            // AdminSecurity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminSecurity";
            Text = "File Converter";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem vb6AplicationToolStripMenuItem;
        private ToolStripMenuItem adminSecurityToolStripMenuItem;
    }
}