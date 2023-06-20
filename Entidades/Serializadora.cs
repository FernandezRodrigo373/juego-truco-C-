using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class Serializadora
    {
        public static void SerializarAXml<T>(string ruta, T objecto)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, objecto);
            }
        }

        public static T DeserializarDesdeAXml<T>(string ruta)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "ArrayOfCarta";
            xRoot.IsNullable = true;

            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xRoot);
                T objeto = (T)xmlSerializer.Deserialize(streamReader);

                return objeto;
            }
        }
    }
}
