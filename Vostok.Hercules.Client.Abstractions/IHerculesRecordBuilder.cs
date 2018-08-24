using System;

namespace Vostok.Hercules.Client.Abstractions
{
    public interface IHerculesRecordBuilder : IHerculesRecordPayloadBuilder
    {
        IHerculesRecordBuilder SetTimestamp(DateTimeOffset timestamp);
    }
}