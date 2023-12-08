using System;

namespace Assets.Code
{
    public class Wraper<T> : IDisposable
    {
        public T[] items;

        public static string ConvertJsonPath(string json) => string.Concat("{ \"items\":", json, "}");

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
