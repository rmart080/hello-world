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
        //Defining default values 
        private int ellipseWidth = 50; //Variable for Storing the Ellipse Width of the Preferences Dialog
        private float ellipseRatio = 1; //Variable for Storing the Ratio of the Preferences Dialog
        private int rectangleHeight = 50;  //Variable for Storing the Rectangle Height of the Preferences Dialog
        private float rectangleRatio = 1; //Variable for Storing the Rectangle Ratio of the Preferences Dialog
        private PreferencesDialogue modelessDlg;

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

            using (var prefdlg = createPrefDialogue())
            {
                prefdlg.ShowDialog();
                this.Update();      //Check if this is the correct code for updating the properties of the Form.

                Console.WriteLine(eWidth);
                Console.WriteLine(eRatio);
                Console.WriteLine(recHeight);
                Console.WriteLine(recRatio);
            }
        }

        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modelessDlg == null || modelessDlg.IsDisposed)
            {
                modelessDlg = createPrefDialogue();  //Change this when you have the Preferences Dialog working, this is just a test to see if it works.
                this.Update();      //Check if this is the correct code for updating the properties of the Form.
                modelessDlg.Show(this);
            }
            else
                modelessDlg.Activate();
        }

        void infoGrab_Apply(object sender, EventArgs e)     //Grabbing All info inputted in the Preferences Dialog
        {
            IPreferences prefdlg = sender as IPreferences; //bad practice
            this.eWidth = prefdlg.ElipseWidth;
            this.eRatio = prefdlg.ElipseRatio;
            this.recHeight = prefdlg.RectangularHeight;
            this.recRatio = prefdlg.RectangleRatio;
        }

        private void openEllipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElipForm ellipseChild = new ElipForm(eRatio, eWidth);
            ellipseChild.Show();
        }

        private void openRectangularChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangularChild rectangleChild = new RectangularChild(recHeight, recRatio); //Creating new Rectangular Child
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
                    f.Close();
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
                    f.Close();
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
            int count;
            for (count = MainFormContextMenu.Items.Count - 1; count > -1; count--)
            {
                preferencesToolStripMenuItem.DropDownItems.Insert(0, MainFormContextMenu.Items[count]);
            }
        }


        PreferencesDialogue createPrefDialogue()
        {
            //creates pref dialogue and initializes it with current (or default values)
            PreferencesDialogue prefdlg = new PreferencesDialogue();
            prefdlg.ElipseWidth = this.eWidth;
            prefdlg.ElipseRatio = this.eRatio;
            prefdlg.RectangularHeight = this.recHeight;
            prefdlg.RectangleRatio = this.recRatio;
            prefdlg.Apply += infoGrab_Apply;
            prefdlg.GotFocus += Prefdlg_GotFocus;
            prefdlg.Activated += Prefdlg_Activated;
            return prefdlg;
        }

        private void Prefdlg_Activated(object sender, EventArgs e)
        {
            if (modelessDlg != null && !modelessDlg.IsDisposed)
                modelessDlg.Opacity = 1;
        }

        private void Prefdlg_GotFocus(object sender, EventArgs e)
        {
            //Used to set opacity when Going from Main form to Prefs
            modelessDlg.Opacity = 1;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (modelessDlg != null && !modelessDlg.IsDisposed)
                modelessDlg.Opacity = 0.7;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (modelessDlg != null && !modelessDlg.IsDisposed)
                modelessDlg.Opacity = 1;
        }
    }
}
