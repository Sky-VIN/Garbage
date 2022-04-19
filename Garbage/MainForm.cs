using System;
using System.Windows.Forms;


namespace Garbage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /* making app size smaller by icon size */
            Icon = Properties.Resources.paper;
        }


        /* TemplateMenu Methods */
        private void templateInfo_MouseDown(object sender, MouseEventArgs e)
        { templateMenu.Show(templateInfo, templateInfo.Width, templateInfo.Height); }


        private void menuName_Click(object sender, EventArgs e)
        { templateBox.Paste(menuName.Text.Substring(0, 2)); }

        private void menuExt_Click(object sender, EventArgs e)
        { templateBox.Paste(menuExt.Text.Substring(0, 2)); }

        private void menuYear_Click(object sender, EventArgs e)
        { templateBox.Paste(menuYear.Text.Substring(0, 2)); }

        private void menuMonth_Click(object sender, EventArgs e)
        { templateBox.Paste(menuMonth.Text.Substring(0, 2)); }

        private void menuDay_Click(object sender, EventArgs e)
        { templateBox.Paste(menuDay.Text.Substring(0, 2)); }

        private void menuHour_Click(object sender, EventArgs e)
        { templateBox.Paste(menuHour.Text.Substring(0, 2)); }

        private void menuMinute_Click(object sender, EventArgs e)
        { templateBox.Paste(menuMinute.Text.Substring(0, 2)); }

        private void menuSecond_Click(object sender, EventArgs e)
        { templateBox.Paste(menuSecond.Text.Substring(0, 2)); }

        private void menuSetDefault_Click(object sender, EventArgs e)
        { templateBox.Text = GStrings.DefaultTemplate; }
        /* End of TemplateMenu Methods */


        private void MainForm_Shown(object sender, EventArgs e)
        {
            pathBox.Text = Data.path;
            pathBox.Items.AddRange(Data.pathHistory.Split(';'));
            pathBox.Items.Remove("");
            templateBox.Text = Data.template;
            askChk.Checked = Data.ask;
            checkFreeSpaceChk.Checked = Data.checkFreeSpace;
            showMoveDialogChk.Checked = Data.showMoveDialog;
            skipRadio.Checked = !Data.overwrite;
            showResultChk.Checked = Data.showResult;
            historyChk.Checked = Data.history;
            lastUseLabel.Text += Data.lastUse;
        }


        private void clearTargetHistoryBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                (GStrings.ClearPathHistoryMessage,
                GStrings.QuestionCaption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Data.pathHistory = "";
                pathBox.Items.Clear();
            }
        }


        private void openDirBtn_Click(object sender, EventArgs e)
        {
            openDialog.SelectedPath = pathBox.Text;
            if (openDialog.ShowDialog() == DialogResult.OK) pathBox.Text = openDialog.SelectedPath;
        }


        private void templateBox_TextChanged(object sender, EventArgs e)
        { exampleLabel.Text = FieldHelper.ExtractPattern(GStrings.ExampleFileName, templateBox.Text); }


        private void showMoveDialogChk_CheckedChanged(object sender, EventArgs e)
        {
            overwriteRadio.Enabled = !showMoveDialogChk.Checked;
            skipRadio.Enabled = !showMoveDialogChk.Checked;
        }


        private void historyChk_CheckedChanged(object sender, EventArgs e)
        {
            if (!historyChk.Checked)
                if (MessageBox.Show
                    (GStrings.HistoryAskDeleteMessage,
                    GStrings.QuestionCaption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int count = new History().Delete(Data.path);
                    MessageBox.Show(count + GStrings.HistoryDeletedMessage, GStrings.InfoCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            /* find errors in settings */
            string errorMessage = FieldHelper.FindFieldError(pathBox.Text, templateBox.Text);
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, GStrings.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Data.path = pathBox.Text;
            Data.template = templateBox.Text;
            Data.ask = askChk.Checked;
            Data.checkFreeSpace = checkFreeSpaceChk.Checked;
            Data.showMoveDialog = showMoveDialogChk.Checked;
            Data.overwrite = overwriteRadio.Checked;
            Data.showResult = showResultChk.Checked;
            Data.history = historyChk.Checked;
            Data.lastUse = DateTime.Now.ToString();
            Data.Save();

            /* create shortcut in "Send to" and create deskyop.ini */
            new Integrate(Data.path, Application.ExecutablePath);
            /* Message how to use the app */
            MessageBox.Show(GStrings.SendToInfoMessage, GStrings.InfoCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        { Application.Exit(); }
    }
}
