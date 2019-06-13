using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// Provides a way to customize reading of hercules events.
    /// </summary>
    [PublicAPI]
    public interface IEventsBinaryReader<T>
    {
        IList<T> Read(byte[] bytes, int offset);
    }
}