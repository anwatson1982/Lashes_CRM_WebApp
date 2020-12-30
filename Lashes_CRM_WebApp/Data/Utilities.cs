using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Lashes_CRM_WebApp
{
    public static class Utilities
    {
        public static T XMLLoad<T>(string fileName) where T : new()
        {
            if (File.Exists(fileName))
            {
                Console.WriteLine($"Loading database...");
                StreamReader xmlDatabase = new StreamReader(fileName);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                T result = (T)serializer.Deserialize(xmlDatabase);
                //_customers = CustomerLists;
                xmlDatabase.Close();
                return result;
            }
            else
            {
                var empty = new T();
                Console.WriteLine($"No file found.... Creating database");
                XmlSerializer xs = new XmlSerializer(typeof(T));
                TextWriter txtWriter = new StreamWriter(fileName);
                xs.Serialize(txtWriter, empty);

                return empty;
            }
        }
        public static bool XMLSave<T>(string fileName, T dataList)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                TextWriter txtWriter = new StreamWriter(fileName);
                xs.Serialize(txtWriter, dataList);
                txtWriter.Close();
                return true;
            }
            catch(Exception e)
            {
                //put information about exception into logfile
                return false;
           }
           
        }
    }
}
