using System;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Hosting;

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
            WindowsXamlManager.InitializeForCurrentThread();
            CoreApplication.Run(exclusiveViewApplicationSource);
        }
    }
}