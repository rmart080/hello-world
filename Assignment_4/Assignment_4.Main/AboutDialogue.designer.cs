namespace Assignment_4.Main
{
    partial class AboutDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialogue));
            this.AboutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutLabel.Location = new System.Drawing.Point(0, 27);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(568, 436);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Assignment_4.Main.Properties.Resources.Team1PinkPonies;
            this.ClientSize = new System.Drawing.Size(568, 585);
            this.Controls.Add(this.AboutLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialogue";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AboutDialogue_Load);
            this.Controls.SetChildIndex(this.AboutLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
    }
}
