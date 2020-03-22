using MobileFramework.Base;
using System;
using System.Linq;
using Xamarin.UITest.Queries;

namespace MobileFramework.Extensions
{
    public static class XamarinExtensions
    {
        public static void Tap(this Func<AppQuery, AppQuery> query)
        {
            BaseScreen.CurrentApp.Tap(query);
        }

        public static void EnterText(this Func<AppQuery, AppQuery> query, string text)
        {
            BaseScreen.CurrentApp.EnterText(query, text);
        }

        public static void ClearAndEnterText(this Func<AppQuery, AppQuery> query, string text)
        {
            BaseScreen.CurrentApp.ClearText(query);
            BaseScreen.CurrentApp.EnterText(text);
        }

        public static void EnterTextAndDismissKeyboard(this string text)
        {
            BaseScreen.CurrentApp.EnterText(text);
            BaseScreen.CurrentApp.DismissKeyboard();
        }

        public static void WaitForElement(this Func<AppQuery, AppQuery> query)
        {
            BaseScreen.CurrentApp.WaitForElement(query, "Element does not exist.");
        }

        public static bool IsElementPresent(this string text)
        {
            return BaseScreen.CurrentApp.Query(x => x.Text(text)).Any();
        }
    }
}
