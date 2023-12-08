using System;
using System.IO;
using static UnityEngine.JsonUtility;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Code
{
    public class JsonFormatter : IDisposable
    {
        public Data[] GetFormatData(string path = "Assets/Content/JsonTest1.json")
        {
            var jsonString = File.ReadAllText(path);

            var data = FromJson<Rootobject>(jsonString);

            Debug.Log(data.Property[0].question);

            Dispose();

            return data.Property;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
