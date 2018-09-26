using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4;

namespace Assignment_4.Main
{
    public partial class PreferencesDialogue : DialogForm
    {
        //Ranges are subject to change
        const int MIN_WIDTH = 50;
        const int MIN_HEIGHT = 50;
        const float MIN_RATIO = 0.1f;
        const float MAX_RATIO = 5;

        /// <summary>
        /// Gets or Sets the Elipse Width Property
        /// </summary>
        public int ElipseWidth
        {
            get
            {
                return int.Parse(this.elipseWidthText.Text);
            }
            set
            {
                this.elipseWidthText.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or Sets the Rectangular Height Property
        /// </summary>
        public int RectangularHeight
        {
            get
            {
                return int.Parse(this.rectangularHeightText.Text);
            }
            set
            {
                this.rectangularHeightText.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or Sets the Ratio Property
        /// </summary>
        public float ElipseRatio
        {
            get
            {
                return float.Parse(this.elipseRatioText.Text);
            }
            set
            {
                this.elipseRatioText.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or Sets the Ratio Property
        /// </summary>
        public float RectangleRatio
        {
            get
            {
                return float.Parse(this.rectangleRatioText.Text);
            }
            set
            {
                this.rectangleRatioText.Text = value.ToString();
            }
        }


        /// <summary>
        /// Gets fired upon the user clicking the Okay Button or Apply Button
        /// </summary>
        public event EventHandler Apply;

        public event EventHandler closing;


        private bool isValidWidth;
        private bool isValidHeight;
        private bool isValidElipseRatio;
        private bool isValidRectangleRatio;
        private bool okButton_Clicked = false;

        public PreferencesDialogue()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if (isFormValid())
                this.Apply?.Invoke(this, e);
                this.okButton_Clicked = true;
                this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                this.Apply?.Invoke(this, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elipseWidthText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.elipseWidthText.Text;
            string error = $"Invalid number. Must be a whole number or decimal greater than {MIN_HEIGHT}";

            // Validate the data entered into the textbox
            if (!int.TryParse(text, out var result) || result < MIN_WIDTH)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.elipseWidthText, error);
                return;
            }

            //If we made it this far it means validation passed
            isValidWidth = true;
            this.errorProvider.SetError(this.elipseWidthText, "");
        }

        private void rectangularHeightText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.rectangularHeightText.Text;
            string error = $"Invalid number. Must be a whole number or decimal greater than {MIN_HEIGHT}";
            isValidHeight = false;

            // Validate the data entered into the textbox
            if (!int.TryParse(text, out var result) || result < MIN_WIDTH)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.rectangularHeightText, error);
                return;
            }

            //If we made it this far it means validation passed
            isValidHeight = true;
            this.errorProvider.SetError(this.rectangularHeightText, "");
        }

        private bool isFormValid()
        {
            return isValidHeight && isValidWidth && isValidElipseRatio && isValidRectangleRatio;
        }

        private void elipseRatioText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.elipseRatioText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between than {MIN_RATIO} and {MAX_RATIO}";
            isValidElipseRatio = false;

            // Validate the data entered into the textbox
            if (!float.TryParse(text, out var result) || !(result >= MIN_RATIO && result <= MAX_RATIO))
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.elipseRatioText, error);
                return;
            }

            //If we made it this far it means validation passed
            isValidElipseRatio = true;
            this.errorProvider.SetError(this.elipseRatioText, "");
        }

        private void rectangleRatioText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.rectangleRatioText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between than {MIN_RATIO} and {MAX_RATIO}";
            isValidRectangleRatio = false;

            // Validate the data entered into the textbox
            if (!float.TryParse(text, out var result) || !(result >= MIN_RATIO && result <= MAX_RATIO))
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.rectangleRatioText, error);
                return;
            }

            //If we made it this far it means validation passed
            isValidRectangleRatio = true;
            this.errorProvider.SetError(this.rectangleRatioText, "");
        }

        private void revert_info(object sender, FormClosingEventArgs e)
        {
            if(this.okButton_Clicked == false) {
                this.closing?.Invoke(this, e);
            }
        }

        private void key_press(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void hideApply_Button(object sender, EventArgs e)
        {
            if (this.Modal == true)
            {
                this.applyButton.Enabled = false;
            }
        }
    }
}
