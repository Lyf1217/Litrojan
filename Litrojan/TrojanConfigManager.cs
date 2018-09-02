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

            bool flag = true;

            if ((!LoadOriginal) && File.Exists(Path.ChangeExtension(ConfPath, ".liconf")))
            {
                ConfPath = Path.ChangeExtension(ConfPath, ".liconf");
                flag = true;
            }

            JsonConvert.PopulateObject(File.ReadAllText(ConfPath), Config);

            if(flag)
                infoDisp("Read Litrojan config successful.", "LiConfMgmt");

            switch (Config.run_type)
            {
                case "client":
                    if (!flag)
                        infoDisp("Read client config successful.", "LiConfMgmt");
                    Config.RunMode = RunMode.Client;
                    break;
                case "server":
                    if (!flag)
                        infoDisp("Read server config successful.", "LiConfMgmt");
                    Config.RunMode = RunMode.Server;
                    break;
                case "forward":
                    if (!flag)
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

        /// <summary>
        /// Export config file meet Trojan standard. If no SavePath spicified, a temp file is used.
        /// </summary>
        public string ExportConfig(RunMode Filter, string SavePath = "")
        {
            var o = TrojanConfigBuilder.BuildConfig(Config, Filter, Config.RunMode);
            var s = JsonConvert.SerializeObject(o, Formatting.Indented);
            if(string.IsNullOrEmpty(SavePath))
                SavePath = Path.GetTempFileName();

            File.WriteAllText(SavePath, s);
            return SavePath;
        }
    }
}
