using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Repository
{
    public class Config
    {
        [NonSerialized()]

        #region Fields
        private static string _fileName;
        private static Config instance = new Config();
        #endregion

        #region config public properties
        public string SqlDatabase { get; set; }
        public string Caption { get; set; }
        public string ConnectionString { get; set; }

        public void SaveConfig()
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());

            using (XmlTextWriter writer = new XmlTextWriter(_fileName, Encoding.Default))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                serializer.Serialize(writer, this);
            }
        }

        #endregion Properties

        #region CTOR
        private Config()
        { }
        #endregion

        #region Methods
        public static Config GetInstance(string filename)
        {
            _fileName = filename;

            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (StreamReader reader = new StreamReader(_fileName))
            {
                try
                {
                    instance = (Config)serializer.Deserialize(reader);
                }
                catch
                { }
            }
            return instance;
        }
        #endregion
    }
}
