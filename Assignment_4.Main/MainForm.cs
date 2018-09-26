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
    public partial class MainForm : Form
    {
        private int defaultEllipseWidth = 100; 
        private float defaultEllipseRatio = 1; 
        private int defaultRectangleHeight = 100;  //Dafault values for reverting back 
        private float defaultRectangleRatio = 1; 



        private int ellipseWidth = 100; //Variable for Storing the Ellipse Width of the Preferences Dialog
        private float ellipseRatio = 1; //Variable for Storing the Ratio of the Preferences Dialog
        private int rectangleHeight = 100;  //Variable for Storing the Rectangle Height of the Preferences Dialog
        private float rectangleRatio = 1; //Variable for Storing the Rectangle Ratio of the Preferences Dialog
       




        //Properties for the variables declared above.
        int eWidth
        {
            get { return ellipseWidth; }
            set { ellipseWidth = value; }
        }

        float eRatio
        {
            get { return ellipseRatio; }
            set { ellipseRatio = value; }
        }

        int recHeight
        {
            get { return rectangleHeight; }
            set { rectangleHeight = value; }
        }

        float recRatio
        {
            get { return rectangleRatio; }
            set { rectangleRatio = value; }
        }


        public MainForm()
        {
            InitializeComponent();
        }


        private void openModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (PreferencesDialogue prefdlg = new PreferencesDialogue())
            {
                prefdlg.ShowDialog();

                this.eWidth = prefdlg.ElipseWidth;
                this.eRatio = prefdlg.ElipseRatio;
                this.recHeight = prefdlg.RectangularHeight;
                this.recRatio = prefdlg.RectangleRatio;

            }
        }

        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialogue prefdlg = new PreferencesDialogue();
            prefdlg.Apply += new EventHandler(infoGrab_Apply);
            prefdlg.closing += new EventHandler(revert_Info);
            prefdlg.Show(this);

        }

        private void revert_Info(object sender, EventArgs e) //Reverting info to default values
        {
            PreferencesDialogue prefdlg = sender as PreferencesDialogue;
            this.eWidth = this.defaultEllipseWidth;
            this.eRatio = this.defaultEllipseRatio;
            this.recHeight = this.defaultRectangleHeight;
            this.recRatio = this.defaultRectangleRatio;

        }

        void infoGrab_Apply(object sender, EventArgs e)     //Grabbing All info inputted in the Preferences Dialog
        {
            PreferencesDialogue prefdlg = sender as PreferencesDialogue;
            this.eWidth = prefdlg.ElipseWidth;
            this.eRatio = prefdlg.ElipseRatio;
            this.recHeight = prefdlg.RectangularHeight;
            this.recRatio = prefdlg.RectangleRatio; 
            //Change for getting the values of the Custom Child 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openEllipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElipForm ellipseChild = new ElipForm(eRatio, eWidth);
            ellipseChild.Owner = this;              //Making Ellipse form Owned
            ellipseChild.MdiParent = this;          //Making Ellipse form an MdiChild
            ellipseChild.Show();

        }

        private void openRectangularChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangularChild rectangleChild = new RectangularChild(recHeight, recRatio); //Creating new Rectangular Child
            rectangleChild.Owner = this;            //Making Rectangle form owned
            rectangleChild.MdiParent = this;
            rectangleChild.Show();  //Displaying the Rectangular Child
        }

        private void closeAllEllipticChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();       //Creating a list of all the open forms

            foreach (Form f in Application.OpenForms)       //Adding all open forms to the list
                openForms.Add(f);

            foreach (Form f in openForms)           //Checking if the form is an EllipseChild and close it
            {
                if (f.Name == "ElipForm")
                {
                    f.Close();
                }
            }

        }

        private void closeAllRectangularChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();        //Creating a list of all the open forms

            foreach (Form f in Application.OpenForms)   //Adding all open forms to the list
                openForms.Add(f);

            foreach (Form f in openForms)               //Checking if the form is an RectangularChild and close it
            {
                if (f.Name == "RectangularChild")
                {
                    f.Close();
                }
            }

        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OathDialog odlg = new OathDialog();       //Creating new Oath Dialog and displaying it
            //odlg.ShowDialog();
            //odlg.Left = this.endposition.Right;
            //oldg.Owner = this;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)           //Checking if the form is an About Dialog 
            {
                if (f.Name == "AboutDialog")
                    isOpen = true;
            }

            if (isOpen == false) {
                //AboutDialog adlg = new AboutDialog();       //Creating new About Dialog and displaying it
                //adlg.ShowDialog();
                //adlg.top = this.endposition.Bottom;
                //aldg.Owner = this;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool recChildExists = false;
            bool eChildExists = false;
            bool childExists = false;

            foreach (Form f in Application.OpenForms)        
            {
                if (f.Name == "RectangularChild")
                {
                    recChildExists = true;
                    childExists = true;
                }
                else if (f.Name == "ElipForm")
                {
                    eChildExists = true;
                    childExists = true;
                }

                else if (f.Name == "CustomChild")
                {
                    childExists = true;
                }
            }

            if (eChildExists == false)
            {
                closeAllEllipticChildrenToolStripMenuItem.Enabled = false;
            }

            else
                closeAllEllipticChildrenToolStripMenuItem.Enabled = true;

            if (recChildExists == false)
            {
                closeAllRectangularChildrenToolStripMenuItem.Enabled = false;
            }

            else
                closeAllRectangularChildrenToolStripMenuItem.Enabled = true;

            if (childExists == false)
            {
                closeAllChildrenToolStripMenuItem.Enabled = false;
            }

            else
                closeAllChildrenToolStripMenuItem.Enabled = true;

        }

        private void preferencesMenuItem_DropDownOpening(object sender, EventArgs e)
        {
           
            preferencesToolStripMenuItem.DropDown = MainFormContextMenu;    //Setting Preferences Menu Items to Context Menu


        }

        private void mdiChildActivate_Click(object sender, EventArgs e)
        {
            BaseForm activeChild = (BaseForm)this.ActiveMdiChild;



            if (activeChild != null)
            {
                activeChild.colorChanged += new EventHandler(changeColor);
                if (activeChild.Name == "ElipForm")
                {
                    toolStripStatusLabel.Text = "Ellipse";
                    statusStrip.BackColor = activeChild.BackColor;
                }

                if (activeChild.Name == "RectangularChild")
                {
                    toolStripStatusLabel.Text = "Rectangle";
                    statusStrip.BackColor = activeChild.BackColor;
                }

                if (activeChild.Name == "CustomChild")
                {
                    toolStripStatusLabel.Text = "Custom";
                    statusStrip.BackColor = activeChild.BackColor;
                }
            }

            else
            {
                toolStripStatusLabel.Text = "Team 1";
                statusStrip.BackColor = Color.White;
            }
        }

        private void openCustomChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomChild customChild = new CustomChild(recHeight, recRatio); //Creating new Rectangular Child
            //customChild.Owner = this;
            //customChild.MdiParent = this;
            //customChild.Show();  //Displaying the Rectangular Child
        }

        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();        //Creating a list of all the open forms

            foreach (Form f in Application.OpenForms)   //Adding all open forms to the list
                openForms.Add(f);

            foreach (Form f in openForms)               //Closing All forms that are not Main Form
            {
                if (f.Name != "MainForm")
                {
                    f.Close();
                }
            }

        }

        private void changeColor(object sender, EventArgs e)   //Method to change BackColor of Status Bar when
        {                                                      //Color of a child changes
            Form activeChild = this.ActiveMdiChild;
            statusStrip.BackColor = activeChild.BackColor;
        }
    }
}
