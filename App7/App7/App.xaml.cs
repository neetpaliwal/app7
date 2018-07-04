using App7.locat;
//using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Unity;
//using Unity.ServiceLocation;
using Xamarin.Forms;

namespace App7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var textToSpeach = DependencyService.Get<ITextToSpeech>();

            //var unityContainer = new UnityContainer();
            //// register dependencies
            //unityContainer.RegisterType<IProductsService, ProductsService>();
            ////unityContainer.RegisterInstance(typeof(ITextToSpeech), textToSpeech);
            //unityContainer.RegisterInstance(typeof(ProductsViewModel));//optional

            //var unityServiceLocator = new UnityServiceLocator(unityContainer);
            //ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            MainPage = new NavigationPage(new ProductsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
