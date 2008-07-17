using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using IronEditor.UI.WinForms;
using NUnit.Framework;

namespace IronEditor.Engine.Tests
{
    [TestFixture]
    public class ApplicationOptionsTests
    {
        //[Test]
        //public void SaveUserSettings_UIFont_WritesToIsolatedStorage()
        //{
        //    UserSettings settings = new UserSettings();
        //    settings.FontName = FontFamily.GenericSansSerif.Name;
        //    settings.FontSize = 10;
        //    ApplicationOptions.SaveUserSettings(settings);

        //    IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForDomain();
        //    Assert.IsTrue(isoFile.GetFileNames("UserSettings.xml").Length > 0);
        //}

        [Test]
        public void LoadSettings_WritesToIsolatedStorage_UIFont()
        {
            UserSettings settings = ApplicationOptions.LoadUserSettings();
            Assert.AreEqual(FontFamily.GenericSansSerif.Name, settings.FontName);
            Assert.AreEqual(10, settings.FontSize);
        }
    }
}
