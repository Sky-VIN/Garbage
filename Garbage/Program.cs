using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Garbage
{
    static class Program
    {
        [STAThread]
        static void Main(string[] shit)
        {
            Data.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (shit.Length > 0)
            {
                if (Data.ask)
                {
                    /* shit counting */
                    string str;
                    if (shit.Length > 1) str = shit.Length + " items";
                    else str = System.IO.Path.GetFileName(shit[0]);

                    /* asking question */
                    if (MessageBox.Show
                        ("Throw " + str + " to garbage?",
                        GStrings.QuestionCaption,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                string errorMessage;

                /* find errors in settings */
                errorMessage = FieldHelper.FindFieldError(Data.path, Data.template);
                if (errorMessage != null)
                {
                    MessageBox.Show(errorMessage, GStrings.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Data.lastUse = DateTime.Now.ToString();
                List<Result> results = new List<Result>();

                /* call parallel methods for moving... */
                Parallel.ForEach(shit, s =>
                {
                    Result result = MovingProcess(s);
                    if (result.success) results.Add(result);
                });

                /* writing history if necessary
                 * if ShowResult is enabled, the history will be written after the user presses OK,
                 * because history is written after all processes */
                if (Data.history)
                {
                    errorMessage = new History().Append(results);
                    if (errorMessage != null)
                        MessageBox.Show(errorMessage, GStrings.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Data.Save();
                return;
            }

            Application.Run(new MainForm());
        }


        private static Result MovingProcess(string s)
        {
            Result result = new Move(s).Start();

            if (!result.success)
                MessageBox.Show(System.IO.Path.GetFileName(s) + " - " + result.message, GStrings.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Data.showResult)
                MessageBox.Show(result.message, GStrings.InfoCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            return result;
        }
    }
}