using System;
using System.IO;
using static UnityEngine.JsonUtility;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Code
{
    public class JsonFormatter : IDisposable
    {
        public Data GetFormatData(string path = "Assets/Content/JsonTest1.json")
        {
            var jsonString = File.ReadAllText(path);

            Debug.Log(jsonString);

            Data data = FromJson<Data>(jsonString);

            Dispose();

            return data;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
