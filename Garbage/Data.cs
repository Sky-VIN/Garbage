using Garbage;

using Keys = GRegistry.Keys;


static class Data
{
    public static string path;
    public static string pathHistory;
    public static string template;
    public static bool ask;
    public static bool checkFreeSpace;
    public static bool showMoveDialog;
    public static bool overwrite;
    public static bool showResult;
    public static bool history;
    public static string lastUse;


    public static void Load()
    {
        lastUse = GRegistry.GetStringKey(Keys.LAST_USE);

        if (lastUse != null)
        {
            path = GRegistry.GetStringKey(Keys.TARGET_PATH);
            pathHistory = GRegistry.GetStringKey(Keys.TARGET_HISTORY);
            template = GRegistry.GetStringKey(Keys.TEMPLATE_PATTERN);
            ask = GRegistry.GetBoolKey(Keys.ASK);
            checkFreeSpace = GRegistry.GetBoolKey(Keys.CHECK_FREE_SPACE);
            showMoveDialog = GRegistry.GetBoolKey(Keys.SHOW_MOVE_DIALOG);
            overwrite = GRegistry.GetBoolKey(Keys.OVERWRITE);
            showResult = GRegistry.GetBoolKey(Keys.SHOW_RESULT);
            history = GRegistry.GetBoolKey(Keys.HISTORY);
        }
        else loadDefaultSettings();
    }


    private static void loadDefaultSettings()
    {
        path = FieldHelper.CreateDefaultGrabageFolder(GStrings.DefaultPath);
        pathHistory = "";
        template = GStrings.DefaultTemplate;
        ask = true;
        checkFreeSpace = false;
        showMoveDialog = true;
        overwrite = true;
        showResult = false;
        history = true;
        lastUse = GStrings.LastUseNever;
    }


    public static void Save()
    {
        /* Appending path to history if it doesnt exist */
        if (!pathHistory.Contains(path + ';'))
            pathHistory = path + ';' + pathHistory;

        GRegistry.SetKey(Keys.LAST_USE, lastUse);
        GRegistry.SetKey(Keys.TARGET_PATH, path);
        GRegistry.SetKey(Keys.TARGET_HISTORY, pathHistory);
        GRegistry.SetKey(Keys.TEMPLATE_PATTERN, template);
        GRegistry.SetKey(Keys.ASK, ask);
        GRegistry.SetKey(Keys.CHECK_FREE_SPACE, checkFreeSpace);
        GRegistry.SetKey(Keys.SHOW_MOVE_DIALOG, showMoveDialog);
        GRegistry.SetKey(Keys.OVERWRITE, overwrite);
        GRegistry.SetKey(Keys.SHOW_RESULT, showResult);
        GRegistry.SetKey(Keys.HISTORY, history);
    }
}
