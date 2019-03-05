using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    [PublicAPI]
    public enum StreamType
    {
        /// <summary>
        /// <para>Base streams are primary raw data sources in Hercules.</para>
        /// <para>Base streams are filled by Hercules clients and can be used to build derived streams and timelines.</para>
        /// </summary>
        Base,

        /// <summary>
        /// <para>Derived streams are automatically built from one or more base streams with optional filtering and resharding.</para>
        /// <para>Derived streams cannot be written to directly by clients.</para>
        /// <para>They can be used to build other derived streams (create stream chains) and timelines.</para>
        /// </summary>
        Derived
    }
}