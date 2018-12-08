using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public partial interface IHerculesTagsBuilder
    {
        #region byte
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and byte <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, byte value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and byte <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<byte> values);

        #endregion

        #region bool
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and bool <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, bool value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and bool <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<bool> values);

        #endregion

        #region short
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and short <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, short value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and short <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<short> values);

        #endregion

        #region int
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and int <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, int value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and int <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<int> values);

        #endregion

        #region long
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and long <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, long value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and long <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<long> values);

        #endregion

        #region float
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and float <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, float value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and float <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<float> values);

        #endregion

        #region double
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and double <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, double value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and double <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<double> values);

        #endregion

        #region Guid
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and Guid <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, Guid value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and Guid <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<Guid> values);

        #endregion

        #region string
    
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and string <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, string value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and string <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<string> values);

        #endregion

    }
}