using System.Collections.Generic;

namespace Litrojan
{
    internal delegate void InfoDispDelegate(string msg, string source);
    internal delegate void NoticeDispDelegate(string msg);

    internal static class GlobalVaribleHost
    {
        public const string LitrojanVer = "0.1b";
        public static string TrojanVer = "1.6.0+";
        public static List<string> LogBuffer = new List<string>();

        public static List<string> TrojanProcesses = new List<string> { /* For affiliated processes, Trojan main program (trojan.exe) SHOULD NOT list here */ };

        public static string[] Surprise = LitrojanUtils.Base64Decode("KO+9nu+/o+KWve+/oynvvZ58KOOAguODu+KIgOODuynjg45844O+KOKJp+KWveKJpiopb3xxKOKJp+KWveKJpnEpfCgg4oCizIAgz4kg4oCizIEgKeKcp3wo4omn4oiA4ommKeOCnnzjg74o4oCiz4nigKJgKW9844O+KF7ilr1eKikpKXwo44Gl77+jIDPvv6Mp44GlfCjguZHigKLMgOOFguKAosyBKdmI4pynfCgqL8+J77y8Kil8KOOBoyDCsNCUIMKwOynjgaN8bygoPs+JPCApKW98772eKOOAgFTjg61UKc+DfHco776f0JTvvp8pd3wo77yDwrDQlMKwKXwo776JKu+9pc+J772lKe++iXwo44O74oiA44O7KOODu+KIgOODuyjjg7viiIDjg7sqKQ==").Split('|');
    }

    internal enum RunStatus
    {
        Stopped, Running, UnexpectedExit, Exceptional
    }
}
