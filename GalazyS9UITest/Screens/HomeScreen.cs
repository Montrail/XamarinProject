using MobileFramework.Base;
using MobileFramework.Extensions;
using System.Linq;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace MobileFramework.Screens
{
    internal class HomeScreen : BaseScreen
    {
        public bool IsTitle { get; private set; }

        Query btnAddItem => x => x.Text("Add");
        Query listItems => x => x.Id("Add");
        

        internal AddItemScreen ClickAdd()
        {
            btnAddItem.Tap();

            return new AddItemScreen();
        }

        internal HomeScreen SearchForeTitle(string title)
        {
            //CurrentApp.Repl();
            //AppResult[] results = listItems.WaitForElement(c => c.Marked(title));
            //IsTitle = results.Any();

            return new HomeScreen();
        }
    }
}
