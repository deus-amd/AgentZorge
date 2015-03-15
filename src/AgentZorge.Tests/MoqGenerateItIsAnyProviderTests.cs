using JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace AgentZorge.Tests
{
    [TestFixture]
    public class MoqGenerateItIsAnyProviderTests : CodeCompletionTestBase
    {
        [Test]
        [TestNetFramework4]
        [TestReferences("../Moq.dll")]
        [TestCase("TestParameterSuggestionForFieldMock.cs")]
        [TestCase("TestParameterSuggestionForFieldMockSecondParameter.cs")]
        [TestCase("TestParameterSuggestionForFieldMockWithMultipleMethodOverloads.cs")]
        [TestCase("TestParameterSuggestionForFieldMockWithMultipleParameters.cs")]
        [TestCase("TestParameterSuggestionForFieldMockWithMultipleParameters_2.cs")]
        [TestCase("TestParameterSuggestionForLocalMock.cs")]
        public void RunAll_MoqSetupMethodParameterCodeCompletionProviderTests(string fileName)
        {
            DoTestFiles(fileName);
        }

        protected override bool ExecuteAction
        {
            get
            {
                return false;
            }
        }
    }
}