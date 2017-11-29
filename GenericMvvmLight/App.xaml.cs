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
            //App application = new App { ShutdownMode = ShutdownMode.OnExplicitShutdown};
            //application.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            //Property Value -> Type: System.Windows.ShutdownMode
            //A ShutdownMode enumeration value.The default value is OnLastWindowClose.
            //Altrimenti di default chiude l'Application alla chiusura della
            //ultima finestra che in questo caso è lo SplashScreen!!
            
            application.InitializeComponent();
            MainWindow window = new MainWindow();

            View.SplashScreen dialog = new View.SplashScreen();
            var result = dialog.ShowDialog();

            if (result ?? false)
            {
                //application.Run(new MainWindow());
                application.Run(window);
            }
            else
                System.Environment.Exit(0);
        }
    }
}
