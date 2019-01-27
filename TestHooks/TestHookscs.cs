using Industry_Connect_Home.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Industry_Connect_Home.TestHooks
{
    [Binding]
    public sealed class TestHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Browser.DriverInitialize("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {

            Browser.Close();
        }


    }
}
