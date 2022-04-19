using Garbage;
using System;
using System.IO;
using System.Collections.Generic;


class History
{
    public string Append(List<Result> results)
    {
        /* first appending line is Date and Time */
        string container = System.DateTime.Now.ToString() + ":\n";

        /* appending all moved elements */
        foreach (Result result in results)
            container += "\tName:\t" + Path.GetFileName(result.destination) +
                "\n\tFrom:\t" + result.source + "\n\n";

        /* appending new lines at story for beauty */
        container += "\n";

        /* getting path for history file from first result element. Anyway all paths in results are the same */
        string historyFile = Path.GetDirectoryName(results[0].destination) + "\\" + GStrings.HistotyFileName;

        StreamWriter sWriter = new StreamWriter(historyFile, true, System.Text.Encoding.Default);

        try { sWriter.Write(container); }
        catch (IOException error) { return error.Message; }
        catch (Exception error) { return error.Message; }
        finally { sWriter.Close(); }

        return null;
    }


    public int Delete(string path)
    {
        string[] files = Directory.GetFiles(path, GStrings.HistotyFileName, SearchOption.AllDirectories);

        foreach (string file in files)
            File.Delete(file);

        return files.Length;
    }
}
