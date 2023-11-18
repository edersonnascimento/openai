﻿namespace ECNOpenAI.Chat.Response
{
    /// <summary>
    /// The function that the model called.
    /// </summary>
    /// <inheritdoc path="https://platform.openai.com/docs/api-reference/chat/object"/>
    public class Function
    {
        /// <summary>
        /// The name of the function to call.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The arguments to call the function with, as generated by the model in JSON format. 
        /// Note that the model does not always generate valid JSON, and may hallucinate parameters not defined by your function schema. 
        /// Validate the arguments in your code before calling your function.
        /// </summary>
        public string arguments { get; set; }
    }
}
