﻿namespace Vip.Dialogs.Sample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._sampleTaskDialog = new Vip.Dialogs.TaskDialog(this.components);
            this._customTaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._okTaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._cancelTaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._dialogLabel = new System.Windows.Forms.Label();
            this._dialogComboBox = new System.Windows.Forms.ComboBox();
            this._showDialogButton = new System.Windows.Forms.Button();
            this._sampleCommandLinkTaskDialog = new Vip.Dialogs.TaskDialog(this.components);
            this._elevatedTaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._otherTaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._cancel2TaskDialogButton = new Vip.Dialogs.TaskDialogButton(this.components);
            this._sampleProgressDialog = new Vip.Dialogs.ProgressDialog(this.components);
            this._sampleInputDialog = new Vip.Dialogs.InputDialog(this.components);
            this.SuspendLayout();
            // 
            // _sampleTaskDialog
            // 
            this._sampleTaskDialog.Buttons.Add(this._customTaskDialogButton);
            this._sampleTaskDialog.Buttons.Add(this._okTaskDialogButton);
            this._sampleTaskDialog.Buttons.Add(this._cancelTaskDialogButton);
            this._sampleTaskDialog.Content = resources.GetString("_sampleTaskDialog.Content");
            this._sampleTaskDialog.CustomMainIcon = ((System.Drawing.Icon)(resources.GetObject("_sampleTaskDialog.CustomMainIcon")));
            this._sampleTaskDialog.EnableHyperlinks = true;
            this._sampleTaskDialog.ExpandedInformation = resources.GetString("_sampleTaskDialog.ExpandedInformation");
            this._sampleTaskDialog.Footer = "Task Dialogs support footers and can even include <a href=\"http://www.ookii.org\">" +
    "hyperlinks</a>.";
            this._sampleTaskDialog.FooterIcon = Vip.Dialogs.TaskDialogIcon.Information;
            this._sampleTaskDialog.MainInstruction = "This is an example task dialog.";
            this._sampleTaskDialog.WindowTitle = "Task Dialog Sample";
            this._sampleTaskDialog.HyperlinkClicked += new System.EventHandler<Vip.Dialogs.HyperlinkClickedEventArgs>(this._sampleTaskDialog_HyperlinkClicked);
            // 
            // _customTaskDialogButton
            // 
            this._customTaskDialogButton.Text = "A custom button";
            // 
            // _okTaskDialogButton
            // 
            this._okTaskDialogButton.ButtonType = Vip.Dialogs.ButtonType.Ok;
            // 
            // _cancelTaskDialogButton
            // 
            this._cancelTaskDialogButton.ButtonType = Vip.Dialogs.ButtonType.Cancel;
            this._cancelTaskDialogButton.Default = true;
            // 
            // _dialogLabel
            // 
            this._dialogLabel.AutoSize = true;
            this._dialogLabel.Location = new System.Drawing.Point(16, 18);
            this._dialogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._dialogLabel.Name = "_dialogLabel";
            this._dialogLabel.Size = new System.Drawing.Size(52, 17);
            this._dialogLabel.TabIndex = 0;
            this._dialogLabel.Text = "&Dialog:";
            // 
            // _dialogComboBox
            // 
            this._dialogComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dialogComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dialogComboBox.FormattingEnabled = true;
            this._dialogComboBox.Items.AddRange(new object[] {
            "Task Dialog",
            "Task Dialog with command links",
            "Progress Dialog",
            "Input Dialog"});
            this._dialogComboBox.Location = new System.Drawing.Point(77, 15);
            this._dialogComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._dialogComboBox.Name = "_dialogComboBox";
            this._dialogComboBox.Size = new System.Drawing.Size(401, 24);
            this._dialogComboBox.TabIndex = 1;
            // 
            // _showDialogButton
            // 
            this._showDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._showDialogButton.Location = new System.Drawing.Point(488, 12);
            this._showDialogButton.Margin = new System.Windows.Forms.Padding(4);
            this._showDialogButton.Name = "_showDialogButton";
            this._showDialogButton.Size = new System.Drawing.Size(100, 28);
            this._showDialogButton.TabIndex = 2;
            this._showDialogButton.Text = "&Show dialog";
            this._showDialogButton.UseVisualStyleBackColor = true;
            this._showDialogButton.Click += new System.EventHandler(this._showDialogButton_Click);
            // 
            // _sampleCommandLinkTaskDialog
            // 
            this._sampleCommandLinkTaskDialog.Buttons.Add(this._elevatedTaskDialogButton);
            this._sampleCommandLinkTaskDialog.Buttons.Add(this._otherTaskDialogButton);
            this._sampleCommandLinkTaskDialog.Buttons.Add(this._cancel2TaskDialogButton);
            this._sampleCommandLinkTaskDialog.ButtonStyle = Vip.Dialogs.TaskDialogButtonStyle.CommandLinks;
            this._sampleCommandLinkTaskDialog.Content = "Besides regular buttons, task dialogs also support command links. Only custom but" +
    "tons are shown as command links; standard buttons remain regular buttons.";
            this._sampleCommandLinkTaskDialog.MainInstruction = "This is a sample task dialog with command links.";
            this._sampleCommandLinkTaskDialog.WindowTitle = "Task dialog sample";
            // 
            // _elevatedTaskDialogButton
            // 
            this._elevatedTaskDialogButton.CommandLinkNote = "Both regular buttons and command links can show the shield icon to indicate that " +
    "the action they perform requires elevation. It is up to the application to actua" +
    "lly perform the elevation.";
            this._elevatedTaskDialogButton.ElevationRequired = true;
            this._elevatedTaskDialogButton.Text = "An action requiring elevation";
            // 
            // _otherTaskDialogButton
            // 
            this._otherTaskDialogButton.Text = "Some other action";
            // 
            // _cancel2TaskDialogButton
            // 
            this._cancel2TaskDialogButton.ButtonType = Vip.Dialogs.ButtonType.Cancel;
            // 
            // _sampleProgressDialog
            // 
            this._sampleProgressDialog.Description = "Processing...";
            this._sampleProgressDialog.ShowTimeRemaining = true;
            this._sampleProgressDialog.Text = "This is a sample progress dialog...";
            this._sampleProgressDialog.WindowTitle = "Progress dialog sample";
            this._sampleProgressDialog.DoWork += new System.ComponentModel.DoWorkEventHandler(this._sampleProgressDialog_DoWork);
            // 
            // _sampleInputDialog
            // 
            this._sampleInputDialog.Content = resources.GetString("_sampleInputDialog.Content");
            this._sampleInputDialog.MainInstruction = "Please enter some text.";
            this._sampleInputDialog.WindowTitle = "Sample input dialog";
            // 
            // MainForm
            // 
            this.AcceptButton = this._showDialogButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 68);
            this.Controls.Add(this._showDialogButton);
            this.Controls.Add(this._dialogComboBox);
            this.Controls.Add(this._dialogLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1333327, 358);
            this.MinimumSize = new System.Drawing.Size(475, 47);
            this.Name = "MainForm";
            this.Text = "Vip.Dialogs sample";
            this.UseSystemFont = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaskDialog _sampleTaskDialog;
        private TaskDialogButton _customTaskDialogButton;
        private TaskDialogButton _okTaskDialogButton;
        private TaskDialogButton _cancelTaskDialogButton;
        private System.Windows.Forms.Label _dialogLabel;
        private System.Windows.Forms.ComboBox _dialogComboBox;
        private System.Windows.Forms.Button _showDialogButton;
        private TaskDialog _sampleCommandLinkTaskDialog;
        private TaskDialogButton _elevatedTaskDialogButton;
        private TaskDialogButton _otherTaskDialogButton;
        private TaskDialogButton _cancel2TaskDialogButton;
        private ProgressDialog _sampleProgressDialog;
        private InputDialog _sampleInputDialog;
    }
}

