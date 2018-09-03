using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Litrojan
{
    // Auto generated
    internal interface ITrojanConfig { }

    internal class TrojanConfig : ITrojanConfig, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private RunMode _RunMode = RunMode.None;
        private string _run_type = "";
        private string _local_addr = "127.0.0.1";
        private int _local_port = 1080;
        private string _remote_addr = "example.com";
        private int _remote_port = 443;
        private string _target_addr = "127.0.0.1";
        private int _target_port = 5901;
        private string[] _password = { "password1" };
        private bool _append_payload = true;
        private int _log_level = 1;
        private TrojanConfigSSL _ssl = new TrojanConfigSSL();
        private TrojanConfigTCP _tcp = new TrojanConfigTCP();
        private TrojanConfigSQL _mysql = new TrojanConfigSQL();

        [ConfigFieldUsage(RunMode.Litroj)] public RunMode RunMode { get { return this._RunMode; } set { if (value != this._RunMode) { this._RunMode = value; NotifyPropertyChanged(); } } }
        public string run_type { get { return this._run_type; } set { if (value != this._run_type) { this._run_type = value; NotifyPropertyChanged(); } } }
        public string local_addr { get { return this._local_addr; } set { if (value != this._local_addr) { this._local_addr = value; NotifyPropertyChanged(); } } }
        public int local_port { get { return this._local_port; } set { if (value != this._local_port) { this._local_port = value; NotifyPropertyChanged(); } } }
        public string remote_addr { get { return this._remote_addr; } set { if (value != this._remote_addr) { this._remote_addr = value; NotifyPropertyChanged(); } } }
        public int remote_port { get { return this._remote_port; } set { if (value != this._remote_port) { this._remote_port = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Router)] public string target_addr { get { return this._target_addr; } set { if (value != this._target_addr) { this._target_addr = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Router)] public int target_port { get { return this._target_port; } set { if (value != this._target_port) { this._target_port = value; NotifyPropertyChanged(); } } }
        public string[] password { get { return this._password; } set { if (value != this._password) { this._password = value; NotifyPropertyChanged(); } } }
        public bool append_payload { get { return this._append_payload; } set { if (value != this._append_payload) { this._append_payload = value; NotifyPropertyChanged(); } } }
        public int log_level { get { return this._log_level; } set { if (value != this._log_level) { this._log_level = value; NotifyPropertyChanged(); } } }
        public TrojanConfigSSL ssl { get { return this._ssl; } set { if (value != this._ssl) { this._ssl = value; NotifyPropertyChanged(); } } }
        public TrojanConfigTCP tcp { get { return this._tcp; } set { if (value != this._tcp) { this._tcp = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public TrojanConfigSQL mysql { get { return this._mysql; } set { if (value != this._mysql) { this._mysql = value; NotifyPropertyChanged(); } } }
    }

    internal class TrojanConfigSSL : ITrojanConfig, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _verify = true;
        private bool _verify_hostname = true;
        private string _cert = "/path/to/certificate.crt";
        private string _key = "/path/to/private.key";
        private string _key_password = "";
        private string _cipher = "ECDHE-ECDSA-AES256-GCM-SHA384:ECDHE-RSA-AES256-GCM-SHA384:ECDHE-ECDSA-CHACHA20-POLY1305:ECDHE-RSA-CHACHA20-POLY1305:ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-RSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES256-SHA384:ECDHE-RSA-AES256-SHA384:ECDHE-ECDSA-AES128-SHA256:ECDHE-RSA-AES128-SHA256";
        private bool _prefer_server_cipher = true;
        private string _sni = "example.com";
        private string[] _alpn = { "h2", "http/1.1" };
        private bool _reuse_session = true;
        private int _session_timeout = 600;
        private string _curves = "";
        private string _dhparam = "";

        [ConfigFieldUsage(RunMode.Client | RunMode.Router)] public bool verify { get { return this._verify; } set { if (value != this._verify) { this._verify = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Client | RunMode.Router)] public bool verify_hostname { get { return this._verify_hostname; } set { if (value != this._verify_hostname) { this._verify_hostname = value; NotifyPropertyChanged(); } } }
        public string cert { get { return this._cert; } set { if (value != this._cert) { this._cert = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public string key { get { return this._key; } set { if (value != this._key) { this._key = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public string key_password { get { return this._key_password; } set { if (value != this._key_password) { this._key_password = value; NotifyPropertyChanged(); } } }
        public string cipher { get { return this._cipher; } set { if (value != this._cipher) { this._cipher = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public bool prefer_server_cipher { get { return this._prefer_server_cipher; } set { if (value != this._prefer_server_cipher) { this._prefer_server_cipher = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Client | RunMode.Router)] public string sni { get { return this._sni; } set { if (value != this._sni) { this._sni = value; NotifyPropertyChanged(); } } }
        public string[] alpn { get { return this._alpn; } set { if (value != this._alpn) { this._alpn = value; NotifyPropertyChanged(); } } }
        public bool reuse_session { get { return this._reuse_session; } set { if (value != this._reuse_session) { this._reuse_session = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public int session_timeout { get { return this._session_timeout; } set { if (value != this._session_timeout) { this._session_timeout = value; NotifyPropertyChanged(); } } }
        public string curves { get { return this._curves; } set { if (value != this._curves) { this._curves = value; NotifyPropertyChanged(); } } }
        [ConfigFieldUsage(RunMode.Server)] public string dhparam { get { return this._dhparam; } set { if (value != this._dhparam) { this._dhparam = value; NotifyPropertyChanged(); } } }
    }

    internal class TrojanConfigTCP : ITrojanConfig, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _no_delay = true;
        private bool _keep_alive = true;
        private bool _fast_open = false;
        private int _fast_open_qlen = 20;

        public bool no_delay { get { return this._no_delay; } set { if (value != this._no_delay) { this._no_delay = value; NotifyPropertyChanged(); } } }
        public bool keep_alive { get { return this._keep_alive; } set { if (value != this._keep_alive) { this._keep_alive = value; NotifyPropertyChanged(); } } }
        public bool fast_open { get { return this._fast_open; } set { if (value != this._fast_open) { this._fast_open = value; NotifyPropertyChanged(); } } }
        public int fast_open_qlen { get { return this._fast_open_qlen; } set { if (value != this._fast_open_qlen) { this._fast_open_qlen = value; NotifyPropertyChanged(); } } }
    }

    internal class TrojanConfigSQL : ITrojanConfig, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _enabled = false;
        private string _server_addr = "127.0.0.1";
        private int _server_port = 3306;
        private string _database = "trojan";
        private string _username = "trojan";
        private string _password = "";

        public bool enabled { get { return this._enabled; } set { if (value != this._enabled) { this._enabled = value; NotifyPropertyChanged(); } } }
        public string server_addr { get { return this._server_addr; } set { if (value != this._server_addr) { this._server_addr = value; NotifyPropertyChanged(); } } }
        public int server_port { get { return this._server_port; } set { if (value != this._server_port) { this._server_port = value; NotifyPropertyChanged(); } } }
        public string database { get { return this._database; } set { if (value != this._database) { this._database = value; NotifyPropertyChanged(); } } }
        public string username { get { return this._username; } set { if (value != this._username) { this._username = value; NotifyPropertyChanged(); } } }
        public string password { get { return this._password; } set { if (value != this._password) { this._password = value; NotifyPropertyChanged(); } } }
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
