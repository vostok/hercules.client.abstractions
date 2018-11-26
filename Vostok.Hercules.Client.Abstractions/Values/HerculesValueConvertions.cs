using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesValue
    {
        public int AsInt => ExtractValue<HerculesInt, int>();

        public HerculesTags AsContainer => ExtractValue<HerculesContainer, HerculesTags>();

        public HerculesValue[] AsArray => ExtractValue<HerculesArray, HerculesValue[]>();

        private TValue ExtractValue<TImpl, TValue>()
            where TImpl : HerculesValue<TValue>
        {
            return ((TImpl) this).TypedValue;
        }
    }
}