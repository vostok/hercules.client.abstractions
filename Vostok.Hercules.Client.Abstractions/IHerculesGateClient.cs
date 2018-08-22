using System;

namespace Vostok.Hercules.Client.Abstractions
{
    public interface IHerculesGateClient
    {
        void Put(string stream, Action<IHerculesRecordBuilder> build);
    }
}