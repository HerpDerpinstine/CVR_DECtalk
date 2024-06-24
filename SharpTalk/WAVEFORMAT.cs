namespace SharpTalk
{
    public enum WAVEFORMAT : uint
    {
        INVALID = 0,
        FORMAT_1M08 = 0x00000001,       /* 11.025 kHz, Mono,   8-bit */
        FORMAT_1S08 = 0x00000002,       /* 11.025 kHz, Stereo, 8-bit */
        FORMAT_1M16 = 0x00000004,       /* 11.025 kHz, Mono,   16-bit */
        FORMAT_1S16 = 0x00000008,       /* 11.025 kHz, Stereo, 16-bit */
        FORMAT_2M08 = 0x00000010,       /* 22.05  kHz, Mono,   8-bit */
        FORMAT_2S08 = 0x00000020,       /* 22.05  kHz, Stereo, 8-bit */
        FORMAT_2M16 = 0x00000040,       /* 22.05  kHz, Mono,   16-bit */
        FORMAT_2S16 = 0x00000080,       /* 22.05  kHz, Stereo, 16-bit */
        FORMAT_4M08 = 0x00000100,       /* 44.1   kHz, Mono,   8-bit */
        FORMAT_4S08 = 0x00000200,       /* 44.1   kHz, Stereo, 8-bit */
        FORMAT_4M16 = 0x00000400,       /* 44.1   kHz, Mono,   16-bit */
        FORMAT_4S16 = 0x00000800,       /* 44.1   kHz, Stereo, 16-bit */
        FORMAT_08M08 = 0x00001000,      /* 8      kHz, Mono,   8-bit */
        FORMAT_08M16 = 0x00002000,      /* 8      kHz, Mono,   16-bit */
        FORMAT_MULAW = 0x00000007,      /* 8      kHz, Mono,   Mu-law */
    }
}
