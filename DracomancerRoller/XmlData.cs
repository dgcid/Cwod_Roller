using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DracomancerRoller
{
    public class XmlSave
    {
        public static void SaveData (Object IClass, String filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((IClass.GetType()));
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, IClass);
            }
            finally
            {
                if ( writer is null)
                writer.Close();
                writer = null;
            
            }
        }

    }

    public class XmlLoad<T>
    {

        public static Type type;

        public XmlLoad()
        {
            type = typeof(T);

        }

        public T LoadData(String filename)
        {
            T result;
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            result = (T)xmlSerializer.Deserialize(fs);
            fs.Close();
            return result;

        }
    }
}
