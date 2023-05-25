using System;
using Semana10a.Services;
using Semana10a.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana10a
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new PickerDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
