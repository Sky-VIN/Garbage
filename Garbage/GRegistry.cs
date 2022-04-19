using Microsoft.Win32;

static class GRegistry
{
    public struct Keys
    {
        public const string TARGET_PATH = "Path";
        public const string TARGET_HISTORY = "PathHistory";
        public const string TEMPLATE_PATTERN = "Template";
        public const string ASK = "Ask";
        public const string CHECK_FREE_SPACE = "CheckFreeSpace";
        public const string SHOW_MOVE_DIALOG = "ShowMoveDialog";
        public const string OVERWRITE = "Overwrite";
        public const string SHOW_RESULT = "ShowResult";
        public const string HISTORY = "History";
        public const string LAST_USE = "LastUse";
    }


    private const string settingsKey = @"HKEY_CURRENT_USER\Software\VIN\Garbage";
    

    public static void SetKey(string key, object value)
    { Registry.SetValue(settingsKey, key, value); }


    public static string GetStringKey(string key)
    { return Registry.GetValue(settingsKey, key, null) as string; }


    public static bool GetBoolKey(string key)
    {
        if (Registry.GetValue(settingsKey, key, null).Equals("True"))
            return true;

        return false;
    }
}