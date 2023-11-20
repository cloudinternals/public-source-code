using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var filepath = args[0];

using (StreamReader file = File.OpenText(filepath))
using (JsonTextReader reader = new JsonTextReader(file))
{
    JObject obj = (JObject)JToken.ReadFrom(reader);
    Console.WriteLine(obj);
}

