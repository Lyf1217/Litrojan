using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

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

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static bool PingHost(string nameOrAddress, out long roundtrip)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
                roundtrip = reply.RoundtripTime;
            }
            catch (PingException)
            {
                roundtrip = -1;
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
    }
}
