using System.Xml.Serialization;
using System.Collections.Generic;

namespace Parser
{
    [XmlRoot("message")]
    public class Message
    {
        [XmlElement("Message_id")]
        public long MessageId { get; set; }
        [XmlElement ("Message_title")]
        public string MessageTitle { get; set; }
        [XmlElement("Message_text")]
        public string MessageText { get; set; }
        public Message() 
        {
            MessageId = 0;
            MessageTitle = "Empty";
            MessageText = "Empty";
        }
    }
}