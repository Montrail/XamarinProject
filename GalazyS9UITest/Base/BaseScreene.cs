using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.UITest;

namespace MobileFramework.Base
{
    public class BaseScreen
    {
        private static readonly ThreadLocal<IApp> concurrentApp = new ThreadLocal<IApp>();
        public static IApp CurrentApp => concurrentApp.Value;
        public BaseScreen CurrentScreen { get; set; }
        internal Platform platforms;

        public TPage As<TPage>() where TPage : BaseScreen
        {
            return (TPage)this;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            concurrentApp.Value = AppInitializer.StartApp(platforms);
        }
    }
}
