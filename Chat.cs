using System.Xml.Serialization;
using System.Collections.Generic;

namespace Parser
{
    [XmlRoot("chat")]
    public class Chat
    {
        [XmlElement("Chat_id")]
        public long ChatlId { get; set; }
        [XmlElement ("Chat_title")]
        public string ChatTitle { get; set; }
        [XmlElement("Channel_id")]
        public long ChannelId { get; set; }
        [XmlElement ("Channel_Users")]
        public List<User> Users;
        public Channel() 
        {
            ChatlId = 0;
            ChannelId = 0;
            ChatTitle = "Empty";
            Users = [];
        }
        public void SetChatTitle(string chatTitle) => ChatTitle = chatTitle;
    }
}