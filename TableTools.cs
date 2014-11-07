using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Ionic.Zip;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SMART_Table_Activty_Exporter
{
    class TableTools
    {
        public static string GetManifestText(string fpath)
        {
            System.IO.Compression.ZipArchive contentFile = System.IO.Compression.ZipFile.OpenRead(fpath);
            System.IO.Compression.ZipArchiveEntry manifest = contentFile.GetEntry("imsmanifest.xml");
            TextReader textReader = new StreamReader(manifest.Open());
            return textReader.ReadToEnd();
        }

        public static void ExtractActivityDirectory(string activity, string fpath, string opath)
        {
            using (ZipFile contentFile = ZipFile.Read(fpath))
            {
                var selection = (from e in contentFile.Entries
                                 where (e.FileName).StartsWith(activity+"/")
                                 select e);

                Directory.CreateDirectory(opath);
                foreach (var e in selection)
                {
                    e.Extract(opath);
                }
            }
        }

        public static List<string> GetActivitiesFromManifest(string text)
        {
            List<string> activities = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            JObject manifest = (JObject) JObject.Parse(jsonText)["manifest"];
            JObject orgs = (JObject) manifest["organizations"];
            for (int i = 0; i < orgs.Count; i++)
            {
                JObject org = (JObject) orgs["organization"];
                if(org["item"].GetType().ToString().Equals("Newtonsoft.Json.Linq.JArray")){
                    JArray items = (JArray) org["item"];
                    for (int i2 = 0; i2 < items.Count; i2++)
                    {
                        JObject item = (JObject) items[i2];
                        activities.Add((string) item["title"]);
                    }
                }else{
                    JObject item = (JObject) org["item"];
                    activities.Add((string) item["title"]);
                }
            }
            return activities;
        }

        public static string GetResourceXmlForActivity(string text, string name){
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            JObject manifest = (JObject)JObject.Parse(jsonText)["manifest"];
            return "";
        }

        public static string GetActivityName(string fpath)
        {
            string config = File.ReadAllText(Directory.GetFiles(fpath, "config.xml")[0]);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(config);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            JObject configObj = (JObject) JObject.Parse(jsonText)["TableApplication"];
            return (string) configObj["@name"];
        }
    }
}
