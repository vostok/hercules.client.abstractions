using System;

namespace Vostok.Hercules.Client.Abstractions
{
    public interface IHerculesRecordPayloadBuilder
    {
        IHerculesRecordPayloadBuilder Add(string key, Func<IHerculesRecordPayloadBuilder, IHerculesRecordPayloadBuilder> buildContainer);
        IHerculesRecordPayloadBuilder Add(string key, byte value);
        IHerculesRecordPayloadBuilder Add(string key, short value);
        IHerculesRecordPayloadBuilder Add(string key, int value);
        IHerculesRecordPayloadBuilder Add(string key, long value);
        IHerculesRecordPayloadBuilder Add(string key, bool value);
        IHerculesRecordPayloadBuilder Add(string key, float value);
        IHerculesRecordPayloadBuilder Add(string key, double value);
        IHerculesRecordPayloadBuilder Add(string key, string value);
        IHerculesRecordPayloadBuilder Add(string key, byte[] value);
        IHerculesRecordPayloadBuilder Add(string key, short[] value);
        IHerculesRecordPayloadBuilder Add(string key, int[] value);
        IHerculesRecordPayloadBuilder Add(string key, long[] value);
        IHerculesRecordPayloadBuilder Add(string key, bool[] value);
        IHerculesRecordPayloadBuilder Add(string key, float[] value);
        IHerculesRecordPayloadBuilder Add(string key, double[] value);
        IHerculesRecordPayloadBuilder Add(string key, string[] value);
    }
}