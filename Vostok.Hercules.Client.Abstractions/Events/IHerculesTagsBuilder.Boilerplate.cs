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
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] bool[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<bool> values);
        
    #endregion

    #region short
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, short value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<short> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] short[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<short> values);
        
    #endregion

    #region int
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, int value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<int> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] int[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<int> values);
        
    #endregion

    #region long
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, long value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<long> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] long[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<long> values);
        
    #endregion

    #region float
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, float value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<float> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] float[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<float> values);
        
    #endregion

    #region double
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, double value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<double> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] double[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<double> values);
        
    #endregion

    #region Guid
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, Guid value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<Guid> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] Guid[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<Guid> values);
        
    #endregion

    #region string
    
        /// <inheritdoc cref="AddValue(string,byte)"/>
        IHerculesTagsBuilder AddValue([NotNull] string key, string value);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<string> values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] string[] values);
        
        /// <inheritdoc cref="AddVector(string,IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<string> values);
        
    #endregion

    }
}