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

        /// <summary>
        /// Extension method that can dump contents of any object, which includes collections of objects. 
        /// Comes in handy for debugging and logging purposes. 
        /// </summary>
        /// <param name="anyObject"></param>
        /// <returns></returns>
        public static string Dump(this object anyObject)
        {
            string json = JsonSerializer.Serialize(anyObject);
            json = JsonFormatterPlus.JsonFormatter.Format(json);

            return json;
        }
    }
}
