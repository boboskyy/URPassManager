using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPassManager.core
{
    internal class FileManager
    {
        public static List<PMEntity> DB = new List<PMEntity>();

        private static string pathProfile = "database\\profile.dat";
        private static string pathDb = "database\\db.dat";
        public static string ReadPassHash()
        {
            
            if (!File.Exists(pathProfile))
                return "";
            return File.ReadAllText(pathProfile);
        }

        public static void WritePassHash(string pass)
        {
            SHA256 sha = SHA256.Create();
            string hash = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(pass)));
            File.WriteAllText(pathProfile, hash);
        }

        public static void LoadDb()
        {
            if (!File.Exists(pathDb))
                return;
            string data = File.ReadAllText(pathDb);
            List<PMEntity> entities = JsonConvert.DeserializeObject<List<PMEntity>>(data);
            DB = entities;
        }

        public static void SaveDb()
        {
            string str = JsonConvert.SerializeObject(DB);
            if (File.Exists(pathDb))
                File.Delete(pathDb);
            File.WriteAllText(pathDb, str);
        }
    }
}
