using System.IO;
using System.IO.IsolatedStorage;
using System.Reflection;
using System.Xml.Serialization;

namespace IronEditor.UI.WinForms
{
    public static class ApplicationOptions
    {
        public static string SettingsDirectory { get; set; }
        public static string DefaultExtension { get; set; }
        public static void LoadOptions()
        {
            SettingsDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location), "Config");

            DefaultExtension = Properties.Settings.Default.DefaultExtension;
        }

        public static void SaveUserSettings(IsolatedStorageFile isoFile, UserSettings settings)
        {
            IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream( "UserSettings.xml", FileMode.OpenOrCreate, FileAccess.Write, isoFile);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (UserSettings));
                serializer.Serialize(isoStream, settings);
            }
            finally
            {
                isoStream.Close();
            }
        }

        public static IsolatedStorageFile GetIsolatedStorage()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
                                                IsolatedStorageScope.Assembly |
                                                IsolatedStorageScope.Domain,
                                                null,
                                                null);
        }

        public static UserSettings LoadUserSettings(IsolatedStorageFile isoFile)
        {
            IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("UserSettings.xml", FileMode.OpenOrCreate, FileAccess.Read, isoFile);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (UserSettings));
                object o = serializer.Deserialize(isoStream);
                return o as UserSettings;
            }
            catch
            {
                return null;
            }
            finally
            {
                isoStream.Close();
            }
        }
    }
}
