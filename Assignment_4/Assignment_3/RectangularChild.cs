using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3.Main
{
    public partial class RectangularChild : Form1
    {
        public RectangularChild(int recHeight, float multiple)
        {
            InitializeComponent();

            int recWidth = (int)(recHeight * multiple);

            this.ClientSize = new Size(recWidth, recHeight);

            /*
             * To prevent form size from being changed from specified size.
             */
            this.MinimumSize = this.ClientSize;
            this.MaximumSize = this.ClientSize;
            MakeRectangle();

        }

        void MakeRectangle()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);
                this.Region = new Region(path);
            }
        }
        
    }
}
