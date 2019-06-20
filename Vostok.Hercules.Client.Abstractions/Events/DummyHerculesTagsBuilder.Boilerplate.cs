using System;
using System.Collections.Generic;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public partial class DummyHerculesTagsBuilder
    {
        #region bool

        public IHerculesTagsBuilder AddValue(string key, bool value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<bool> values) => this;

        #endregion

        #region byte

        public IHerculesTagsBuilder AddValue(string key, byte value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<byte> values) => this;

        #endregion

        #region short

        public IHerculesTagsBuilder AddValue(string key, short value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<short> values) => this;

        #endregion

        #region int

        public IHerculesTagsBuilder AddValue(string key, int value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<int> values) => this;

        #endregion

        #region long

        public IHerculesTagsBuilder AddValue(string key, long value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<long> values) => this;

        #endregion

        #region float

        public IHerculesTagsBuilder AddValue(string key, float value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<float> values) => this;

        #endregion

        #region double

        public IHerculesTagsBuilder AddValue(string key, double value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<double> values) => this;

        #endregion

        #region Guid

        public IHerculesTagsBuilder AddValue(string key, Guid value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<Guid> values) => this;

        #endregion

        #region string

        public IHerculesTagsBuilder AddValue(string key, string value) => this;

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<string> values) => this;

        #endregion
    }
}