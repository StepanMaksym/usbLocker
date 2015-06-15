using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace usbLocker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

            //string result = ReadAllDrives();
           

            //if (result.Contains("test"))
            //{
            //    // do nothing
            //}
            //else
            //{
            //    //lock computer
            //    bool locked = LockWorkStation();

            //    if (!locked)
            //    {
            //        throw new Win32Exception(Marshal.GetLastWin32Error());
            //    }
            //}
        }


    }
}
