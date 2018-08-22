using System;

namespace Vostok.Hercules.Client.Abstractions
{
    public interface IHerculesRecordBuilder
    {
        IHerculesRecordBuilder SetTimestamp(DateTimeOffset timestamp);
        IHerculesRecordBuilder Add(string key, byte value);
        IHerculesRecordBuilder Add(string key, short value);
        IHerculesRecordBuilder Add(string key, int value);
        IHerculesRecordBuilder Add(string key, long value);
        IHerculesRecordBuilder Add(string key, bool value);
        IHerculesRecordBuilder Add(string key, float value);
        IHerculesRecordBuilder Add(string key, double value);
        IHerculesRecordBuilder Add(string key, string value);
        IHerculesRecordBuilder Add(string key, byte[] value);
        IHerculesRecordBuilder Add(string key, short[] value);
        IHerculesRecordBuilder Add(string key, int[] value);
        IHerculesRecordBuilder Add(string key, long[] value);
        IHerculesRecordBuilder Add(string key, bool[] value);
        IHerculesRecordBuilder Add(string key, float[] value);
        IHerculesRecordBuilder Add(string key, double[] value);
        IHerculesRecordBuilder Add(string key, string[] value);
    }
}