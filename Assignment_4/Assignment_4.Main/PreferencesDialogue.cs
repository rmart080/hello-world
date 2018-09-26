using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4.Main;
using Assignment_4;

namespace Assignment_4.Main
{
    public partial class PreferencesDialogue : DialogForm, IPreferences
    {
        //Ranges are subject to change
        const int MIN_WIDTH = 50;
        const int MIN_HEIGHT = 50;
        const int MAX_WIDTH = 1920;
        const int MAX_HEIGHT = 1080;
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


        public PreferencesDialogue()
        {
            InitializeComponent();
        }

        private void preferencesDialogue_Load(object sender, EventArgs e)
        {
            if (this.Modal)
                this.applyButton.Enabled = false;

            toolTip.SetToolTip(this.elipseWidthText, $"Sets the width for Eplipse Children. Must be a whole number or decimal between {MIN_WIDTH} and {MAX_WIDTH}");
            helpProvider.SetHelpString(this.elipseWidthText, $"Sets the width for Eplipse Children. Must be a whole number or decimal between {MIN_WIDTH} and {MAX_WIDTH}");

            toolTip.SetToolTip(this.elipseRatioText, $"Sets the width*height ratio for Eplipse Children. Must be a whole number or decimal between {MIN_RATIO} and {MAX_RATIO}");
            helpProvider.SetHelpString(this.elipseRatioText, $"Sets the width*height ratio for Eplipse Children. Must be a whole number or decimal between {MIN_RATIO} and {MAX_RATIO}");


            toolTip.SetToolTip(this.rectangularHeightText, $"Sets the height for Rectangular Children. Must be a whole number or decimal between {MIN_WIDTH} and {MAX_WIDTH}");
            helpProvider.SetHelpString(this.rectangularHeightText, $"Sets the height for Rectangular Children. Must be a whole number or decimal between {MIN_WIDTH} and {MAX_WIDTH}");

            toolTip.SetToolTip(this.rectangleRatioText, $"Sets the width*height ratio for Rectangular Children. Must be a whole number or decimal between {MIN_RATIO} and {MAX_RATIO}");
            helpProvider.SetHelpString(this.rectangleRatioText, $"Sets the width*height ratio for Rectangular Children. Must be a whole number or decimal between {MIN_RATIO} and {MAX_RATIO}");

        }

        private void preferencesDialogue_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                this.Apply?.Invoke(this, e);
                this.Close();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (isFormValid())
                this.Apply?.Invoke(this, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elipseWidthText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.elipseWidthText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between {MIN_WIDTH} and {MAX_WIDTH}";

            // Validate the data entered into the textbox
            if (!int.TryParse(text, out var result) || result < MIN_WIDTH || result > MAX_WIDTH)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.elipseWidthText, error);
                return;
            }

            //If we made it this far it means validation passed
            this.errorProvider.SetError(this.elipseWidthText, "");
        }

        private void rectangularHeightText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.rectangularHeightText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between {MIN_HEIGHT} and {MAX_HEIGHT}";

            // Validate the data entered into the textbox
            if (!int.TryParse(text, out var result) || result < MIN_WIDTH || result > MAX_HEIGHT)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.rectangularHeightText, error);
                return;
            }

            //If we made it this far it means validation passed
            this.errorProvider.SetError(this.rectangularHeightText, "");
        }

        private void elipseRatioText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.elipseRatioText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between than {MIN_RATIO} and {MAX_RATIO}";

            // Validate the data entered into the textbox
            if (!float.TryParse(text, out var result) || !(result >= MIN_RATIO && result <= MAX_RATIO))
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.elipseRatioText, error);
                return;
            }

            //If we made it this far it means validation passed
            this.errorProvider.SetError(this.elipseRatioText, "");
        }

        private void rectangleRatioText_Validating(object sender, CancelEventArgs e)
        {
            string text = this.rectangleRatioText.Text;
            string error = $"Invalid number. Must be a whole number or decimal between than {MIN_RATIO} and {MAX_RATIO}";

            // Validate the data entered into the textbox
            if (!float.TryParse(text, out var result) || !(result >= MIN_RATIO && result <= MAX_RATIO))
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.rectangleRatioText, error);
                return;
            }

            //If we made it this far it means validation passed
            this.errorProvider.SetError(this.rectangleRatioText, "");
        }

        private bool isFormValid()
        {
            return this.ValidateChildren();
        }
    }
}
