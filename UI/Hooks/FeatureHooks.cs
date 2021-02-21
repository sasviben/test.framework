using TechTalk.SpecFlow;

namespace web.test.app.hooks
{
    [Binding]
    public class FeatureHooks
    {
        public static string Feature;

        [BeforeFeature]
        public static void PrepareForTestExecution(FeatureContext featureContext)
        {
            Feature = featureContext.FeatureInfo.Title;
        }

    }
}
