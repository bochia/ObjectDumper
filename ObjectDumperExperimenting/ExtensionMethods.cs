using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObjectDumperExperimenting
{
    public static class ExtensionMethods
    {
        public static string Dump(this object anyObject)
        {
            string json = JsonSerializer.Serialize(anyObject);
            json = JsonFormatterPlus.JsonFormatter.Format(json);

            return json;
        }
    }
}
