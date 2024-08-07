﻿using ABI_RC.Systems.Communications.TTS;
using SharpTalk;
using System;

namespace CVR_DECtalk
{
    internal class TTSModule_DECtalk : Comms_TTSModule
    {
        private const int WAV_HEADER_SIZE = 40;
        private const int WAV_FOOTER_SIZE = 8;
		
        private static Type _ttsVoiceType = typeof(TtsVoice);

        public override void Initialize()
        {
            Channels = 1;
            SampleRate = 11025;

            CVR_DECtalk.logger.Msg("Loading Voices...");
            foreach (TtsVoice ttsVoice in (TtsVoice[])Enum.GetValues(_ttsVoiceType))
            {
                string name = Enum.GetName(_ttsVoiceType, ttsVoice);
                Voices[name] = name;
                CVR_DECtalk.logger.Msg(name);
            }
        }

        public override short[] Process(string msg)
        {
            CVR_DECtalk.engine.Voice = (TtsVoice)Enum.Parse(typeof(TtsVoice), CurrentVoice);

            byte[] memory = CVR_DECtalk.engine.SpeakToMemory(msg, WAVEFORMAT.FORMAT_1M16);
            if (memory == null)
                return null;

            int length = memory.Length;
            int offset = ((WAV_HEADER_SIZE * 4) + WAV_FOOTER_SIZE);
            length -= offset;
			
            short[] dst = new short[length];
            Buffer.BlockCopy(memory, offset, dst, 0, length);
            return dst;
        }
    }
}
