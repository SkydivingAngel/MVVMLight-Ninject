using System.Windows;
using GenericMvvmLight.ViewModel;

namespace GenericMvvmLight
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}