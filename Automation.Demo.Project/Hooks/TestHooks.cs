using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automation.Demo.Project.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly DriverManager _driverManager;

        public TestHooks(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverManager.GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverManager.QuitDriver();
        }
    }
}
