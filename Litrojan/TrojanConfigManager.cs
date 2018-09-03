using Newtonsoft.Json;
using System.IO;

namespace Litrojan
{
    internal class TrojanConfigManager
    {
        public string ConfPath;
        public TrojanConfig Config;
        private event InfoDispDelegate infoDisp;

        public TrojanConfigManager(string ConfigPath, InfoDispDelegate InfoDisp)
        {
            infoDisp = InfoDisp;
            infoDisp("Parsing config file", "LiConfMgmt");
            
            ConfPath = ConfigPath;
            Config = new TrojanConfig();
            Config.run_type = "client";
            Config.RunMode = RunMode.Client;
        }

        /// <summary>
        /// Save config to Litrojan config file.
        /// </summary>
        public void SaveConfig()
        {
            ExportConfig(RunMode.Liconf, Path.ChangeExtension(ConfPath, ".liconf"));
            infoDisp("Config file saved.", "LiConfMgmt");
        }

        /// <summary>
        /// Load config from file. If Litrojan config file exists, it's preferred.
        /// </summary>
        public bool LoadConfig(bool LoadOriginal = false)
        {
            if (!File.Exists(ConfPath) && !File.Exists(Path.ChangeExtension(ConfPath, ".liconf")))
            {
                infoDisp("Config file not exist, creating new.", "LiConfMgmt");
                SaveConfig();
            }

            bool loadLiconf = false;

            if (!LoadOriginal && File.Exists(Path.ChangeExtension(ConfPath, ".liconf")))
            {
                ConfPath = Path.ChangeExtension(ConfPath, ".liconf");
                loadLiconf = true;
            }

            JsonConvert.PopulateObject(File.ReadAllText(ConfPath), Config);

            if(loadLiconf)
                infoDisp("Read Litrojan config successful.", "LiConfMgmt");

            switch (Config.run_type)
            {
                case "client":
                    if (!loadLiconf)
                        infoDisp("Read client config successful.", "LiConfMgmt");
                    Config.RunMode = RunMode.Client;
                    break;
                case "server":
                    if (!loadLiconf)
                        infoDisp("Read server config successful.", "LiConfMgmt");
                    Config.RunMode = RunMode.Server;
                    break;
                case "forward":
                    if (!loadLiconf)
                        infoDisp("Read router config successful.", "LiConfMgmt");
                    Config.RunMode = RunMode.Router;
                    break;
                default:
                    infoDisp("Cannot parse config file. Using default values.", "LiConfMgmt");
                    Config = new TrojanConfig();
                    Config.run_type = "client";
                    Config.RunMode = RunMode.Client;
                    break;
            }

            if(!File.Exists(Path.ChangeExtension(ConfPath, ".liconf")))
                SaveConfig();

            return true;
        }

        public bool LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }

            var t = string.Copy(ConfPath);
            ConfPath = path;

            LoadConfig(true);

            ConfPath = t;

            return true;
        }

        /// <summary>
        /// Export config file meet Trojan standard. If no SavePath spicified, a temp file is used.
        /// </summary>
        public string ExportConfig(RunMode Filter, string SavePath = "", bool format = true)
        {
            var o = TrojanConfigBuilder.BuildConfig(Config, Filter, Config.RunMode);
            var s = JsonConvert.SerializeObject(o, format ? Formatting.Indented : Formatting.None);
            if(string.IsNullOrEmpty(SavePath))
                SavePath = Path.GetTempFileName();

            File.WriteAllText(SavePath, s);
            return SavePath;
        }
    }
}
