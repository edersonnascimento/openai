namespace ECNOpenAI.Chat.Response
{
    ///<summary>
    /// Usage statistics for the completion request.
    ///</summary>
    ///<inheritdoc path="https://platform.openai.com/docs/api-reference/chat/object"/>
    public class Usage
    {
        ///<summary>
        /// Number of tokens in the generated completion.
        ///</summary>
        public int completion_tokens { get; set; }
        ///<summary>
        /// Number of tokens in the prompt.
        ///</summary>
        public int prompt_tokens { get; set; }
        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).
        /// </summary>
        public int total_tokens { get; set; }
    }
}
