using System;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ConsoleApp1
{
    class Program
    {
        const UInt32 WM_KEYDOWN = 0x0100;
        const int VK_F5 = 0x74;

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [STAThread]
        static void Main()
        {
            Thread.Sleep(4000);
            for (Int32 index = 2873; index < 2875; index++)
            {
                InputSimulator sim = new InputSimulator();
                sim.Keyboard.TextEntry("runas /user:Developer \"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
                Thread.Sleep(5);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(5);
                sim.Keyboard.TextEntry(index.ToString("0000"));
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(5);
            }
        }
    }
}
