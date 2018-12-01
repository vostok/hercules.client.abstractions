using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <para><see cref="IHerculesSink"/> is a fire-and-forget way to send events to Hercules.</para>
    /// <para>It is intended to be the primary abstraction used to instrument applications (as opposed to <see cref="IHerculesGateClient"/>).</para>
    /// <para>It guarantees following properties that must be satisfied by all implementations:</para>
    /// <list type="bullet">
    ///     <item><description>Thread safety: <see cref="Put"/> can be safely called from multiple threads concurrently.</description></item>
    ///     <item><description>Asynchrony: all calls to <see cref="Put"/> are nonblocking.</description></item>
    ///     <item><description>Error handling: unavailability of Hercules servers does not lead to client exceptions.</description></item>
    ///     <item><description>Resource limits: internal event buffers have a configurable size bound.</description></item>
    /// </list>
    /// <para>Delivery is not guaranteed: events can be lost due to memory constraints or Hercules unavailability.</para>
    /// </summary>
    [PublicAPI]
    public interface IHerculesSink
    {
        /// <summary>
        /// <para>Builds a <see cref="HerculesEvent"/> using given <paramref name="buildEvent"/> delegate and queues it for delivery to given <paramref name="stream"/>.</para>
        /// </summary>
        void Put([NotNull] string stream, [NotNull] Action<IHerculesEventBuilder> buildEvent);
    }
}