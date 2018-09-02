using System;

namespace Litrojan
{
    internal interface ITrojanConfig { }

    internal class TrojanConfig : ITrojanConfig
    {
        [ConfigFieldUsage(RunMode.Litroj)]
        public RunMode RunMode { get; set; }

        public string run_type { get; set; }

        public string local_addr { get; set; } = "127.0.0.1";

        public int local_port { get; set; } = 1080;

        public string remote_addr { get; set; } = "example.com";

        public int remote_port { get; set; } = 443;

        [ConfigFieldUsage(RunMode.Router)]
        public string target_addr { get; set; } = "127.0.0.1";

        [ConfigFieldUsage(RunMode.Router)]
        public int target_port { get; set; } = 5901;

        public string[] password { get; set; } = { "password1" };

        public bool append_payload { get; set; } = true;

        public int log_level { get; set; } = 1;

        public TrojanConfigSSL ssl { get; set; } = new TrojanConfigSSL();

        public TrojanConfigTCP tcp { get; set; } = new TrojanConfigTCP();

        [ConfigFieldUsage(RunMode.Server)]
        public TrojanConfigSQL mysql { get; set; } = new TrojanConfigSQL();
    }

    internal class TrojanConfigSSL : ITrojanConfig
    {
        [ConfigFieldUsage(RunMode.Client | RunMode.Router)]
        public bool verify { get; set; } = true;

        [ConfigFieldUsage(RunMode.Client | RunMode.Router)]
        public bool verify_hostname { get; set; } = true;

        public string cert { get; set; } = "/path/to/certificate.crt";

        [ConfigFieldUsage(RunMode.Server)]
        public string key { get; set; } = "/path/to/private.key";

        [ConfigFieldUsage(RunMode.Server)]
        public string key_password { get; set; } = "";

        public string cipher { get; set; } = "ECDHE-ECDSA-AES256-GCM-SHA384:ECDHE-RSA-AES256-GCM-SHA384:ECDHE-ECDSA-CHACHA20-POLY1305:ECDHE-RSA-CHACHA20-POLY1305:ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-RSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES256-SHA384:ECDHE-RSA-AES256-SHA384:ECDHE-ECDSA-AES128-SHA256:ECDHE-RSA-AES128-SHA256";

        [ConfigFieldUsage(RunMode.Server)]
        public bool prefer_server_cipher { get; set; } = true;

        [ConfigFieldUsage(RunMode.Client | RunMode.Router)]
        public string sni { get; set; } = "example.com";

        public string[] alpn { get; set; } = { "h2", "http/1.1" };

        public bool reuse_session { get; set; } = true;

        [ConfigFieldUsage(RunMode.Server)]
        public int session_timeout { get; set; } = 600;

        public string curves { get; set; } = "";

        [ConfigFieldUsage(RunMode.Server)]
        public string dhparam { get; set; } = "";
    }

    internal class TrojanConfigTCP : ITrojanConfig
    {
        public bool no_delay { get; set; } = true;

        public bool keep_alive { get; set; } = true;

        public bool fast_open { get; set; } = false;

        public int fast_open_qlen { get; set; } = 20;
    }

    internal class TrojanConfigSQL : ITrojanConfig
    {
        public bool enabled { get; set; } = false;

        public string server_addr { get; set; } = "127.0.0.1";

        public int server_port { get; set; } = 3306;

        public string database { get; set; } = "trojan";

        public string username { get; set; } = "trojan";

        public string password { get; set; } = "";
    }

    [AttributeUsage(AttributeTargets.Property)]
    internal class ConfigFieldUsageAttribute : Attribute
    {
        public ConfigFieldUsageAttribute(RunMode Usage)
        {
            this.Usage = Usage;
        }

        public RunMode Usage { get; }
    }

    [Flags]
    internal enum RunMode
    {
        Client = 0b0001,
        Server = 0b0010,
        Router = 0b0100,
        Liconf = 0b1111,
        Litroj = 0b1000,
        None =   0b0000
    }
}
