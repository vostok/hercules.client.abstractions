using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public partial interface IHerculesTagsBuilder
    {
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