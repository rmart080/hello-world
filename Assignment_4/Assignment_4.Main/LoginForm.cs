using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4.Main
{
    public partial class LoginForm : Form
    {
        public bool check {
            get { return Properties.Settings.Default.loginCheckbox; }
            set { Properties.Settings.Default.loginCheckbox = value; }
        }
        public DialogResult result { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //this.check = true;
            if(this.check)
            {
                this.check = false;
            }
            else
            {
                this.check = true;
            }
            Properties.Settings.Default.Save();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
