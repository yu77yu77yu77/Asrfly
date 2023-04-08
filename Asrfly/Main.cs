using Asrfly.Code;
using Asrfly.Gui;

namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PareManger pareManger;


        public Main()
        {
            InitializeComponent();
            pareManger = new PareManger(this);

            // Load Home Page
            pareManger.LoadPage(new Gui.GuiHome.HomeUserControl());


        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pareManger.LoadPage(new Gui.GuiHome.HomeUserControl());

        }
    }
}