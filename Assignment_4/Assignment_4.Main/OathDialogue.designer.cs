﻿namespace Assignment_4.Main
{
    partial class OathDialogue
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
            this.oathUserControl1 = new Assignment_4.OathUserControl();
            this.SuspendLayout();
            // 
            // oathUserControl1
            // 
            this.oathUserControl1.AutoSize = true;
            this.oathUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathUserControl1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oathUserControl1.ForeColor = System.Drawing.Color.DeepPink;
            this.oathUserControl1.Location = new System.Drawing.Point(0, 33);
            this.oathUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oathUserControl1.Name = "oathUserControl1";
            this.oathUserControl1.Size = new System.Drawing.Size(757, 537);
            this.oathUserControl1.TabIndex = 3;
            // 
            // OathDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(757, 720);
            this.Controls.Add(this.oathUserControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialogue";
            this.ShowIcon = false;
            this.Text = "Oath Dialog";
            this.Controls.SetChildIndex(this.oathUserControl1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Assignment_4.OathUserControl oathUserControl1;
    }
}
