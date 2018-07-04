// Copyright © Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System;
using System.Windows.Forms;

namespace Vip.Dialogs.Interop
{
    internal class WindowHandleWrapper : IWin32Window
    {
        public WindowHandleWrapper(IntPtr handle)
        {
            Handle = handle;
        }

        #region IWin32Window Members

        public IntPtr Handle { get; }

        #endregion
    }
}