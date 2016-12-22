using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace CanvasApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var aMainWindow = new MainWindow();

            var aMainViewModel = new MainWindowViewModel();

            aMainViewModel.SketcherBackground = new BitmapImage(new Uri("/Resources/Images/test.jpg", UriKind.Relative));
            aMainViewModel.SketcherBackground.CacheOption = BitmapCacheOption.None;

            aMainWindow.DataContext = aMainViewModel;
            aMainWindow.Show();
        }

        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);

            
        }
    }
}
