namespace DBTrial
{
    partial class MainForm
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
            this.MainformMenuStrip = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowIncassos = new System.Windows.Forms.ToolStripMenuItem();
            this.MainformMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainformMenuStrip
            // 
            this.MainformMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.databasesToolStripMenuItem});
            this.MainformMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainformMenuStrip.Name = "MainformMenuStrip";
            this.MainformMenuStrip.Size = new System.Drawing.Size(875, 24);
            this.MainformMenuStrip.TabIndex = 1;
            this.MainformMenuStrip.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportMembers,
            this.ImportEvent});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // ImportMembers
            // 
            this.ImportMembers.Name = "ImportMembers";
            this.ImportMembers.Size = new System.Drawing.Size(180, 22);
            this.ImportMembers.Text = "Members";
            this.ImportMembers.Click += new System.EventHandler(this.ImportMembers_Click);
            // 
            // ImportEvent
            // 
            this.ImportEvent.Name = "ImportEvent";
            this.ImportEvent.Size = new System.Drawing.Size(180, 22);
            this.ImportEvent.Text = "Event";
            this.ImportEvent.Click += new System.EventHandler(this.ImportEvent_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMembers,
            this.ShowEvents,
            this.ShowIncassos});
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // ShowMembers
            // 
            this.ShowMembers.Name = "ShowMembers";
            this.ShowMembers.Size = new System.Drawing.Size(124, 22);
            this.ShowMembers.Text = "Members";
            this.ShowMembers.Click += new System.EventHandler(this.ShowMembers_Click);
            // 
            // ShowEvents
            // 
            this.ShowEvents.Name = "ShowEvents";
            this.ShowEvents.Size = new System.Drawing.Size(124, 22);
            this.ShowEvents.Text = "Events";
            this.ShowEvents.Click += new System.EventHandler(this.ShowEvents_Click);
            // 
            // ShowIncassos
            // 
            this.ShowIncassos.Name = "ShowIncassos";
            this.ShowIncassos.Size = new System.Drawing.Size(124, 22);
            this.ShowIncassos.Text = "Incassos";
            this.ShowIncassos.Click += new System.EventHandler(this.ShowIncassos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(875, 684);
            this.Controls.Add(this.MainformMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainformMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.MainformMenuStrip.ResumeLayout(false);
            this.MainformMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainformMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportMembers;
        private System.Windows.Forms.ToolStripMenuItem ImportEvent;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMembers;
        private System.Windows.Forms.ToolStripMenuItem ShowEvents;
        private System.Windows.Forms.ToolStripMenuItem ShowIncassos;
    }
}