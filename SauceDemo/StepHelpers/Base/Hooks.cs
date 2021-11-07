using SauceDemo.StepDefinitions;
using TechTalk.SpecFlow;

namespace SauceDemo.StepHelpers.Base
{
    [Binding]
    public sealed class Hooks
    {

        [AfterScenario]
        public void AfterScenario()
        {
            LoginSteps.GetLoginPage().Close();
        }
    }
}
