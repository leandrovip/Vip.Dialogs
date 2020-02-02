using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Vip.Dialogs.Sample
{
    public partial class MainForm : ExtendedForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _dialogComboBox.SelectedIndex = 0;
        }

        private void _showDialogButton_Click(object sender, EventArgs e)
        {
            switch (_dialogComboBox.SelectedIndex)
            {
                case 0:
                    ShowTaskDialog();
                    break;
                case 1:
                    ShowTaskDialogWithCommandLinks();
                    break;
                case 2:
                    ShowProgressDialog();
                    break;
                case 3:
                    ShowInputDialog();
                    break;
            }
        }

        private void ShowTaskDialog()
        {
            if (TaskDialog.OSSupportsTaskDialogs)
            {
                var button = _sampleTaskDialog.ShowDialog(this);
                if (button == _customTaskDialogButton)
                    MessageBox.Show(this, "You clicked the custom button", "Task Dialog Sample");
                else if (button == _okTaskDialogButton)
                    MessageBox.Show(this, "You clicked the OK button.", "Task Dialog Sample");
            }
            else
            {
                MessageBox.Show(this, "This operating system does not support task dialogs.", "Task Dialog Sample");
            }
        }

        private void ShowTaskDialogWithCommandLinks()
        {
            if (TaskDialog.OSSupportsTaskDialogs)
                _sampleCommandLinkTaskDialog.ShowDialog(this);
            else
                MessageBox.Show(this, "This operating system does not support task dialogs.", "Task Dialog Sample");
        }

        private void ShowProgressDialog()
        {
            if (_sampleProgressDialog.IsBusy)
                MessageBox.Show(this, "The progress dialog is already displayed.", "Progress dialog sample");
            else
                _sampleProgressDialog
                    .Show(this); // Show a modeless dialog; this is the recommended mode of operation for a progress dialog.
        }

        private void ShowInputDialog()
        {
            if (_sampleInputDialog.ShowDialog(this) == DialogResult.OK)
                MessageBox.Show(this, "The text was: " + _sampleInputDialog.Input, "Sample input dialog");
        }

        private void _sampleTaskDialog_HyperlinkClicked(object sender, HyperlinkClickedEventArgs e)
        {
            Process.Start(e.Href);
        }

        private void _sampleProgressDialog_DoWork(object sender, DoWorkEventArgs e)
        {
            // Implement the operation that the progress bar is showing progress of here, same as you would do with a background worker.
            for (var x = 0; x <= 100; ++x)
            {
                Thread.Sleep(500);
                // Periodically check CancellationPending and abort the operation if required.
                if (_sampleProgressDialog.CancellationPending)
                    return;
                // ReportProgress can also modify the main text and description; pass null to leave them unchanged.
                // If _sampleProgressDialog.ShowTimeRemaining is set to true, the time will automatically be calculated based on
                // the frequency of the calls to ReportProgress.
                _sampleProgressDialog.ReportProgress(x, null,
                    string.Format(CultureInfo.CurrentCulture, "Processing: {0}%", x));
            }
        }
    }
}