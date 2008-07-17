using NUnit.Framework;

namespace IronEditor.Engine.Tests
{
    [TestFixture]
    public class ApplicationInformationTests
    {
        [Test]
        public void Title_IronEditor_ReturnedAsString()
        {
            string title = ApplicationInformation.Title();
            Assert.AreEqual("IronEditor", title);
        }

        [Test]
        public void Version_CurrentVersion_ReturnedAsString()
        {
            string version = ApplicationInformation.Version();
            Assert.IsTrue(version.StartsWith("1.0.0."));
        }
    }
}
