using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SpacechemPatch
{
    static class ExecutableUtils
    {
        private const string SteamExeSHA256 = "mGvK5S+QaCd6d9WLVVvweqcOcuAzidc8gXoRdbyr304=";
        private const string GogExeSHA256 = "u4jC5h8SZ/5HrpseHNelRP/JVkC1/3UjN0v9FYtBpSU=";

        public static string GetDefaultPath()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    {
                        return @"C:\Program Files (x86)\Steam\steamapps\common\SpaceChem";
                    }
                case PlatformID.Unix:
                    {
                        return Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".steam/steam/steamapps/common/SpaceChem");
                    }
                default:
                    throw new Exception("Unsupported platform: " + Environment.OSVersion.Platform);
            }
        }

        private static string HashExe(string exePath)
        {
            string hashString = String.Empty;
            try
            {
                using (var stream = File.OpenRead(exePath))
                {
                    var sha = SHA256.Create();
                    byte[] hash = sha.ComputeHash(stream);
                    hashString = Convert.ToBase64String(hash);
                }
            }
            catch (Exception) { }

            return hashString;
        }

        public static bool IsRecognizedExe(string exePath)
        {
            string hashString = HashExe(exePath);
            return (hashString == SteamExeSHA256 || hashString == GogExeSHA256);
        }

        public static bool IsSteamExe(string exePath)
        {
            return HashExe(exePath) == SteamExeSHA256;
        }

    }
}
