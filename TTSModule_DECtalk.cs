using ABI_RC.Systems.Communications.TTS;
using MelonLoader;
using SharpTalk;
using System;

namespace CVR_DECtalk
{
    internal class TTSModule_DECtalk : Comms_TTSModule
    {
        private static Type _ttsVoiceType = typeof(TtsVoice);
        private DECtalkEngine _tts;

        public override void Initialize()
        {
            SampleRate = 11025;

            MelonLogger.Msg("Initializing Engine...");
            _tts = new DECtalkEngine(LanguageCode.None);

            MelonLogger.Msg("Loading Voices...");
            foreach (TtsVoice ttsVoice in (TtsVoice[])Enum.GetValues(_ttsVoiceType))
            {
                string name = Enum.GetName(_ttsVoiceType, ttsVoice);
                Voices[name] = name;
            }

            MelonLogger.Msg("Text-To-Speech Module has been Initialized!");
        }

        public override short[] Process(string msg)
        {
            _tts.Voice = (TtsVoice)Enum.Parse(typeof(TtsVoice), CurrentVoice);

            byte[] memory = _tts.SpeakToMemory(msg);
            if (memory == null)
                return null;

            int length = memory.Length;
            short[] dst = new short[length];
            Buffer.BlockCopy(memory, 0, dst, 0, length);
            return dst;
        }
    }
}
