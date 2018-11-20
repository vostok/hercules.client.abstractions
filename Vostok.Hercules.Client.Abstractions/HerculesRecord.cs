using System;
using System.Collections.Generic;

namespace Vostok.Hercules.Client.Abstractions
{
    internal class HerculesRecord
    {
        public DateTimeOffset Timestamp { get; set; }
        public Dictionary<string, ValueHolder> Tags { get; set; }
    }
}