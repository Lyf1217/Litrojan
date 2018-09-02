using System.Collections.Generic;

namespace Litrojan
{
    internal delegate void InfoDispDelegate(string msg, string source);

    internal static class GlobalVaribleHost
    {
        public const string LitrojanVer = "0.72a";
        public static string TrojanVer = "1.6.0+";
        public static List<string> LogBuffer = new List<string>();

        public static RunStatus TrojanStatus = RunStatus.Stopped;

        public static List<string> TrojanProcesses = new List<string> { /* For affiliated processes, Trojan main program (trojan.exe) SHOULD NOT list here */ };
    }

    internal enum RunStatus
    {
        Stopped, Running, UnexpectedExit, Exceptional
    }
}
