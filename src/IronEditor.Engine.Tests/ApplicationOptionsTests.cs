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
        private UserSettings CreateSettings()
        {
            UserSettings settings = new UserSettings();
            settings.FontName = FontFamily.GenericSansSerif.Name;
            settings.FontSize = 10;
            return settings;
        }

        [Test]
        public void SaveUserSettings_UIFont_WritesToIsolatedStorage()
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
                                                                       IsolatedStorageScope.Assembly |
                                                                       IsolatedStorageScope.Domain,
                                                                       null,
                                                                       null);
            UserSettings settings = CreateSettings();
            ApplicationOptions.SaveUserSettings(isoFile, settings);

            Assert.IsTrue(isoFile.GetFileNames("UserSettings.xml").Length > 0);
        }

        [Test]
        public void LoadSettings_WritesToIsolatedStorage_UIFont()
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
                                                           IsolatedStorageScope.Assembly |
                                                           IsolatedStorageScope.Domain,
                                                           null,
                                                           null);
            UserSettings savedSettings = CreateSettings();
            ApplicationOptions.SaveUserSettings(isoFile, savedSettings);

            UserSettings settings = ApplicationOptions.LoadUserSettings(isoFile);
            Assert.IsNotNull(settings);
            Assert.AreEqual(FontFamily.GenericSansSerif.Name, settings.FontName);
            Assert.AreEqual(10, settings.FontSize);
        }
    }
}
