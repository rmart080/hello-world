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

namespace Assignment_4
{
    public partial class ElipForm : BaseForm
    {
        
        public ElipForm(float factor, int width)
        {
            InitializeComponent();
            int Height = (int)(( width * factor)+0.5);
            this.ClientSize = new System.Drawing.Size(width,Height);
            MakeRectangleRegion();
        }
        void MakeRectangleRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);

            }
        }
    }
}
