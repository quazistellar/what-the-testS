﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testiki_wpf
{
    internal class serdeser
    {
        private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "testiki.json");

        public static void Serialize<T>(T data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }

        public static T Deserialize<T>()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            else
            {
                File.Create(filePath).Close();
                return default(T);
            }
        }
    }
}
