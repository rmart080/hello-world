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

namespace Assignment_3
{
    public partial class MainFormRecChild : BaseForm
    {
        public MainFormRecChild(float multiple, int height, int width)
        {
            InitializeComponent();

            int recWidth = (int)(width * multiple);
            int recHeight = (int)(height * multiple);

            this.Width = recWidth;
            this.Height = recHeight;

            /*
             * To prevent the form from being resized from the specified desired size.
             */
            this.MinimumSize = new Size(recWidth, recHeight);
            this.MaximumSize = new Size(recWidth, recHeight);

            MakeRectangleRegion();
            
        }

        void MakeRectangleRegion()
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
