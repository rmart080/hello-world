namespace Assignment_4
{
    partial class DialogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new Assignment_4.FirstUserControl();
            this.userControl21 = new Assignment_4.SecondUserControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 436);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 463);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(568, 122);
            this.userControl11.TabIndex = 1;
            // 
            // userControl21
            // 
            this.userControl21.AutoSize = true;
            this.userControl21.BackColor = System.Drawing.SystemColors.Control;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(568, 27);
            this.userControl21.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Name = "Form2";
            this.Text = "Dialog Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecondUserControl userControl21;
        private FirstUserControl userControl11;
        private System.Windows.Forms.Panel panel1;
    }
}