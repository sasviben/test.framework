using TechTalk.SpecFlow;

namespace web.test.app.hooks
{
    [Binding]
    public class FeatureHooks
    {
        private static string _feature;

        public static string Feature { get => _feature; }

        [BeforeFeature]
        public static void PrepareForTestExecution(FeatureContext featureContext)
        {
            _feature = featureContext.FeatureInfo.Title;
        }

    }
}
