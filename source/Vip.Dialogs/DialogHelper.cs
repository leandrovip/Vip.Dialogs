// Copyright © Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Vip.Dialogs
{
    internal static class DialogHelper
    {
        public static bool IsTaskDialogThemeSupported => NativeMethods.IsWindowsVistaOrLater &&
                                                         VisualStyleRenderer.IsSupported &&
                                                         Application.RenderWithVisualStyles;

        public static int GetTextHeight(IDeviceContext dc, string mainInstruction, string content,
            Font mainInstructionFallbackFont, Font contentFallbackFont, int width)
        {
            // compute the height the text needs at the current dialog width.
            var location = Point.Empty;
            DrawText(dc, mainInstruction, content, ref location, mainInstructionFallbackFont, contentFallbackFont, true,
                width);
            return location.Y;
        }

        public static Size SizeDialog(IDeviceContext dc, string mainInstruction, string content, Screen screen,
            Font mainInstructionFallbackFont, Font contentFallbackFont, int horizontalSpacing, int verticalSpacing,
            int minimumWidth, int textMinimumHeight)
        {
            var width = minimumWidth - horizontalSpacing;
            var height = GetTextHeight(dc, mainInstruction, content, mainInstructionFallbackFont, contentFallbackFont,
                width);

            while (height > width)
            {
                var area = height * width;
                width = (int) (Math.Sqrt(area) * 1.1);
                height = GetTextHeight(dc, mainInstruction, content, mainInstructionFallbackFont, contentFallbackFont,
                    width);
            }

            if (height < textMinimumHeight)
                height = textMinimumHeight;

            var newWidth = width + horizontalSpacing;
            var newHeight = height + verticalSpacing;

            var workingArea = screen.WorkingArea;
            if (newHeight > 0.9 * workingArea.Height)
            {
                var area = height * width;
                newHeight = (int) (0.9 * workingArea.Height);
                height = newHeight - verticalSpacing;
                width = area / height;
                newWidth = width + horizontalSpacing;
            }

            // If this happens the text won't display correctly, but even at 800x600 you need
            // to put so much text in the input box for this to happen that I don't care.
            if (newWidth > 0.9 * workingArea.Width)
                newWidth = (int) (0.9 * workingArea.Width);

            return new Size(newWidth, newHeight);
        }

        public static void DrawText(IDeviceContext dc, string text, VisualStyleElement element, Font fallbackFont,
            ref Point location, bool measureOnly, int width)
        {
            // For Windows 2000, using Int32.MaxValue for the height doesn't seem to work, so we'll just pick another arbitrary large value
            // that does work.
            var textRect = new Rectangle(location.X, location.Y, width,
                NativeMethods.IsWindowsXPOrLater ? int.MaxValue : 100000);
            var flags = TextFormatFlags.WordBreak;
            if (IsTaskDialogThemeSupported)
            {
                var renderer = new VisualStyleRenderer(element);
                var textSize = renderer.GetTextExtent(dc, textRect, text, flags);
                location = location + new Size(0, textSize.Height);
                if (!measureOnly)
                    renderer.DrawText(dc, textSize, text, false, flags);
            }
            else
            {
                if (!measureOnly)
                    TextRenderer.DrawText(dc, text, fallbackFont, textRect, SystemColors.WindowText, flags);
                var textSize = TextRenderer.MeasureText(dc, text, fallbackFont,
                    new Size(textRect.Width, textRect.Height), flags);
                location = location + new Size(0, textSize.Height);
            }
        }

        public static void DrawText(IDeviceContext dc, string mainInstruction, string content, ref Point location,
            Font mainInstructionFallbackFont, Font contentFallbackFont, bool measureOnly, int width)
        {
            if (!string.IsNullOrEmpty(mainInstruction))
                DrawText(dc, mainInstruction, AdditionalVisualStyleElements.TextStyle.MainInstruction,
                    mainInstructionFallbackFont, ref location, measureOnly, width);

            if (!string.IsNullOrEmpty(content))
            {
                if (!string.IsNullOrEmpty(mainInstruction))
                    content = Environment.NewLine + content;

                DrawText(dc, content, AdditionalVisualStyleElements.TextStyle.BodyText, contentFallbackFont,
                    ref location, measureOnly, width);
            }
        }
    }
}