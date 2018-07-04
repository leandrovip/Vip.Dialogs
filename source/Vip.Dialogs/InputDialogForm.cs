// Copyright © Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Vip.Dialogs
{
    internal partial class InputDialogForm : ExtendedForm
    {
        private SizeF _textMargin = new SizeF(12, 9);

        public event EventHandler<OkButtonClickedEventArgs> OkButtonClicked;

        public InputDialogForm()
        {
            InitializeComponent();
        }

        public string MainInstruction { get; set; }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public string Content { get; set; }

        public string Input
        {
            get => _inputTextBox.Text;
            set => _inputTextBox.Text = value;
        }

        public int MaxLength
        {
            get => _inputTextBox.MaxLength;
            set => _inputTextBox.MaxLength = value;
        }

        public bool UsePasswordMasking
        {
            get => _inputTextBox.UseSystemPasswordChar;
            set => _inputTextBox.UseSystemPasswordChar = value;
        }

        protected virtual void OnOkButtonClicked(OkButtonClickedEventArgs e)
        {
            if (OkButtonClicked != null)
                OkButtonClicked(this, e);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            _textMargin = new SizeF(_textMargin.Width * factor.Width, _textMargin.Height * factor.Height);
            base.ScaleControl(factor, specified);
        }

        private void SizeDialog()
        {
            var horizontalSpacing = (int) _textMargin.Width * 2;
            var verticalSpacing = ClientSize.Height - _inputTextBox.Top + (int) _textMargin.Height * 3;
            using (var graphics = _primaryPanel.CreateGraphics())
            {
                ClientSize = DialogHelper.SizeDialog(graphics, MainInstruction, Content, Screen.FromControl(this),
                    new Font(Font, FontStyle.Bold), Font, horizontalSpacing, verticalSpacing, ClientSize.Width, 0);
            }
        }

        private static void DrawThemeBackground(IDeviceContext dc, VisualStyleElement element, Rectangle bounds,
            Rectangle clipRectangle)
        {
            if (DialogHelper.IsTaskDialogThemeSupported)
            {
                var renderer = new VisualStyleRenderer(element);
                renderer.DrawBackground(dc, bounds, clipRectangle);
            }
        }

        private void DrawText(IDeviceContext dc, ref Point location, bool measureOnly, int width)
        {
            DialogHelper.DrawText(dc, MainInstruction, Content, ref location, new Font(Font, FontStyle.Bold), Font,
                measureOnly, width);
        }

        private void _primaryPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.PrimaryPanel,
                _primaryPanel.ClientRectangle, e.ClipRectangle);
            var location = new Point((int) _textMargin.Width, (int) _textMargin.Height);
            DrawText(e.Graphics, ref location, false, ClientSize.Width - (int) _textMargin.Width * 2);
        }

        private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.SecondaryPanel,
                _secondaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void NewInputBoxForm_Load(object sender, EventArgs e)
        {
            SizeDialog();
            CenterToScreen();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            var okButtonClickedEventArgs = new OkButtonClickedEventArgs(_inputTextBox.Text, this);
            OnOkButtonClicked(okButtonClickedEventArgs);
            if (!okButtonClickedEventArgs.Cancel)
                DialogResult = DialogResult.OK;
        }
    }
}