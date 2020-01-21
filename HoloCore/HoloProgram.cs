using System;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace HoloCore
{
    using Windows.UI.Xaml.Hosting;

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
            var win = CoreWindow.GetForCurrentThread();
            win.Activate();
            var appView = exclusiveViewApplicationSource.CreateView();
            var coreView = CoreApplication.GetCurrentView();
            appView.Initialize(coreView);
            appView.SetWindow(win);
            appView.Run();
        }
    }
}