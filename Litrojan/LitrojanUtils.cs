using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Litrojan
{
    internal static class LitrojanUtils
    {
        static object Lock = new object();

        public static string ErrorFormatter(string Msg, Exception e)
        {
            return $"{Msg} (HResult: {e.HResult}).\r\nMessage: {e.Message}\r\nStack: \r\n{e.StackTrace}";
        }

        public static string GetLocalPath(string fileName)
        {
            string startupPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            if (string.IsNullOrEmpty(fileName))
            {
                return startupPath;
            }
            return Path.Combine(startupPath, fileName);
        }

        public static void AutoIncrementalSave()
        {
            lock (Lock)
            {
                var p = GetLocalPath($"Litrojan-AllTime.log");
                File.AppendAllLines(p, GlobalVaribleHost.LogBuffer);
                GlobalVaribleHost.LogBuffer.Clear();
            }
        }

        public static void AutoSave()
        {
            for(; ; )
            {
                AutoIncrementalSave();
                Thread.Sleep(5000);
            }
        }
    }
}
