using Newtonsoft.Json;

namespace ArtUtil
{
    public class JsonParser
    {
        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}