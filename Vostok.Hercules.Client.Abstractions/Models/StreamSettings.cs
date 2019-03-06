using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
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
        [CanBeNull]
        public Func<string> ApiKeyProvider { get; set; }
    }
}