// Copyright © Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System;
using System.ComponentModel.Design;
using Vip.Dialogs.Properties;

namespace Vip.Dialogs
{
    internal class TaskDialogDesigner : ComponentDesigner
    {
        public override DesignerVerbCollection Verbs
        {
            get
            {
                var verbs = new DesignerVerbCollection();
                verbs.Add(new DesignerVerb(Resources.Preview, Preview));
                return verbs;
            }
        }

        private void Preview(object sender, EventArgs e)
        {
            ((TaskDialog) Component).ShowDialog();
        }
    }
}