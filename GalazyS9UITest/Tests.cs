using System;
using System.IO;
using System.Linq;
using MobileFramework.Base;
using MobileFramework.Screens;
using NUnit.Framework;
using Xamarin.UITest;

namespace MobileFramework
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests : BaseScreen
    {
        public Tests(Platform platform)
        {
            platforms = platform;
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            const string addBtn = "NoResourceEntry-0";
            const string eleNewItem = "NoResourceEntry-28";
            CurrentScreen = new HomeScreen();
            CurrentScreen = CurrentScreen.As<HomeScreen>().ClickAdd();
            CurrentScreen = CurrentScreen.As<AddItemScreen>().AddItem("Seventh Item", "My description");
            CurrentScreen = CurrentScreen.As<HomeScreen>().SearchForeTitle("Seventh Item");
            Assert.IsTrue(CurrentScreen.As<HomeScreen>().IsTitle);
            //app.Tap(e => { return e.Id(addBtn); });
            //app.ClearText(x => x.Id(eleNewItem));
            //app.EnterText(x => x.Id(eleNewItem), "Montrail App");
            //var result = app.Query(x => x.Id(eleNewItem).Text("Montrail App")).Count();

            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.That(result, Is.EqualTo(1));
        }
    }
}
