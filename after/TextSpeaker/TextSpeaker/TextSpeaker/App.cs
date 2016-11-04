using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Plugin.Battery;
using Plugin.Battery.Abstractions;
using Prism.Unity;
using TextSpeaker.Model;
using TextSpeaker.Views;
using Xamarin.Forms;

namespace TextSpeaker
{
    public class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<ICounter, Counter>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IBattery, Battery>(new TransientLifetimeManager());

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<TextSpeechPage>();
            Container.RegisterTypeForNavigation<CounterPage>();
            Container.RegisterTypeForNavigation<BatteryPage>();
        }
    }
}
