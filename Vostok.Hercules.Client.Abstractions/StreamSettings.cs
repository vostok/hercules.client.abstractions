using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <para>Represent <see cref="IHerculesSink"/> per-stream settings.</para>
    /// </summary>
    [PublicAPI]
    public class StreamSettings
    {
        /// <summary>
        /// <para>Delegate that returns Hercules gateway API key with write access for specific stream.</para>
        /// </summary>
        public Func<string> ApiKeyProvider;
    }
}