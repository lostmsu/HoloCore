using System;
using Windows.ApplicationModel.Core;

namespace HoloCore
{
    /// <summary>
    /// Windows Holographic application using SharpDX.
    /// </summary>
    internal class HoloProgram
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [MTAThread]
        private static void Main()
        {
            var exclusiveViewApplicationSource = new AppViewSource();
            CoreApplication.Run(exclusiveViewApplicationSource);
        }
    }
}