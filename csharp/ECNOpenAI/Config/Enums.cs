using System.ComponentModel;

namespace ECNOpenAI.Config
{
    public enum GPTModel
    {
        [Description("gpt-4-1106-preview")]
        GPT_4_1106_PREVIEW,
        [Description("gpt-4")]
        GPT_4,
        [Description("gpt-4-32k")]
        GPT_4_32K,
        [Description("gpt-3.5-turbo-1106")]
        GPT_3_5_TURBO_1106,
        [Description("gpt-3.5-turbo")]
        GPT_3_5_TURBO,
        [Description("gpt-3.5-turbo-16k")]
        GPT_3_5_TURBO_16K,
    }

    public enum DALL_EModel
    {
        [Description("dall-e-3")]
        DALL_E_3,
        [Description("dall-e-2")]
        DALL_E_2,
    }

    public enum TTSModel
    {
        [Description("tts-1")]
        TTS_1,
        [Description("tts-1-hd")]
        TTS_1_HD,
    }
}
