using System.Xml.Serialization;

namespace Parser
{
    [XmlRoot("user")]
    public class User
    {
        [XmlElement("user_id")]
        public long UserId { get; set; }
        [XmlElement ("tg_name")]
        public string TgName { get; set; }
        public User() 
        {
            UserId = 0;
            TgName = "Empty";
        }
        public User(long userId, string tgName)
        {
            UserId = userId;
            TgName = tgName;
        }
        public void SetTgName(string tgName) => TgName = tgName;
    }
}