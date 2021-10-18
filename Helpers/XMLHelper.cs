using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SimpleSDK.Helpers
{
    public class XMLHelper
    {
        public static T DeserializeFromString<T>(string text)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T obj;
            //using (StreamReader reader = new StreamReader(text))
            using (StringReader reader = new StringReader(text))
            {
                obj = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            return obj;
        }

        public static T TryDeserializeFromString<T>(string text)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T obj;

            using (StringReader reader = new StringReader(text.Replace("xmlns=\"http://www.sii.cl/SiiDte\"", "")))
            {
                obj = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            return obj;
        }

    }
}
