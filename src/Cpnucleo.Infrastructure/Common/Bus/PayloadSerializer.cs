﻿namespace Cpnucleo.Infrastructure.Common.Bus;

internal sealed class PayloadSerializer : IMessagePayloadSerializer
{
    private static readonly JsonSerializerSettings Settings = new()
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        Formatting = Formatting.None,
        Converters =
            {
                new StringEnumConverter()
            },
        NullValueHandling = NullValueHandling.Ignore
    };

    public SerializationResult SerializeBody(object objectToSerialize)
    {
        var json = JsonConvert.SerializeObject(objectToSerialize, Formatting.None, Settings);
        return new SerializationResult("application/json", Encoding.UTF8.GetBytes(json));
    }

    public object DeSerializeBody(byte[] content, Type typeToCreate)
    {
        var @string = Encoding.UTF8.GetString(content);
        return JsonConvert.DeserializeObject(@string, typeToCreate, Settings)!;
    }
}
