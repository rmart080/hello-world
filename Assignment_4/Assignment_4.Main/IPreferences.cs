using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Main
{
    public interface IPreferences
    {
        /// <summary>
        /// Gets or Sets the Elipse Width Property
        /// </summary>
        int ElipseWidth { get; set; }

        /// <summary>
        /// Gets or Sets the Rectangular Height Property
        /// </summary>
        int RectangularHeight { get; set; }

        /// <summary>
        /// Gets or Sets the Ratio Property
        /// </summary>
        float ElipseRatio { get; set; }

        /// <summary>
        /// Gets or Sets the Ratio Property
        /// </summary>
        float RectangleRatio { get; set; }

        /// <summary>
        /// Gets fired upon the user clicking the Okay Button or Apply Button
        /// </summary>
        event EventHandler Apply;

    }
}
