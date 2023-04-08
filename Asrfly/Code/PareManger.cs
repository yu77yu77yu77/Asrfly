using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Asrfly.Code
{
   public  class PareManger
    {
        private readonly Main main;

        public PareManger(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            // Load old page
            var OldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if(OldPage != null)
            {
                main.panelContainer.Controls.Remove(OldPage);  // Remove Old Page
                OldPage.Dispose();

            }

            // Load New Page
            PageUserControl.Dock= DockStyle.Fill;   
            main.panelContainer.Controls.Add(PageUserControl);


        }

    }
}
