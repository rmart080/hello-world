namespace Assignment_3
{
    partial class FirstUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Team_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Team_Name
            // 
            this.Team_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Team_Name.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Name.ForeColor = System.Drawing.Color.DeepPink;
            this.Team_Name.Location = new System.Drawing.Point(0, 0);
            this.Team_Name.Name = "Team_Name";
            this.Team_Name.Size = new System.Drawing.Size(411, 346);
            this.Team_Name.TabIndex = 0;
            this.Team_Name.Text = "Pink Ponies\r\nGonzalo Mera Miguens\r\nJonathan Dominguez\r\nDariel Barroso\r\nAndy Pujol" +
    " Perez\r\nAriel Arbona\r\nRolando Martinez";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.Team_Name);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(411, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Team_Name;
    }
}
