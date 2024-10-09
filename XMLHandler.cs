using System.Xml.Serialization;

namespace Parser
{
    internal static class XMLHandler
    {
        public static string path = "data.xml";
        public static User ReadXML()
        {
            User channelInfo = new();
            if (System.IO.File.Exists(path))
            {
                XmlSerializer formatter = new(typeof(User));
                
                using (FileStream fs = new(path, FileMode.OpenOrCreate))
                {
                    channelInfo = formatter.Deserialize(fs) as User;
                }

            }
            return channelInfo;
        }
        public static void WriteXML(User info)
        {
            User temp = new();

            temp = ReadXML();

            bool flag = false;

            for (int i = 0; i < temp.Channels.Count; i++)
            {
                if (temp.Channels[i].ChatID == info.ChatID)
                {
                    temp.Channels[i] = info;
                    flag = true;
                    break;
                }
            }
            if (!flag) temp.Channels.Add(info);

            XmlSerializer serialize = new(typeof(User));
            using (FileStream fs = new(path, FileMode.Create))
                serialize.Serialize(fs, temp);
            Console.WriteLine("Объект записан в XML-документ.");
        }
    }
}