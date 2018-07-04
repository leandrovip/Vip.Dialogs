// Copyright © Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System.ComponentModel;

namespace Vip.Dialogs
{
    /// <summary>
    ///     Provides data for the <see cref="TaskDialog.ButtonClicked" /> event.
    /// </summary>
    /// <threadsafety instance="false" static="true" />
    public class TaskDialogItemClickedEventArgs : CancelEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskDialogItemClickedEventArgs" /> class with the specified item.
        /// </summary>
        /// <param name="item">The <see cref="TaskDialogItem" /> that was clicked.</param>
        public TaskDialogItemClickedEventArgs(TaskDialogItem item)
        {
            Item = item;
        }

        /// <summary>
        ///     Gets the item that was clicked.
        /// </summary>
        /// <value>
        ///     The <see cref="TaskDialogItem" /> that was clicked.
        /// </value>
        public TaskDialogItem Item { get; }
    }
}