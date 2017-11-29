using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using GenericMvvmLight.Model;
using Ninject;
using Ninject.Parameters;

namespace GenericMvvmLight.ViewModel
{
    public class ViewModelLocator
    {
        private static readonly StandardKernel kernel;

        static ViewModelLocator()
        {
            if (kernel == null)
            {
                kernel = new StandardKernel();
                kernel.Bind<IDataService>().To<DataService>().InSingletonScope();
                kernel.Bind<ILogin>().To<Login001>().InSingletonScope();
            }
        }
        
        public MainViewModel Main
        {
            get
            {
                return kernel.Get<MainViewModel>();
            }
        }

        public SplashScreenViewModel SplashScreen
        {
            get
            {
                return kernel.Get<SplashScreenViewModel>();
            }
        }

        public static void Cleanup()
        {

        }
    }
}
