using NControlDemo.FormsApp.Mvvm;
using NControlDemo.UWP.Platform.IoC;
using NControlDemo.UWP.Platform.Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NControlDemo.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            NControl.UWP.NControlViewRenderer.Init();
            LoadApplication(new NControlDemo.FormsApp.App(new ContainerProvider(), (container) =>
            {
                // Register providers
                container.Register<IImageProvider, ImageProvider>();
            }));
        }
    }
}
