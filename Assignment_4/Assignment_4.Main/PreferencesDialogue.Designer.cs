namespace Assignment_4.Main
{
    partial class PreferencesDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialogue));
            this.panel2 = new System.Windows.Forms.Panel();
            this.okayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.elipseRatioText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rectangleRatioText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangularHeightText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elipseWidthText = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.okayButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.applyButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 346);
            this.panel2.TabIndex = 3;
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.okayButton, "Applies the new settings entered and closes this window.");
            this.okayButton.Location = new System.Drawing.Point(352, 316);
            this.okayButton.Margin = new System.Windows.Forms.Padding(2);
            this.okayButton.Name = "okayButton";
            this.helpProvider.SetShowHelp(this.okayButton, true);
            this.okayButton.Size = new System.Drawing.Size(56, 24);
            this.okayButton.TabIndex = 4;
            this.okayButton.Text = "Okay";
            this.toolTip.SetToolTip(this.okayButton, "Applies the new settings entered and closes this window.");
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.cancelButton, "Closes this window.");
            this.cancelButton.Location = new System.Drawing.Point(473, 316);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.helpProvider.SetShowHelp(this.cancelButton, true);
            this.cancelButton.Size = new System.Drawing.Size(56, 24);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.toolTip.SetToolTip(this.cancelButton, "Closes this window.");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.applyButton, "Applies the new settings entered.");
            this.applyButton.Location = new System.Drawing.Point(413, 316);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.helpProvider.SetShowHelp(this.applyButton, true);
            this.applyButton.Size = new System.Drawing.Size(56, 24);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.toolTip.SetToolTip(this.applyButton, "Applies the new settings entered.");
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.elipseRatioText);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rectangleRatioText);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rectangularHeightText);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.elipseWidthText);
            this.panel3.Location = new System.Drawing.Point(147, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 203);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eliptic Child Ratio";
            // 
            // elipseRatioText
            // 
            this.elipseRatioText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elipseRatioText.Location = new System.Drawing.Point(11, 74);
            this.elipseRatioText.Margin = new System.Windows.Forms.Padding(2);
            this.elipseRatioText.Name = "elipseRatioText";
            this.elipseRatioText.Size = new System.Drawing.Size(119, 20);
            this.elipseRatioText.TabIndex = 1;
            this.elipseRatioText.Validating += new System.ComponentModel.CancelEventHandler(this.elipseRatioText_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rectangular Child Ratio";
            // 
            // rectangleRatioText
            // 
            this.rectangleRatioText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleRatioText.Location = new System.Drawing.Point(12, 162);
            this.rectangleRatioText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleRatioText.Name = "rectangleRatioText";
            this.rectangleRatioText.Size = new System.Drawing.Size(119, 20);
            this.rectangleRatioText.TabIndex = 3;
            this.rectangleRatioText.Validating += new System.ComponentModel.CancelEventHandler(this.rectangleRatioText_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rectangular Child Height";
            // 
            // rectangularHeightText
            // 
            this.rectangularHeightText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangularHeightText.Location = new System.Drawing.Point(12, 119);
            this.rectangularHeightText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangularHeightText.Name = "rectangularHeightText";
            this.rectangularHeightText.Size = new System.Drawing.Size(119, 20);
            this.rectangularHeightText.TabIndex = 2;
            this.rectangularHeightText.Validating += new System.ComponentModel.CancelEventHandler(this.rectangularHeightText_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliptic Child Width";
            // 
            // elipseWidthText
            // 
            this.elipseWidthText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpKeyword(this.elipseWidthText, "Sets the width in pixels of newly generated Eliptic Children.");
            this.elipseWidthText.Location = new System.Drawing.Point(12, 30);
            this.elipseWidthText.Margin = new System.Windows.Forms.Padding(2);
            this.elipseWidthText.Name = "elipseWidthText";
            this.helpProvider.SetShowHelp(this.elipseWidthText, true);
            this.elipseWidthText.Size = new System.Drawing.Size(119, 20);
            this.elipseWidthText.TabIndex = 0;
            this.elipseWidthText.Validating += new System.ComponentModel.CancelEventHandler(this.elipseWidthText_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PreferencesDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(539, 495);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesDialogue";
            this.Text = "PreferencesDialogue";
            this.Load += new System.EventHandler(this.preferencesDialogue_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preferencesDialogue_KeyPress);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox elipseWidthText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rectangularHeightText;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox elipseRatioText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rectangleRatioText;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}