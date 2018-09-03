using System;

namespace Litrojan
{
    class TrojanNetworkManager
    {
        readonly TrojanConfig conf;
        private event NoticeDispDelegate notiDisp;

        // Some 'system route' & 'speed test' things will goes here.

        public TrojanNetworkManager(TrojanConfig Config, NoticeDispDelegate NotiDisp)
        {
            conf = Config;
            notiDisp = NotiDisp;
        }

        public void Ping()
        {
            notiDisp($"Pinging server [{conf.remote_addr}]:");
            long total = 0L;
            long min = long.MaxValue;
            long max = 0L;
            int div = 0;
            for (int i = 1; i <= 5; i++)
            {
                var succ = LitrojanUtils.PingHost(conf.remote_addr, out var t);
                
                if (succ)
                {
                    notiDisp($"Ping {i}/5. Reply from {conf.remote_addr}: time={t}ms.");
                    total += t;
                    div++;
                    min = Math.Min(t, min);
                    max = Math.Max(t, max);
                }
                else
                {
                    notiDisp($"Ping {i}/5. Request timed out.");
                }
                
            }
            notiDisp($"Ping statistics for {conf.remote_addr}:");
            if (div > 0)
            {
                notiDisp($"    Packets: Sent = 5, Received = {div}, Lost = {5 - div} ({100 * (5 - div) / 5}% loss),");
                notiDisp("Approximate round trip times in milli-seconds:");
                notiDisp($"    Minimum = {min}ms, Maximum = {max}ms, Average = {total / div}ms");
            }
            else
            {
                notiDisp($"    Packets: Sent = 5, Received = 0, Lost = 5 (100% loss),");
            }
        }
    }
}
