﻿using System;
using System.Windows.Forms;

namespace ICE.VTC.TELEMETRY.Helpers
{
    public static class ExceptionExtensions
    {
        public static void ShowAsMessageBox(this Exception exception, IWin32Window owner, string caption,
                                            MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            MessageBox.Show(owner, exception.Message, caption, MessageBoxButtons.OK, icon);
        }
    }
}