using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGitHub3
{
    public partial class frmTest : Form
    {
        [DllImport("User32.dll")]  static extern Boolean MessageBeep(UInt32 beepType);
        [DllImport("kernel32.dll")] 
        public static extern UInt32 GetFileAttributesA(string lpFileName);
        const uint FILE_ATTRIBUTE_ARCHIVE = 0x20;
        const uint FILE_ATTRIBUTE_DIRECTORY = 0x10;
        const uint FILE_ATTRIBUTE_HIDDEN = 0x2;
        const uint FILE_ATTRIBUTE_NORMAL = 0x80;
        const uint FILE_ATTRIBUTE_READONLY = 0x1;
        const uint FILE_ATTRIBUTE_SYSTEM = 0x4;
        const uint FILE_ATTRIBUTE_TEMPORARY = 0x100;
        const uint INVALID_FILE_ATTRIBUTES = 0xffffffff;
        const uint SW_SHOW = 5;
        [DllImport("kernel32.dll")] static extern uint WinExec(string lpCmdLine, uint uCmdShow);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)] static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public frmTest()
        {
            InitializeComponent();
        }
        private void MessageBonjour()
        {
            System.Windows.Forms.MessageBox.Show("Bonjour à tous !!! ☺ bbbbbbbb");
            //System.Diagnostics.Process.Start("C:\\Windows\\notepad.exe");
            //the Win32 MessageBox function
            MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog", 0);
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBonjour();
        }

        private void btnTestAPI_Win_Click(object sender, EventArgs e)
        {
            MessageBeep(0);
        }

        private void btnTest2API_Win_Click(object sender, EventArgs e)
        {
            uint attibuts;
            attibuts = GetFileAttributesA("C:/Y/1.txt");
            System.Windows.Forms.MessageBox.Show(attibuts.ToString());
        }

        private void btn3API_Win_Click(object sender, EventArgs e)
        {
            // WinExec("cmd /c rmdir c:\\temp /s/q", SW_HIDE);
            uint marche = WinExec("C:\\Windows\\notepad.exe C:/Y/1.txt", SW_SHOW);
        }
    }
}
