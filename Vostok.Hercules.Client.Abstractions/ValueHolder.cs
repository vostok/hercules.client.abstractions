using System.Collections.Generic;

namespace Vostok.Hercules.Client.Abstractions
{
    internal class ValueHolder
    {
        public ValueHolder(Dictionary<string, ValueHolder> value)
        {
            Value = value;
        }

        public ValueHolder(byte value)
        {
            Value = value;
        }

        public ValueHolder(short value)
        {
            Value = value;
        }

        public ValueHolder(int value)
        {
            Value = value;
        }

        public ValueHolder(long value)
        {
            Value = value;
        }

        public ValueHolder(bool value)
        {
            Value = value;
        }

        public ValueHolder(float value)
        {
            Value = value;
        }

        public ValueHolder(double value)
        {
            Value = value;
        }

        public ValueHolder(string value)
        {
            Value = value;
        }

        public ValueHolder(Dictionary<string, ValueHolder>[] value)
        {
            Value = value;
        }

        public ValueHolder(byte[] value)
        {
            Value = value;
        }

        public ValueHolder(short[] value)
        {
            Value = value;
        }

        public ValueHolder(int[] value)
        {
            Value = value;
        }

        public ValueHolder(long[] value)
        {
            Value = value;
        }

        public ValueHolder(bool[] value)
        {
            Value = value;
        }

        public ValueHolder(float[] value)
        {
            Value = value;
        }

        public ValueHolder(double[] value)
        {
            Value = value;
        }

        public ValueHolder(string[] value)
        {
            Value = value;
        }

        public object Value { get; }
    }
}