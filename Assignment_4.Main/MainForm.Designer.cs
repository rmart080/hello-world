namespace Assignment_4.Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllEllipticChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllRectangularChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormContextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormContextMenu
            // 
            this.MainFormContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModallyToolStripMenuItem,
            this.openModelesslyToolStripMenuItem});
            this.MainFormContextMenu.Name = "MainFormContextMenu";
            this.MainFormContextMenu.Size = new System.Drawing.Size(368, 52);
            // 
            // openModallyToolStripMenuItem
            // 
            this.openModallyToolStripMenuItem.Name = "openModallyToolStripMenuItem";
            this.openModallyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openModallyToolStripMenuItem.Size = new System.Drawing.Size(367, 24);
            this.openModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openModallyToolStripMenuItem.Click += new System.EventHandler(this.openModallyToolStripMenuItem_Click);
            // 
            // openModelesslyToolStripMenuItem
            // 
            this.openModelesslyToolStripMenuItem.Name = "openModelesslyToolStripMenuItem";
            this.openModelesslyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.openModelesslyToolStripMenuItem.Size = new System.Drawing.Size(367, 24);
            this.openModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly";
            this.openModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openModelesslyToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticChildToolStripMenuItem,
            this.openRectangularChildToolStripMenuItem,
            this.openCustomChildToolStripMenuItem,
            this.closeAllEllipticChildrenToolStripMenuItem,
            this.closeAllRectangularChildrenToolStripMenuItem,
            this.closeAllChildrenToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openEllipticChildToolStripMenuItem
            // 
            this.openEllipticChildToolStripMenuItem.Name = "openEllipticChildToolStripMenuItem";
            this.openEllipticChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.openEllipticChildToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.openEllipticChildToolStripMenuItem.Text = "Open Elliptic Child";
            this.openEllipticChildToolStripMenuItem.Click += new System.EventHandler(this.openEllipticChildToolStripMenuItem_Click);
            // 
            // openRectangularChildToolStripMenuItem
            // 
            this.openRectangularChildToolStripMenuItem.Name = "openRectangularChildToolStripMenuItem";
            this.openRectangularChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.openRectangularChildToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.openRectangularChildToolStripMenuItem.Text = "Open Rectangular Child";
            this.openRectangularChildToolStripMenuItem.Click += new System.EventHandler(this.openRectangularChildToolStripMenuItem_Click);
            // 
            // openCustomChildToolStripMenuItem
            // 
            this.openCustomChildToolStripMenuItem.Name = "openCustomChildToolStripMenuItem";
            this.openCustomChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.openCustomChildToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.openCustomChildToolStripMenuItem.Text = "Open Custom Child";
            this.openCustomChildToolStripMenuItem.Click += new System.EventHandler(this.openCustomChildToolStripMenuItem_Click);
            // 
            // closeAllEllipticChildrenToolStripMenuItem
            // 
            this.closeAllEllipticChildrenToolStripMenuItem.Name = "closeAllEllipticChildrenToolStripMenuItem";
            this.closeAllEllipticChildrenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.closeAllEllipticChildrenToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.closeAllEllipticChildrenToolStripMenuItem.Text = "Close All Elliptic Children";
            this.closeAllEllipticChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllEllipticChildrenToolStripMenuItem_Click);
            // 
            // closeAllRectangularChildrenToolStripMenuItem
            // 
            this.closeAllRectangularChildrenToolStripMenuItem.Name = "closeAllRectangularChildrenToolStripMenuItem";
            this.closeAllRectangularChildrenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.closeAllRectangularChildrenToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.closeAllRectangularChildrenToolStripMenuItem.Text = "Close All Rectangular Children";
            this.closeAllRectangularChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllRectangularChildrenToolStripMenuItem_Click);
            // 
            // closeAllChildrenToolStripMenuItem
            // 
            this.closeAllChildrenToolStripMenuItem.Name = "closeAllChildrenToolStripMenuItem";
            this.closeAllChildrenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.closeAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.closeAllChildrenToolStripMenuItem.Text = "Close All Children";
            this.closeAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllChildrenToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.DropDownOpening += new System.EventHandler(this.preferencesMenuItem_DropDownOpening);
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel.Text = "Team 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.MainFormContextMenu;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.mdiChildActivate_Click);
            this.MainFormContextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MainFormContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModelesslyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEllipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRectangularChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllEllipticChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllRectangularChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllChildrenToolStripMenuItem;
    }
}

