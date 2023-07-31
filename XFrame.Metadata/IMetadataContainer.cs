﻿namespace XFrame.Metadata
{
    public interface IMetadataContainer : IReadOnlyDictionary<string, string>
    {
        string GetMetadataValue(string key);

        T GetMetadataValue<T>(string key, Func<string, T> converter);
    }
}
