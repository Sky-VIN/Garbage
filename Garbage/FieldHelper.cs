using Garbage;
using System;
using System.IO;


static class FieldHelper
{
    public static string CreateDefaultGrabageFolder(string defaultPath)
    {
        if (!Directory.Exists(defaultPath))
        {
            Directory.CreateDirectory(defaultPath);
            return defaultPath;
        }

        /* search for a free name for the default folder */
        int i = 1;
        while (Directory.Exists(defaultPath + "_" + i)) i++;
        Directory.CreateDirectory(defaultPath + "_" + i);
        return defaultPath + "_" + i;
    }


    public static string FindFieldError(string path, string template)
    {
        if (!TargetPathExists(path))
            return GStrings.PathErrorMessage;

        if (CheckCharacters(template))
            return GStrings.TemplateErrorMessage;

        return null;
    }


    private static bool CheckCharacters(string template)
    {
        if (template == null || template.Equals(""))
            return true;

        string[] warningCharacters = { @"\\", "/", ":", "*", "?", "\"", "<", ">", "|" };
        foreach (string character in warningCharacters)
            if (template.Contains(character))
                return true;

        return false;
    }


    private static bool TargetPathExists(string path)
    { return Directory.Exists(path); }


    public static string ExtractPattern(string sourceFileName, string pattern)
    {
        string result = pattern;
        result = result.Replace("%N", Path.GetFileNameWithoutExtension(sourceFileName));
        result = result.Replace("%X", Path.GetExtension(sourceFileName));

        result = result.Replace("%Y", DateTime.Now.ToString("yyyy"));
        result = result.Replace("%M", DateTime.Now.ToString("MM"));
        result = result.Replace("%D", DateTime.Now.ToString("dd"));

        result = result.Replace("%h", DateTime.Now.ToString("HH"));
        result = result.Replace("%m", DateTime.Now.ToString("mm"));
        result = result.Replace("%s", DateTime.Now.ToString("ss"));

        return result;
    }


    public static bool CheckFreeSpace(string sourcePath, string targetPath)
    { return GetFreeSpace(targetPath) > GetObjectSize(sourcePath); }


    private static long GetFreeSpace(string path)
    { return new DriveInfo(Path.GetPathRoot(path)).AvailableFreeSpace; }


    private static long GetObjectSize(string path)
    {
        long size = 0;

        if (File.Exists(path))
            size = new FileInfo(path).Length;

        else if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
                size += new FileInfo(file).Length;
        }

        return size;
    }
}
