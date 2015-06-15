
namespace usbLocker
{
    /// <summary>
    /// Handles flash drives
    /// </summary>
    class DrivesHandler
    {
        //private static string ReadAllDrives()
        //{
        //    string result = string.Empty;

        //    foreach (DriveInfo drive in DriveInfo.GetDrives())
        //    {
        //        if (drive.DriveType.Equals(DriveType.Removable))
        //        {
        //            result = result + " " + SetUsbLock(drive);
        //        }
        //    }

        //    return result;
        //}

        //private static string SetUsbLock(DriveInfo drive)
        //{
        //    string resumeFile = drive.Name + @"locker\locker.txt";
        //    string result = string.Empty;

        //    if (File.Exists(resumeFile))
        //    {
        //        StreamReader myFile = new StreamReader(resumeFile);
        //        result = myFile.ReadToEnd();
        //        myFile.Close();
        //    }

        //    return result;
        //}
    }
}
