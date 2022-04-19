using System;
using System.IO;
using IWshRuntimeLibrary;

using File = System.IO.File;


class Integrate
{
    public Integrate(string targetPath, string executablePath)
    {
        CreateLink(executablePath);
        CreateIniFile(targetPath, executablePath);
    }


    private void CreateLink(string executablePath)
    {
        string lnk = Environment.GetFolderPath(Environment.SpecialFolder.SendTo) + "\\" + Path.GetFileNameWithoutExtension(executablePath) + ".lnk";

        WshShell wsh = new WshShell();
        IWshShortcut shortcut = wsh.CreateShortcut(lnk) as IWshShortcut;

        shortcut.TargetPath = executablePath;
        shortcut.Save();
    }


    private void CreateIniFile(string targetPath, string executablePath)
    {
        string iniFile = targetPath + @"\desktop.ini";

        /* recreate the ini file if the garbage folder is changed or if ini file was modified */
        if (File.Exists(iniFile)) File.Delete(iniFile);
        try
        {
            StreamWriter sWriter = new StreamWriter(iniFile);
            sWriter.WriteLine("[.ShellClassInfo]");
            sWriter.WriteLine("IconResource=" + executablePath + ",1");

            /* For understanding Windows XP */
            sWriter.WriteLine("IconFile=" + executablePath);
            sWriter.WriteLine("IconIndex=1");

            sWriter.Close();

            File.SetAttributes(iniFile, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(targetPath, FileAttributes.ReadOnly | FileAttributes.System);
        }
        catch { }
    }
}
