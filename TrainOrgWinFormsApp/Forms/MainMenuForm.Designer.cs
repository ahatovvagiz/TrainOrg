namespace TrainOrgWinFormsApp.Forms
{
    partial class MainMenuForm
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
            sessionsToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBoxNewSession = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sessionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // sessionsToolStripMenuItem
            // 
            sessionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxNewSession });
            sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            sessionsToolStripMenuItem.Size = new Size(63, 20);
            sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // toolStripTextBoxNewSession
            // 
            toolStripTextBoxNewSession.Name = "toolStripTextBoxNewSession";
            toolStripTextBoxNewSession.Size = new Size(100, 23);
            toolStripTextBoxNewSession.Text = "New Session";
            toolStripTextBoxNewSession.Click += toolStripTextBoxNewSession_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sessionsToolStripMenuItem;
        private ToolStripTextBox toolStripTextBoxNewSession;
    }
}