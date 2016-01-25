using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Util
{
    public class CustomXmlSerializer
    {
        public static void Serialize(object toSave, string path, string filename)
        {
            string xml = ConvertToXml(toSave, 0);

            using (StreamWriter sw = new StreamWriter(path + filename))
            {
                sw.Write(xml);
            }
        }

        public static T Deserialize<T>(string path, string filename)
        {
            string xml = "read went wrong";

            using (StreamReader sr = new StreamReader(path + filename))
            {
                xml = sr.ReadToEnd();
            }

            xml = xml.Replace("\t", "");

            string[] xmlLines = xml.Split('\n');

            string type = xmlLines[0];
            type.Replace("<", "");
            type.Replace(">", "");
            type.Replace("/", "");

            if (typeof(T).ToString().Equals(type))
            {
                //starting at 1, as we have analyzed the root, ending at length-1 as we dont need the closing of the root
                for (int i = 1; i < xmlLines.Length - 1; i++)
                {
                    string xmlLine = xmlLines[i];

                    string[] tagvalue = AnalyzeXmlLine(xmlLine);

                    string tag = tagvalue[0];
                    string value = tagvalue[1];

                    if(value != null) {
                        PropertyInfo pi = typeof(T).GetProperty(tag);
                    }
                }
            }
            else
            {
                throw new Exception(String.Format("Type mismatch between T: {0} and XML: {1}", typeof(T), type));
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns two strings. [0] is the tag, [1] is the value. 
        /// If there is more than one line of value for the tag, then [1] is null.
        /// </summary>
        /// <param name="line">The line to analyze</param>
        /// <returns>Two strings: The tag and its value, respectively. Value can be null.</returns>
        private static string[] AnalyzeXmlLine(string line)
        {
            string[] result = new string[2];
            line = line.Replace("\t", "");

            //goes from 1, as the first char is a '<'
            result[0] = line.Substring(1, line.IndexOf('>'));

            //if there is a closing tag on this line
            if (line.IndexOf("</") >= 0)
            {
                result[1] = line.Substring(result[0].Length + 1, line.IndexOf('<'));
            }

            return result;
        }

        private static string ConvertToXml(object toConvert, int layersFromRoot = 0)
        {
            string xml = "";
            string layertab = "";

            for (int i = 0; i < layersFromRoot; i++)
            {
                layertab += "\t";
            }

            Type objectType = toConvert.GetType();


            //an enum is (one of?) the only types not to have propertyinfos
            if (objectType.BaseType.Equals(typeof(Enum)))
            {
                xml += String.Format("{0}<{1}>{2}</{3}>\n", layertab, objectType, toConvert, objectType);
            }
            else
            {
                //AModel model = (AModel)toConvert;
                xml += String.Format("{0}<{1}>\n", layertab, objectType.ToString());

                List<PropertyInfo> properties = new List<PropertyInfo>(objectType.GetProperties());

                foreach (PropertyInfo pi in properties)
                {
                    xml += HandlePropertyInfo(pi, toConvert, layersFromRoot + 1);
                }

                xml += String.Format("{0}</{1}>\n", layertab, objectType);
            }

            return xml;
        }

        private static string HandlePropertyInfo(PropertyInfo pi, object toConvert, int layersFromRoot)
        {
            string layertab = GetLayerTab(layersFromRoot);
            Type propType = pi.PropertyType;
            string xml = "";
            if (propType.IsArray)
            {
                Array propArr = (Array)pi.GetValue(toConvert);

                //TODO: not have this?
                if (propArr.Length == 0)
                {
                    xml += String.Format("{0}<{1}></{2}>\n", layertab, pi.Name, pi.Name);
                }
                else
                {
                    xml += String.Format("{0}<{1}>\n", layertab, pi.Name);
                    for (int i = 0; i < propArr.Length; i++)
                    {
                        xml += ConvertToXml(propArr.GetValue(i), layersFromRoot + 1);
                    }
                    xml += String.Format("{0}</{1}>\n", layertab, pi.Name);
                }
            }
            else if (propType.IsPrimitive || propType.Equals(typeof(string)) || propType.Equals(typeof(Enum)))
            {
                xml += String.Format("{0}<{1}>{2}</{3}>\n", layertab, pi.Name, pi.GetValue(toConvert), pi.Name);

            }
            else
            {
                if (pi.GetValue(toConvert) == null)
                {
                    xml += String.Format("{0}<{1}></{2}>\n", layertab, pi.Name, pi.Name);
                }
                else
                {
                    xml += ConvertToXml(pi.GetValue(toConvert), layersFromRoot + 1);
                }
            }

            return xml;
        }

        private static string GetLayerTab(int layersFromRoot)
        {
            string lt = "";
            for (int i = 0; i < layersFromRoot; i++)
            {
                lt += "\t";
            }

            return lt;
        }
    }
}
