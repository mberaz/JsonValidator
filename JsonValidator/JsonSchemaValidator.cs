using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace JsonValidator
{
    public static class JsonSchemaValidator
    {
        public static bool Validate<T> (T obj,string json) => Validate(obj,JObject.Parse(json));

        public static bool Validate<T> (T obj,JObject json) => Validate(obj.GetType(),json);
        

        public static bool Validate (Type type,JObject json)
        {
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema schema = generator.Generate(type);

            return json.IsValid(schema);
        }
    }
}