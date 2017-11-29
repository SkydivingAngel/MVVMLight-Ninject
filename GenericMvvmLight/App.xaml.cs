using System.Windows;
using GalaSoft.MvvmLight.Threading;
//using View = GenericMvvmLight.View;
using System;

namespace GenericMvvmLight
{
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        [STAThread]
        public static void Main()
        {
            App application = new App() { ShutdownMode = ShutdownMode.OnMainWindowClose};

            application.InitializeComponent();
            MainWindow window = new MainWindow();

            View.SplashScreen dialog = new View.SplashScreen();
            var result = dialog.ShowDialog();

            if (result ?? false)
            {
                application.Run(window);
            }
            else
                System.Environment.Exit(0);
        }
    }
}
