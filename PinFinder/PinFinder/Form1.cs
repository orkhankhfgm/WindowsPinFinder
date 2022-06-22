using System.Threading;
using System.Windows.Forms;

namespace PinFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            VirtualMouse.LeftMouseClick(300, 450);
        }
    }
}
