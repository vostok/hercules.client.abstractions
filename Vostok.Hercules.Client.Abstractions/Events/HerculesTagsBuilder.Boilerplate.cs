using System;
using System.Collections.Generic;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public partial class HerculesTagsBuilder
    {
    #region bool
    
        public IHerculesTagsBuilder AddValue(string key, bool value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<bool> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<bool> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region byte
    
        public IHerculesTagsBuilder AddValue(string key, byte value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<byte> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<byte> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region short
    
        public IHerculesTagsBuilder AddValue(string key, short value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<short> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<short> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region int
    
        public IHerculesTagsBuilder AddValue(string key, int value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<int> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<int> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region long
    
        public IHerculesTagsBuilder AddValue(string key, long value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<long> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<long> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region float
    
        public IHerculesTagsBuilder AddValue(string key, float value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<float> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<float> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region double
    
        public IHerculesTagsBuilder AddValue(string key, double value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<double> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<double> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region Guid
    
        public IHerculesTagsBuilder AddValue(string key, Guid value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<Guid> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<Guid> values) => AddVectorGeneric(key, values);
        
    #endregion

    #region string
    
        public IHerculesTagsBuilder AddValue(string key, string value) => AddValueGeneric(key, value);
        
        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<string> values) => AddVectorGeneric(key, values);
        
        public IHerculesTagsBuilder AddVector(string key, IEnumerable<string> values) => AddVectorGeneric(key, values);
        
    #endregion

    }
}