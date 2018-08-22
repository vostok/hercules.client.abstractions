using System;
using System.Collections.Generic;

namespace Vostok.Hercules.Client.Abstractions
{
    public class HerculesRecord
    {
        public DateTimeOffset Timestamp { get; set; }
        public Dictionary<string, TagValue> Tags { get; set; }
    }
}