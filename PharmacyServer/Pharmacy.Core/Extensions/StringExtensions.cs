using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Pharmacy.Domain.Extensions
{
    public static class StringExtensions
    {
        public static T ParseAsJson<T>(this string str)
            => JsonConvert.DeserializeObject<T>(str, new IsoDateTimeConverter());
    }
}