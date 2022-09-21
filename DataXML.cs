using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Project_RPG_JMA
{
    public class DataXML
    {
        private static string path = @"..\..\DATA\"; // path ="../../DATA/";

        public static void Save(string file,  List<Player> list)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (XmlWriter writer = XmlWriter.Create(file , settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                serializer.Serialize(writer, list);
            }
        }
        public static List<Player> Load(string file)
        {
            List<Player> list = new List<Player>();

            using (StreamReader reader = new StreamReader(file))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                list = (List <Player>) serializer.Deserialize(reader);
            }
            return list;
        }
    }
}
