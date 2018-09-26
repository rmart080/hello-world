using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.Main
{
    interface InfoModeless_Interface
    {
        int eWidth { get; set; }
        int Ratio { get; set; }
        int recHeight { get; set; }
        
        event EventHandler Apply;
    }
}
