using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public partial interface IHerculesTagsBuilder
    {

    #region byte
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, byte value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<byte> values);
    #endregion

    #region bool
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, bool value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<bool> values);

    #endregion

    #region short
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, short value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<short> values);

    #endregion

    #region int
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, int value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<int> values);

    #endregion

    #region long
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, long value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<long> values);

    #endregion

    #region float
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, float value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<float> values);

    #endregion

    #region double
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, double value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<double> values);

    #endregion

    #region Guid
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, Guid value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<Guid> values);

    #endregion

    #region string
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, string value);

        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<string> values);

    #endregion

    }
}