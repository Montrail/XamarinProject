using MobileFramework.Extensions;
using MobileFramework.Base;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace MobileFramework.Screens
{
    public class AddItemScreen : BaseScreen
    {
        private Query txtTitle => x => x.Text("Item name");
        private Query txtDescription => x => x.Id("NoResourceEntry-30");
        private Query btnSave => x => x.Text("Save");
        private Query btnAdd => x => x.Text("Add");
        private Query btnCancel => x => x.Text("Cancel");


        internal HomeScreen AddItem(string title, string description)
        {
            txtTitle.ClearAndEnterText(title);
            txtDescription.ClearAndEnterText(description);
            btnAdd.Tap();

            return new HomeScreen();
        }
    }
}
