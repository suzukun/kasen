namespace KasenCS
{
    using System;
    using System.IO;
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        [MenuItem("Tools/Screenshot", false)]
        public static void CaptureScreenshot()
        {
            DateTime now = DateTime.Now;
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string year = now.Year.ToString().PadLeft(4, '0');
            string month = now.Month.ToString().PadLeft(2, '0');
            string day = now.Day.ToString().PadLeft(2, '0');
            string hour = now.Hour.ToString().PadLeft(2, '0');
            string minute = now.Minute.ToString().PadLeft(2, '0');
            string second = now.Second.ToString().PadLeft(2, '0');
            string fileName = $"{year}-{month}-{day}_{hour}-{minute}-{second}.png";
            string path = Path.Combine(directory, fileName);

            ScreenCapture.CaptureScreenshot(path);

            LogInfo($"[Screenshot] {path}");
        }
    }
}
