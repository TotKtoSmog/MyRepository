using System.Xml.Serialization;
using System.Collections.Generic;

namespace Parser
{
    [XmlRoot("channel")]
    public class Channel
    {
        [XmlElement("Channel_id")]
        public long ChannelId { get; set; }
        [XmlElement ("Channel_title")]
        public string ChannelTitle { get; set; }
        [XmlElement ("Channel_Users")]
        public List<User> Users;
        public Channel() 
        {
            ChannelId = 0;
            ChannelTitle = "Empty";
            Users = [];
        }
        public Channel(long channelId, string channelTitle, List<User> users)
        {
            ChannelId = channelId;
            ChannelTitle = channelTitle;
            Users = users;
        }
    }
}