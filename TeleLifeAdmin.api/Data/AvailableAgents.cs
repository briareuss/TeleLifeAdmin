using System;

namespace TeleLifeAdmin.api.Data
{
    public class CompletionCode
    {
        public int Id { get; set; }
        public int UserContactId { get; set; }
        public string CompletionCodeName { get; set; }
        public DateTime CompletionCodeTimestamp { get; set; }
    }
}
