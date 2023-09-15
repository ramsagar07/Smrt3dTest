using TechTalk.SpecFlow;
using Smart3dTest.Utility;
using AventStack.ExtentReports.Gherkin.Model;

namespace Smart3dTest.Hooks
{
    [Binding]
    public sealed class Smart3dHook : ExtentReporting
    {
         static ControlHelper help = new();
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
          

            ExtentReportInit();
            
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
             help.InitilizeAppium();
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            
            ControlHelper._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [BeforeStep]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            AddStep(scenarioContext);
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            help.TerminateAppium();
            ExtentReportTeardown();
        }
    }
}