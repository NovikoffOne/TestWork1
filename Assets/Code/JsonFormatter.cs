using System.IO;
using UnityEngine;

namespace Assets.Code
{
    public class JsonFormatter
    {
        public Data[] GetFormatData(string path = "Assets/Content/JsonTest1.json")
        {
            var jsonString = File.ReadAllText(path);

            using (var data = JsonUtility.FromJson<Wraper<Data>>(Wraper<Data>.ConvertJsonPath(File.ReadAllText(path))))
            {
                return data.items;
            }
        }
    }
}
