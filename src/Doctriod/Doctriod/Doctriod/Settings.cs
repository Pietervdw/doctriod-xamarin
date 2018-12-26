using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Doctriod
{
    public class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string ActiveMenu
        {
            get => AppSettings.GetValueOrDefault("ActiveMenu", "Home");
            set => AppSettings.AddOrUpdateValue("ActiveMenu", value);
        }
    }
}