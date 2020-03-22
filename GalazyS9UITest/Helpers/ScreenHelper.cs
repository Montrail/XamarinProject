using MobileFramework.Base;

namespace MobileFramework.Helpers
{
    public class ScreenHelper
    {
        internal static void TypeAndDismissKeyboard(string text)
        {
            BaseScreen.CurrentApp.EnterText(text);
            DismissKeyboard();
        }

        internal static void DismissKeyboard()
        {
            BaseScreen.CurrentApp.DismissKeyboard();
        }
    }
}
