using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu
{
    // Trong class ConfigManager
    public class ConfigManager
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void SaveConfig()
        {
            // Lưu thông tin vào tệp cấu hình, ví dụ: sử dụng JSON
            string configJson = JsonConvert.SerializeObject(this);
            File.WriteAllText("config.json", configJson);
        }
    }


}
