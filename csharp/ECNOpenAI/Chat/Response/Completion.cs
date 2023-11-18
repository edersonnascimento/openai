namespace ECNOpenAI.Chat.Response
{
    /// <summary>
    /// Represents a chat completion response returned by model, based on the provided input.
    /// </summary>
    /// <inheritdoc path="https://platform.openai.com/docs/api-reference/chat/object"/>
    public class Completion
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// A list of chat completion choices. Can be more than one if n is greater than 1.
        /// </summary>
        public IList<Choices> choices { get; set; }
        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </summary>
        public int created { get; set; }
        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.
        ///
        /// Can be used in conjunction with the seed request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        public string system_fingerprint { get; set; }
        /// <summary>
        /// The object type, which is always chat.completion.
        /// </summary>
        public string _object_ => "chat.completion";
        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        public Usage usage { get; set; }
    }
}
