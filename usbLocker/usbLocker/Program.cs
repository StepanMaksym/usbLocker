using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace usbLocker
{
    static class Program
    {
        [STAThread]
        [DllImport("user32.dll", SetLastError = true)]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Timer timer = new Timer();
            timer.Interval = 1000;

            string result = ReadAllDrives();
           

            if (result.Contains("test"))
            {
                // do nothing
            }
            else
            {
                //lock computer
                bool locked = LockWorkStation();

                if (!locked)
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
            }
        }

        private static string ReadAllDrives()
        {
            string result = string.Empty;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType.Equals(DriveType.Removable))
                {
                    result = result + " " + SetUsbLock(drive);
                }
            }

            return result;
        }

        private static string SetUsbLock(DriveInfo drive)
        {
            string resumeFile = drive.Name + @"locker\locker.txt";
            string result = string.Empty;

            if (File.Exists(resumeFile))
            {
                StreamReader myFile = new StreamReader(resumeFile);
                result = myFile.ReadToEnd();
                myFile.Close();
            }

            return result;
        }
    }
}
