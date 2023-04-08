using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asrfly.Properties;


namespace Asrfly.Code
{
    public static class MessageCollection
    {
        // Message
        public static void showEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // Dialog

    }
}
