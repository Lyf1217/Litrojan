using System.Collections.Generic;
using System.Dynamic;

namespace Litrojan
{
    internal static class TrojanConfigBuilder
    {
        /// <summary>
        /// Build type-matched config object from TrojanConfig
        /// </summary>
        public static object BuildConfig(ITrojanConfig obj, RunMode Filter, RunMode CurrentMode)
        {
            var t = obj.GetType();
            
            dynamic b = new ExpandoObject();

            var properties = t.GetProperties();
            foreach (var property in properties)
            {
                if(property.Name == "run_type")
                {
                    AddProperty(b, property.Name, ConvertUsage(CurrentMode), Filter, CurrentMode);
                    continue;
                }

                if (!property.IsDefined(typeof(ConfigFieldUsageAttribute), false))
                {
                    AddProperty(b, property.Name, property.GetValue(obj), Filter, CurrentMode);
                    continue;
                }

                //var attributes = property.GetCustomAttributes(false);
                var attributes = property.GetCustomAttributes(typeof(ConfigFieldUsageAttribute), false);
                foreach (var attribute in attributes)
                {
                    var flags = (RunMode)attribute.GetType().
                      GetProperty("Usage").
                      GetValue(attribute);

                    if ((flags & Filter) != 0)
                        AddProperty(b, property.Name, property.GetValue(obj), Filter, CurrentMode);
                }
            }

            return b;
        }

        private static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue, RunMode Mode, RunMode Usage)
        {
            if (propertyValue is ITrojanConfig itc)
                propertyValue = BuildConfig(itc, Mode, Usage);

            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
        }

        private static string ConvertUsage(RunMode Usage)
        {
            string usage = "";
            int cnt = 0;
            if((Usage & RunMode.Client) != 0)
            {
                cnt++;
                usage = "client";
            }
            if ((Usage & RunMode.Router) != 0)
            {
                cnt++;
                usage = "forward";
            }
            if ((Usage & RunMode.Server) != 0)
            {
                cnt++;
                usage = "server";
            }
            if(cnt != 1)
            {
                usage = "liconf";
            }
            return usage;
        }
    }
}
