using System;
using System.IO;
using ProtoBuf;

namespace TurboWeeb
{
    public static class Context
    {
        public static Library Library;

        public static FormMain MainForm;

        private static string SaveLocation;

        public static void Load(bool minimize = true)
        {
            if (minimize)
            {
                MainForm.Hide();
            }

            Prepare();

            if (!File.Exists(SaveLocation))
            {
                Library = new Library();
                Save();

                return;
            }

            FileStream fileStream = File.Open(SaveLocation, FileMode.Open);

            Library = Serializer.Deserialize<Library>(fileStream);

            fileStream.Close();
        }

        public static void Save()
        {
            Prepare();

            FileStream fileStream = File.Open(SaveLocation, FileMode.OpenOrCreate);

            Serializer.Serialize(fileStream, Library);

            fileStream.Close();
        }

        private static void Prepare()
        {
            SaveLocation = "%AppData%//TurboWeeb";

            SaveLocation = Environment.ExpandEnvironmentVariables(SaveLocation);

            if (!Directory.Exists(SaveLocation))
            {
                Directory.CreateDirectory(SaveLocation);
            }

            SaveLocation += "//Library.bin";
        }
    }
}
