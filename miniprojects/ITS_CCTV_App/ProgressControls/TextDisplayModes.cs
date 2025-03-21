﻿using System;

namespace ProgressControls
{
    [Flags]
    public enum TextDisplayModes
    {
        /// <summary>
        /// No text will be shown by the control.
        /// </summary>
        None = 0,

        /// <summary>
        /// The control will show the value of the Percentage property.
        /// </summary>
        Percentage = 1,

        /// <summary>
        /// The control will show the value of the Text property.
        /// </summary>
        Text = 2,

        /// <summary>
        /// The control will show the values of the Text and Percentage properties.
        /// </summary>
        Both = Percentage | Text
    }
}
