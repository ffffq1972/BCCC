using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    internal class JSON
    {
        private static string SaveDataPath = "Content/Data/SaveData.json";
        private static string SettingsPath = "Content/Data/Settings.json";
        public static void Read()
        {

        }
        public static void Save(SaveData data, Settings settings)
        {
            string SaveDatajson = JsonSerializer.Serialize(data);
            string SaveDatadirectory = Path.GetDirectoryName(SaveDataPath);
            if (!Directory.Exists(SaveDatadirectory))
            {
                Directory.CreateDirectory(SaveDatadirectory);
            }
            File.WriteAllText(SaveDataPath, SaveDatajson);
            string Settingsjson = JsonSerializer.Serialize(settings);
            string Settingsdirectory = Path.GetDirectoryName(SettingsPath);
            if (!Directory.Exists(Settingsdirectory))
            {
                Directory.CreateDirectory(Settingsdirectory);
            }
            File.WriteAllText(SettingsPath, Settingsjson);
        }
    }
}
