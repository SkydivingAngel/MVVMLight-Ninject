using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using GenericMvvmLight.Model;
using System;

namespace GenericMvvmLight.ViewModel
{
    public class SplashScreenViewModel : ViewModelBase
    {
        private readonly ILogin loginService;

        public string Username {get; set;}
        public string Password { get; set; }
        public string WelcomeTitle { get; set; }

        public SplashScreenViewModel(ILogin loginService)
        {
            if (loginService == null)
            {
                throw new ArgumentNullException("loginService");
            }

            this.loginService = loginService;
            Username = loginService.GetLastLogin();
            Password = "";
            WelcomeTitle = "SplashScreen Login";
        }

        private RelayCommand<object[]> tryLogin;
        public RelayCommand<object[]> TryLogin
        {
            get
            {
                if (tryLogin == null)
                {
                    tryLogin = new RelayCommand<object[]>((s) => DoSomething(s));
                }
                return tryLogin;
            }
        }

        private void DoSomething(object[] args)
        {
            if (loginService.TryLogin(Username, Password))
            {
                Messenger.Default.Send(new NotificationMessage("Logged"));
            }
            else
            {
                Messenger.Default.Send(new NotificationMessage("Not Logged"));
                Password = "";
                RaisePropertyChanged("Password");
            }
        }

        public override void Cleanup()
        {
            if(Username.Trim()!="") 
            loginService.SetLastLogin(Username);
            base.Cleanup();
        }
    }
}