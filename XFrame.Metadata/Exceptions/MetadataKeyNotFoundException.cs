﻿namespace XFrame.Metadata.Exceptions
{
    public class MetadataKeyNotFoundException : ArgumentOutOfRangeException
    {
        public MetadataKeyNotFoundException(string key)
            : base($"Could not find metadata key '{key}'")
        {
        }
    }
}
