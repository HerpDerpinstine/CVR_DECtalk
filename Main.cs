using ABI_RC.Systems.Communications.Audio.TTS;
using CVR_DECtalk.Properties;
using MelonLoader;
using MelonLoader.Utils;
using System.IO;

namespace CVR_DECtalk
{
    public static class BuildInfo
    {
        public const string Name = "CVR_DECtalk";
        public const string Description = "Adds DECtalk support to Text-To-Speech";
        public const string Author = "Herp Derpinstine";
        public const string Company = "Lava Gang";
        public const string Version = "1.0.3";
        public const string DownloadLink = "https://github.com/HerpDerpinstine/CVR_DECtalk";
    }

    public class CVR_DECtalk : MelonMod
    {
        internal static MelonLogger.Instance logger;

        public override void OnInitializeMelon()
        {
            logger = LoggerInstance;

            WriteFile("DECtalk.dll", Resources.DECtalk_dll);
            WriteFile("dtalk_us.dll", Resources.dtalk_us_dll);
            WriteFile("dtalk_us.dic", Resources.dtalk_us_dic);

            MelonLogger.Msg("Adding TTS Module...");
            Comms_TTSHandler.AddModule<TTSModule_DECtalk>("DECtalk", "DECtalk");
            MelonLogger.Msg("TTS Module Added!");
        }

        private void WriteFile(string fileName, byte[] fileData)
        {
            MelonLogger.Msg($"Extracting {fileName} from Embedded Resource...");
            string filePath = Path.Combine(MelonEnvironment.GameRootDirectory, fileName);
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllBytes(filePath, fileData);
        }
    }
}