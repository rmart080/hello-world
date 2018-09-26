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
            this.MainFormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllEllipticChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllRectangularChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormContextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormContextMenu
            // 
            this.MainFormContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModallyToolStripMenuItem,
            this.openModelesslyToolStripMenuItem});
            this.MainFormContextMenu.Name = "MainFormContextMenu";
            this.MainFormContextMenu.Size = new System.Drawing.Size(230, 48);
            // 
            // openModallyToolStripMenuItem
            // 
            this.openModallyToolStripMenuItem.Name = "openModallyToolStripMenuItem";
            this.openModallyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openModallyToolStripMenuItem.Click += new System.EventHandler(this.openModallyToolStripMenuItem_Click);
            // 
            // openModelesslyToolStripMenuItem
            // 
            this.openModelesslyToolStripMenuItem.Name = "openModelesslyToolStripMenuItem";
            this.openModelesslyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly";
            this.openModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openModelesslyToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(600, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticChildToolStripMenuItem,
            this.openRectangularChildToolStripMenuItem,
            this.closeAllEllipticChildrenToolStripMenuItem,
            this.closeAllRectangularChildrenToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openEllipticChildToolStripMenuItem
            // 
            this.openEllipticChildToolStripMenuItem.Name = "openEllipticChildToolStripMenuItem";
            this.openEllipticChildToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openEllipticChildToolStripMenuItem.Text = "Open Elliptic Child";
            this.openEllipticChildToolStripMenuItem.Click += new System.EventHandler(this.openEllipticChildToolStripMenuItem_Click);
            // 
            // openRectangularChildToolStripMenuItem
            // 
            this.openRectangularChildToolStripMenuItem.Name = "openRectangularChildToolStripMenuItem";
            this.openRectangularChildToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openRectangularChildToolStripMenuItem.Text = "Open Rectangular Child";
            this.openRectangularChildToolStripMenuItem.Click += new System.EventHandler(this.openRectangularChildToolStripMenuItem_Click);
            // 
            // closeAllEllipticChildrenToolStripMenuItem
            // 
            this.closeAllEllipticChildrenToolStripMenuItem.Name = "closeAllEllipticChildrenToolStripMenuItem";
            this.closeAllEllipticChildrenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllEllipticChildrenToolStripMenuItem.Text = "Close All Elliptic Children";
            this.closeAllEllipticChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllEllipticChildrenToolStripMenuItem_Click);
            // 
            // closeAllRectangularChildrenToolStripMenuItem
            // 
            this.closeAllRectangularChildrenToolStripMenuItem.Name = "closeAllRectangularChildrenToolStripMenuItem";
            this.closeAllRectangularChildrenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllRectangularChildrenToolStripMenuItem.Text = "Close All Rectangular Children";
            this.closeAllRectangularChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllRectangularChildrenToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ContextMenuStrip = this.MainFormContextMenu;
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.MainFormContextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
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
    }
}

