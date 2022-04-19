using Garbage;
using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;


class Move
{
    private string shit;
    private string destinationPath;


    public Move(string shit)
    {
        this.shit = shit;
        destinationPath = Data.path + @"\" + FieldHelper.ExtractPattern(shit, Data.template);
        /* in case if destination path is root folder */
        destinationPath = destinationPath.Replace(@"\\", @"\"); 
    }


    public Result Start()
    {
        Result result = new Result();
        result.success = false;
        result.source = shit;
        result.destination = destinationPath;

        /* check for free space if necessary */
        if (Data.checkFreeSpace && !FieldHelper.CheckFreeSpace(shit, Data.path))
        {
            result.message = GStrings.NoSpaceMessage;
            return result;
        }

        /* moving according settings */
        if (Data.showMoveDialog) result.message = ThrowThisShitAway();
        else result.message = ThrowThisShitAway(Data.overwrite);

        if (result.message == null)
        {
            result.success = true;
            result.message = GStrings.MovingSuccessMessage + "\n\nFrom: " + shit + "\nTo: " + destinationPath;
        }

        return result;
    }


    private string ThrowThisShitAway()
    {
        if (File.Exists(shit))
            try { FileSystem.MoveFile(shit, destinationPath, UIOption.AllDialogs, UICancelOption.ThrowException); }
            catch (IOException error) { return error.Message; }
            catch (Exception error) { return error.Message; }
        else if (Directory.Exists(shit))
            try { FileSystem.MoveDirectory(shit, destinationPath, UIOption.AllDialogs, UICancelOption.ThrowException); }
            catch (IOException error) { return error.Message; }
            catch (Exception error) { return error.Message; }

        else return GStrings.NotFoundMessage;

        return null;
    }


    private string ThrowThisShitAway(bool overwrite)
    {
        if (File.Exists(shit))
            try { FileSystem.MoveFile(shit, destinationPath, overwrite); }
            catch (IOException error) { return error.Message; }
            catch (Exception error) { return error.Message; }
        else if (Directory.Exists(shit))
            try { FileSystem.MoveDirectory(shit, destinationPath, overwrite); }
            catch (IOException error) { return error.Message; }
            catch (Exception error) { return error.Message; }

        else return GStrings.NotFoundMessage;

        return null;
    }
}
