using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Controllers.Util
{
    public class ProjectSerializer
    {
        public ProjectSerializer(string rootPath)
        {
            Root = rootPath;
            Root = MakeDirectory(Root);
        }

        public string Root { get; private set; }


        public T Load<T>(string path)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(T));

            StreamReader sr = new StreamReader(path);

            return (T)xmlser.Deserialize(sr);
        }

        /// <summary>
        /// Saves an object as an xml file to Root\localPath. If localPath is not given, then Root is used.
        /// </summary>
        /// <param name="toSave">the object to save as xml</param>
        /// <param name="localPath">The path to save to. If null, then Root is used</param>
        public void Save(object toSave, string filename, string localPath = null)
        {
            localPath = localPath == null ? Root : Root + localPath;
            localPath = MakeDirectory(localPath);

            XmlSerializer xmlser = new XmlSerializer(typeof(object));

            StreamWriter sw = new StreamWriter(localPath + filename);

            xmlser.Serialize(sw, toSave);
        }

        private string MakeDirectory(string path)
        {
            if (!(path.EndsWith("\\") || path.EndsWith("/")))
            {
                if (path.Contains("/"))
                {
                    path += "/";
                }
                else
                {
                    path += "\\";
                }
            }

            return path;
        }
    }
}
