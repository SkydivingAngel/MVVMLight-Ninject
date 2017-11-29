using GalaSoft.MvvmLight.Messaging;
using GenericMvvmLight.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GenericMvvmLight.View
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
            //var splashScreenViewModel = new SplashScreenViewModel(new GenericMvvmLight.Model.Login002());
            //DataContext = splashScreenViewModel;
            //Closing += (s, e) => splashScreenViewModel.Cleanup();

            Messenger.Default.Register<NotificationMessage>(this, (message) =>
            {
                //MessageBox.Show(message.Notification.ToString());
                switch (message.Notification)
                {
                    case "Logged":
                        DialogResult = true;
                        break;
                    default:
                        MessageBox.Show(message.Notification.ToString(),"Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                }
            });
        }
    }
}
