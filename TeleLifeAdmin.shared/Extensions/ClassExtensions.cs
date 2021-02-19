using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TeleLifeAdmin.shared.Extensions
{

    public static partial class ClassExtensions
    {
        public static void Merge<K, V>(this IDictionary<K, V> target, IDictionary<K, V> source, bool overwrite = false)
        {
            source.ToList().ForEach(_ =>
            {
                if ((!target.ContainsKey(_.Key)) || overwrite)
                    target[_.Key] = _.Value;
            });
        }

        public static string CamelCaseSpace(this string camelString)
        {
            var spaceString =Regex.Replace(camelString, "((?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z]))", " $1");
            return spaceString;
        }
    }
}

