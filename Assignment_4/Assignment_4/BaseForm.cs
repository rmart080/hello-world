using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //change color of children forms
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Focus())
                {
                    ColorDialog colorDialog = new ColorDialog();

                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        childForm.BackColor = colorDialog.Color;
                    }
                }
            }
        }

        //change color of children form
        private void colorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Focus())
                {

                    ColorDialog colorDialog = new ColorDialog();

                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        childForm.BackColor = colorDialog.Color;
                    }
                }
                else
                {

                }
            }
        }
        //close children
        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form childForm in this.MdiChildren)
            {
                childForm.Dispose();
            }
        }

        /*
         * Move by click and drag
         * Using Example from Page 69 from Sells Textbook
         */

        Point downPoint = Point.Empty;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        //create children
        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm mdiChildForm = new newForm();
            mdiChildForm.MdiParent = this;
            mdiChildForm.Show();


        }
        //close children
        private void closeChildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Dispose();
            }
        }
        //close parent form
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //create a new child form
        private void newFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newForm mdiChildForm = new newForm();
            mdiChildForm.MdiParent = this;
            mdiChildForm.Show();
        }
    }
}
